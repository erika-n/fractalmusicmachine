using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLabBasics
{
    public class PulseOscillator: IOscillator
    {
        double _frequency;
        double _amplitude;
        double _offset;
        public double GetSample(int bufferOffset) 
        {
            double samplesPerOscillation = SoundUtil.SAMPLE_RATE / _frequency;
            if((bufferOffset > _offset) && (bufferOffset - _offset < samplesPerOscillation)){
                //double depthIntoOscillations = ((bufferOffset - _offset) % samplesPerOscillation) / samplesPerOscillation;
                return _amplitude; //* Math.Sin(depthIntoOscillations * Math.PI * 2);
            }
            else
            {
                return 0;
            }
        }

        public double[] GetStereoSample(int bufferOffset)
        {
            double sample = GetSample(bufferOffset);
            return new double[] {sample, sample};
        }

        public PulseOscillator(double frequency, double amplitude, double offset)
        {
            _frequency = frequency;
            _amplitude = amplitude;
            _offset = offset;
        }
        public void SetOffset(double offset)
        {
            _offset = offset;
        }
        public void SetFrequency(double frequency) 
        {
            //_frequency = frequency;
        }
        public void SetAmplitude(double amplitude) 
        {
            _amplitude = amplitude;
        }
        public double GetFrequency() 
        { 
            return _frequency; 
        }
        public double GetAmplitude() 
        { 
            return _amplitude; 
        }


    }
}
