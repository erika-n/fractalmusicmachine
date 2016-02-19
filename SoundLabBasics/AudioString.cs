using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLabBasics
{
    public class AudioString
    {
        public SoundBuffer[] _grains;
        const int NUM_CHARS = 4;
        public AudioString()
        {
            _grains = new SoundBuffer[NUM_CHARS];
            double amp = 0.5;
            _grains[0] = new SoundBuffer(0.1);
            _grains[0].WriteOscillations(new SineOscillator(400, amp), 0, 1.0, new Envelope());
            _grains[1] = new SoundBuffer(0.1);
            _grains[1].WriteOscillations(new SineOscillator(300, amp), 0, 1.0, new Envelope());
            _grains[2] = new SoundBuffer(0.1);
            _grains[2].WriteOscillations(new SineOscillator(150, amp), 0, 1.0, new Envelope());
            _grains[3] = new SoundBuffer(0.1);
            _grains[3].WriteOscillations(new SineOscillator(150, 0), 0, 1.0, new Envelope());
            
        }
        
        public SoundBuffer StringAsAudio(string p, int seconds)
        {
            SoundBuffer soundBuffer = new SoundBuffer(seconds);
            double curLoc = 0;
            double amp = 1;
            double step = 1.0 / p.Length;
         
            foreach (char c in p)
            {
                SoundBuffer curGrain = _grains[c - 'A'];
                soundBuffer.MixInClip(curGrain, curLoc, amp);
                curLoc += step;
            }


            return soundBuffer;
        }


        public SoundBuffer StringAsAudioSamples(string p)
        {
            SoundBuffer soundBuffer = new SoundBuffer((double)p.Length / SoundLabBasics.SoundUtil.SAMPLE_RATE);
            double amp = 0.01;
            int offset = 0;
            foreach (char c in p)
            {
                int multiplier = c - 'A';
                if (multiplier == 0)
                {
                    multiplier = 0;
                }
                else if( multiplier % 2 == 0)
                {
                    multiplier = -1;
                }
                else { multiplier = 1; }
                soundBuffer.Add(multiplier * amp, offset);
                offset++;
            }

            return soundBuffer;
        }

    }
}
