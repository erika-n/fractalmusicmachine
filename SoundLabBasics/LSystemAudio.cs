using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLabBasics
{
    public class LSystemAudio
    {
        LSystem _lSystem;


        SoundBuffer[] _grains;


        public LSystemAudio(LSystem lSystem)
        {
            _lSystem = lSystem;
            var amp = 0.05;
            _grains = new SoundBuffer[3];
            _grains[0] =  new SoundBuffer(0.1);
            _grains[0].WriteOscillations(new SineOscillator(400, amp), 0, 1.0, new Envelope());
            _grains[1] = new SoundBuffer(0.1);
            _grains[1].WriteOscillations(new SineOscillator(150, amp), 0, 1.0, new Envelope());
            _grains[2] = new SoundBuffer(0.1);
            _grains[2].WriteOscillations(new SineOscillator(150, 0), 0, 1.0, new Envelope());

        }


        public SoundBuffer CreateSound(int seconds, int depth)
        {
            string lstring = _lSystem.StringAtDepth(depth);
            Console.WriteLine(lstring);
            SoundBuffer soundBuffer = new SoundBuffer(seconds);
            double curLoc = 0;
            double amp = 1;
            double step = 1.0 / lstring.Length;
            SoundBuffer curGrain = _grains[0];
            foreach (char c in lstring)
            {
                if (c == '+')
                {
                    curGrain = _grains[0];
                }
                else if(c == 'F')
                {
                    curGrain = _grains[1];
                }
                else
                {
                    curGrain = _grains[2];
                }
                soundBuffer.MixInClip(curGrain, curLoc, amp);
                curLoc += step;

            }


            return soundBuffer;
        }



        /** old
        public SoundBuffer CreateSound(int seconds, int depth){
            string lstring = _lSystem.StringAtDepth(depth);
            Console.WriteLine("LString = {0}", lstring);
      
            SoundBuffer buffer = new SoundBuffer(seconds);


            int subdivisions = 10*seconds;
            int loc = subdivisions/2;
            int[] clipDepth = new int[subdivisions];
            Turtle t = new Turtle(new Point(loc, 0));
            foreach(char c in lstring.ToCharArray()){
                if (c == '*')
                {
                    swapGrains();
                }
                else
                {
                    t.ExecuteCommand(c);
                }
                if (!t.IsHorizontal() && t.CurrentLocation().X < subdivisions && t.CurrentLocation().X > 0)
                {
                    clipDepth[t.CurrentLocation().X]++;
                }




            }
            for (int i = 0; i < clipDepth.Length; i++)
            {

                buffer.MixInClip(_curGrain, (double)i / subdivisions, (double)clipDepth[i]/clipDepth.Max());
            }

            return buffer;
        }

        private void swapGrains()
        {
            if (_curGrain.Equals(_highGrain))
            {
                _curGrain = _lowGrain;
         
            }
            else
            {
                _curGrain = _highGrain;
            }
        }


        /// charsToInts:
        // returns an array of ints representing characters strings as amplitudes such that if
        // you have ++++AA+AA+++AA+AA++A+ you would get an int for each set of +'s,
        // so {4, 1, 3, 1, 2, 1}
        public static int[] charsToInts(string str, char symbol)
        {
            Boolean inAmp = false;
            List<int> amps = new List<int>();
            int curAmp = 0;
            foreach (char c in str.ToCharArray())
            {

                if (c == symbol)
                {
                    if (!inAmp)
                    {
                        inAmp = true;
                        if (curAmp > 0)
                        {
                            amps.Add(curAmp);
                        }
                        curAmp = 0;
                    }
                    curAmp++;
                }
                else
                {
                    inAmp = false;
                }

            }

            amps.Add(curAmp);

            return amps.ToArray();
        }


        **/

    }
}
