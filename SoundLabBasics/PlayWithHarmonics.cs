using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLabBasics
{
    public class PlayWithHarmonics
    {
        public PlayWithHarmonics()
        {

        }

        public SoundBuffer run(int seconds)
        {
            Random r = new Random();
            SoundBuffer sb = new SoundBuffer(seconds);

            double baseFrequency = 300;
            double baseAmplitude = 0.01;
            SineOscillator so = new SineOscillator(baseFrequency, baseAmplitude);
        

            for (int i = 1; i < 12; i+=1)
            {
                for (int j = 1; j < 5; j++)
                {
                    so.SetFrequency(baseFrequency * i/j);
                    so.SetAmplitude(baseAmplitude);

                    sb.WriteOscillations(so, 0, 1, new Envelope());
                    baseAmplitude *= 0.9;
                }
            }

            return sb;
        }

    }
}
