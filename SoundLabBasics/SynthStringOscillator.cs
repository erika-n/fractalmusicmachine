using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLabBasics
{
    public class SynthStringOscillator:IOscillator
    {
        private double _frequency;
        private double _amplitude;
        private double _offset;

        public SynthStringOscillator(double frequency, double amplitude, double offset = 0)
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

        private double sineForFrequency(int bufferOffset, double frequency)
        {
            return Math.Sin(bufferOffset * 2 * Math.PI * frequency/SoundUtil.SAMPLE_RATE);
        }
        public double GetSample(int bufferOffset)
        {
            double rsample = 0;
            double amp = _amplitude;
            int numHarmonics = 5;
            int numPartials = 5;
            for (int harmonic = 1; harmonic < numHarmonics + 1; harmonic+= 1)
            {
                
                double partialAmp = amp;
                for (int partial = 1; partial < numPartials + 1; partial += 1 ){
                    partialAmp *= 0.9;
                    rsample += partialAmp * sineForFrequency(bufferOffset, (harmonic/partial) * _frequency);
                }
                amp *= 0.7;
            }
            return rsample;
        }

        public double[] GetStereoSample(int bufferOffset)
        {
            double sample = GetSample(bufferOffset);
            return new double[] { sample, sample };
        }
    }
}
