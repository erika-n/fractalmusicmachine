using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLabBasics
{
    public class SineOscillator:IOscillator
    {
        private double _frequency;
        private double _amplitude;
        private double _offset;

        public SineOscillator(double frequency, double amplitude, double offset = 0)
        {

            _amplitude = amplitude;
            _frequency = frequency;
            _offset = offset;
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
            return _amplitude* Math.Sin(bufferOffset * 2 * Math.PI * _frequency / SoundUtil.SAMPLE_RATE + _offset);
        }

        public double[] GetStereoSample(int bufferOffset)
        {
            double sample = GetSample(bufferOffset);
            return new double[] { sample, sample };
        }

    }
}
