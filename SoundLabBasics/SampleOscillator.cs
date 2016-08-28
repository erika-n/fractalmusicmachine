using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SoundLabBasics
{
    public class SampleOscillator:IOscillator
    {
        private double _amplitude;
        private double _frequency;
        private int _offset = 0;
        private int _locOffset = 0;
        SoundBuffer _soundBuffer;
        const int SUPPRESS_ENDS = 200;

        public SampleOscillator(SoundBuffer soundBuffer, double frequency = 400, double amplitude = 1)
        {
            _frequency = frequency;
            _amplitude = amplitude;
            _soundBuffer = soundBuffer;
        }

        public SampleOscillator(string fileName, double frequency = 400, double amplitude = 1)
        {
            _frequency = frequency;
            _amplitude = amplitude;
            _soundBuffer = WavFile.Open(fileName);
            for (int i = 0; i < 100; i++)
            {
                _soundBuffer.WriteSample(0, i);
            }
            for (int i = _soundBuffer.Length - 1; i > _soundBuffer.Length - SUPPRESS_ENDS/2; i--)
            {
                _soundBuffer.WriteSample(0, i);

            }
        }


        public double GetSample(int bufferOffset)
        {
           // Debug.WriteLine("bufferOffset: " + bufferOffset + ", data = " + _soundBuffer.Data[bufferOffset]);
            return _amplitude*_soundBuffer.ReadLeft((bufferOffset -_locOffset + _offset) % _soundBuffer.Length);
        }

        public double[] GetStereoSample(int bufferOffset)
        {
            double[] sample = new double[2];
            if (_frequency < 0)
            {
                sample[0] = 0;
                sample[1] = 0;
            }
            else
            {
                sample[0] = _amplitude * _soundBuffer.ReadLeft((bufferOffset - _locOffset + _offset) % _soundBuffer.Length);
                sample[1] = _amplitude * _soundBuffer.ReadRight((bufferOffset - _locOffset + _offset) % _soundBuffer.Length);
            }
            return sample;
        }

        public void Reset(int bufferOffset)
        {
            _locOffset = bufferOffset;
        }

        public void SetFrequency(double frequency)
        {
            if (frequency < 0)
            {
                _frequency = frequency;
                return;
            }
            double freqhash = new Random((int)frequency).NextDouble();
            _offset = (int)(freqhash*(double)_soundBuffer.Length) % (_soundBuffer.Length - 2*SUPPRESS_ENDS) + SUPPRESS_ENDS;
            Debug.WriteLine("_offset = " + _offset + " out of " + _soundBuffer.Length);
            if (_offset < 0)
            {
                Debug.WriteLine("wtf _offset = " + _offset);
                _offset = 0; // NOTE: this is a glitchy way to deal with glitch when the frequency is really really big. 
            }

            if (_offset > _soundBuffer.Length - SUPPRESS_ENDS)
            {
                Debug.WriteLine("offset too big");
            }
            _frequency = frequency;
           

        }

        public void SetAmplitude(double amplitude)
        {

            this._amplitude = amplitude;

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
