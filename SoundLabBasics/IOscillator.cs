using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLabBasics
{
    public interface IOscillator
    {
        double GetSample(int bufferOffset);
        double[] GetStereoSample(int bufferOffset);
        void SetFrequency(double frequency);
        void SetAmplitude(double amplitude);
        double GetFrequency();
        double GetAmplitude();


    }

}
