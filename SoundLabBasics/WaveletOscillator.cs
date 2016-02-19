using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLabBasics
{

    public class WaveletOscillator : IOscillator
    {
        private double _frequency;
        private double _amplitude;
        private double _offset;
        private double _time;
        private const double STEP = 20*Math.PI;

        public WaveletOscillator(double frequency, double amplitude, double offset = 0)
        {
            _time = 0;
            _amplitude = amplitude;
            _frequency = frequency;
            _offset = offset;
        }


        public double Frequency
        {
            get { return _frequency; }
            set { _frequency = value; }
        }

        public double Amplitude
        {
            get { return _amplitude; }
            set { _amplitude = value; }
        }
        public double Phase
        {
            get { return _offset; }
            set { _offset = value; }
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
            _time += STEP;
            double r = _amplitude * (Math.Cos(_time ) / ( _time));
            return r;
        }

        public void PeakAt(int bufferWhen, int bufferNow)
        {
            _time = (bufferNow - bufferWhen) *STEP;
        }

        public double[] GetStereoSample(int bufferOffset)
        {
            double sample = GetSample(bufferOffset);
            return new double[] { sample, sample };
        }

    }
}
