using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLabBasics
{
    public class NoiseOscillator:IOscillator
    {
        
        private double _frequency;
        private double _amplitude;
        private Random _random;

        public NoiseOscillator(double frequency, double amplitude)
        {

            _amplitude = amplitude;
            _frequency = frequency;
            _random = new Random();
        }


        public double Frequency
        {
            get { return _frequency; }
            set {  _frequency = value; }
        }

        public double Amplitude
        {
            get { return _amplitude; }
            set { _amplitude = value; }
        }

        public void SetFrequency(double frequency)
        {
            _frequency = frequency;
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

        public double GetSample(int bufferOffset)
        {
            return _amplitude* (_random.NextDouble() - 0.5);
        }

        public double[] GetStereoSample(int bufferOffset)
        {
            double sample = GetSample(bufferOffset);
            return new double[] { sample, sample };
        }

    }


    
}
