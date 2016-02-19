using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLabBasics
{
    class LFO
    {
        IOscillator childOscillator;
        IOscillator lfo;

        void SetFreqency(double frequency)
        {
            lfo.SetFrequency(frequency);
        }
        void SetAmplitude(double amplitude)
        {
            lfo.SetAmplitude(amplitude);
        }

    }
}
