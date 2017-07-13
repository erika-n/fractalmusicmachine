using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace SoundLabBasics
{
    public class SoundBuffer 
    {
        private int _cutoffHigh;
        private int _cutoffLow;
        private Boolean _earProtection = false;

        private double[] _left;
        private double[] _right;
        private Boolean _mono;
        public const int RIGHT = 1, LEFT = 2;

        public SoundBuffer(double seconds)
        {   
            int samples = (int)(SoundUtil.SAMPLE_RATE * seconds);
            _left = new double[samples];
            _right = new double[samples];
        }

        public SoundBuffer(double[] left, double[] right)
        {
            _left = left;
            _right = right;
            if (_right == null)
            {
                _right = new double[left.Length];
                for (int i = 0; i < _left.Length; i++)
                {
                    _right[i] = _left[i];
                }

            }
        }

        public void Fade(int howManySamples)
        {
            Envelope e = new Envelope(howManySamples, howManySamples);
            for (int i = 0; i < howManySamples; i++)
            {
                double amp = e.NextAmpFactor();
                AmplifyOne(amp, i);
                AmplifyOne(amp, Length - 1 - i);
            }
            
        }

        private void AmplifyOne(double amp, int bufferOffset)
        {
            _left[bufferOffset] *= amp;
            _right[bufferOffset] *= amp;
        }

        public void Amplify(double amp)
        {
          for (int i = 0; i < _left.Length; i++)
          {
              _left[i] *= amp;
              _right[i] *= amp;
          }
            
        }

        public double ReadLeft(int bufferOffset)
        {
            return _left[bufferOffset];
        }

        public double ReadRight(int bufferOffset)
        {
            return _right[bufferOffset];
        }

        public void Write(double d, int bufferOffset)
        {
            _left[bufferOffset] = d;
            _right[bufferOffset] = d;
        }

        public void UseEarProtection(int cutoffLow, int cutoffHigh)
        {
            _earProtection = true;
            _cutoffHigh = cutoffHigh;
            _cutoffLow = cutoffLow;
        }


        public int Length
        {
            get { return _left.Length; }
        }

        public Boolean Mono
        {
            get { return _mono; }
        }

        public int getMilliseconds()
        {
            return 1000 *(int) ((double)Length/ SoundUtil.SAMPLE_RATE);
        }

        public void ApplyEnvelope(Envelope envelope)
        {
            for (int i = 0; i < Length; i++)
            {
                AmplifyOne(envelope.NextAmpFactor(),i);
            }
        }

        public void Add(double[] d, int bufferOffset)
        {

            _left[bufferOffset] += d[0];
            _right[bufferOffset] += d[1];
  
        }

        public void Add(double d, int bufferOffset)
        {
            _left[bufferOffset] += d;
            _right[bufferOffset] += d;
        }

        public void AddLeft(double d, int bufferOffset)
        {
            _left[bufferOffset] += d;
        }

        public void AddRight(double d, int bufferOffset)
        {
            _right[bufferOffset] += d;
        }



        public void WriteOscillations(IOscillator oscillator, double start, double end, Envelope envelope, int minWaves = 0, int maxWaves = 0, int rightleft = 0)
        {

            if (start > end)
            {
                double tmp = end;
                end = start;
                start = tmp;
            }

            double freq = oscillator.GetFrequency();
            if (_earProtection && !(oscillator is SampleOscillator))
            {
                if (freq < _cutoffLow || freq > _cutoffHigh)
                {
                    return; // Does not play sound if it doesn't fall within safe range
                }
            }


            double waveLength = SoundUtil.SAMPLE_RATE / freq;
            int minWidth = (int)(minWaves * waveLength);

            int left = (int)(start * Length);
            int right = Math.Max((int)(end * Length), left + minWidth);
            int maxWidth = right - left;
            if (maxWaves > 0)
            {
                maxWidth = (int)(maxWaves * waveLength);
            }
            right = Math.Min(right, left + maxWidth);
            envelope.Start(right - left);

            if (oscillator is SampleOscillator)
            {
                SampleOscillator sampleOscillator = (SampleOscillator)oscillator;
                sampleOscillator.Reset(left);

            }



            for (int i = left; i < right && i < Length; i++)
            {
                double amp = envelope.NextAmpFactor();
                double ampleft = rightleft == RIGHT ? 0 : amp;
                double ampright = rightleft == LEFT ? 0 : amp;
                //if (oscillator is SampleOscillator )
              //  {
                    // in stereo
                    double[] sample = oscillator.GetStereoSample(i);
                    
                    sample[0] *= ampleft;
                    sample[1] *= ampright;
                    Add(sample, i);
             //   }
             //   else
              //  {
                    // in mono 
              ////      _mono = true;
              //      double sample = oscillator.GetSample(i);
              //      sample *= amp;
              //      Add(sample, i);
             //   }
                

            }
        }
        public void MixInClip(SoundBuffer clip, double start, double amp)
        {
            int left = (int)(start * Length);
            for (int i = 0; i < clip.Length && i + left < Length; i++)
            {
                double clipLeft = clip.ReadLeft(i);
                double clipRight = clip.ReadRight(i);
                Add(new double[] {amp*clipLeft, amp*clipRight}, left + i);
            }
        }

        public void WriteSample(double d, int bufferOffset)
        {
            Write(d, bufferOffset);
        }

        public double[] GetLeft()
        {
            return _left;
        }

        public double[] GetRight()
        {
            return _right;
        }
        public void NormalizeVolume()
        {
            Amplify(0.5 / PeakAmp());

        }
        public double PeakAmp()
        {
            int ARR_SIZE = 1;
            LinkedList<double> largest = new LinkedList<double>();


            LinkedListNode<double> lastNode = largest.AddFirst(0);
            for (int i = 0; i < _left.Length; i++)
            {

                if (_left[i] > largest.First())
                {
                    lastNode = largest.AddAfter(lastNode, _left[i]);
                }
                if (_right[i] > largest.First())
                {
                    lastNode = largest.AddAfter(lastNode, _right[i]);
                }
                if (largest.Count > ARR_SIZE)
                {
                    largest.RemoveFirst();
                }
            }


            return largest.Average();
        }




    }

}
