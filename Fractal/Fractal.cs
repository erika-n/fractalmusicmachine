using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoundLabBasics;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;

namespace FractalProject
{
    public class Fractal:IDisposable
    {
        public const int SINE = 0, SQUARE = 1, SAWTOOTH = 2, SAMPLE = 3, SYNTHSTRING = 4, WAVELET = 5;
        
        SoundBuffer _buffer;
        FractalImage _fractalImage;
        IOscillator _oscillator;
        int[] _freqHist; // keep track of number of times each frequency range is hit, for purposes of seeing whether we have a good range for hearing.
        static int FREQ_HIST_MAX = 8000;
        Envelope _envelope;
        int _width, _height;
        static Random _random = new Random();
        double _baseFreq;
        int _depth;
        int _minWaves, _maxWaves;
        int _seconds;
        Transformation[] _transformations;
        private double avgFreq;



        public Fractal(FractalPresets vals, int width = 500, int height = 500)
        {
            _envelope = new Envelope(vals.attackDecay, vals.attackDecay);
            _baseFreq = vals.baseFreq;
            _depth = vals.depth;
            _transformations = vals.transformations;
            _minWaves = vals.minWaves;
            _maxWaves = vals.maxWaves;
            _seconds = vals.seconds;
            _buffer = new SoundBuffer(vals.seconds);
            if (vals.earProtection)
            {
                _buffer.UseEarProtection(vals.cutoffLow, vals.cutoffHigh);
            }

            if (vals.oscillator == SINE)
            {
                _oscillator = new SineOscillator(440, vals.amplitude);
            }
            else if (vals.oscillator == SQUARE)
            {
                _oscillator = new SquareOscillator(440, vals.amplitude);
            }
            else if (vals.oscillator == SAWTOOTH)
            {
                _oscillator = new SawtoothOscillator(440, vals.amplitude);
            }
            else if (vals.oscillator == SAMPLE)
            {
                _oscillator = new SampleOscillator(SoundUtil.SAMPLES_FOLDER + "\\" + vals.sample + ".wav");
                _oscillator.SetAmplitude(vals.amplitude);
            }
            else if (vals.oscillator == SYNTHSTRING)
            {
                _oscillator = new SynthStringOscillator(440, vals.amplitude);
            }

            _width = width;
            _height = height;
            _freqHist = new int[FREQ_HIST_MAX / 100];
            _fractalImage = new FractalImage(_width, _height, _baseFreq);
        }


        public void Dispose()
        {
            if (_fractalImage != null)
            {
                _fractalImage.Dispose();
            }
        }
        



        public Stack<FractalStackObject> run(int steps)
        {
            FractalStackObject initialObject = new FractalStackObject(_depth, 0, 1, 0, 0, 1, null, 1);
            Stack<FractalStackObject> theStack = new Stack<FractalStackObject>();
            avgFreq = averageTransformationFrequency(_transformations);

            theStack.Push(initialObject);
            return partialStackRun(theStack, steps);
        }


        public int totalSteps()
        {
            return (int)Math.Pow(_transformations.Length, _depth);
        }


        public Stack<FractalStackObject> partialStackRun(Stack<FractalStackObject> theStack, int howMany)
        {
            
            FractalStackObject thisRun;
            while (howMany > 0 && theStack.Count > 0 )
            {
                thisRun = theStack.Pop();


                double finalFreq = (thisRun.freq + thisRun.freq2)/2;

                if(! (_oscillator is SampleOscillator) ){
                    finalFreq = 400 * Math.Log(finalFreq);
                }
                double finalSoft = (thisRun.soft1 + thisRun.soft2) / 2;
                
                Color color = Color.White;
                if (thisRun.parentRect != null)
                {
                    color = thisRun.parentRect.color;
                }
                FractalRect newRect = new FractalRect(thisRun.start, thisRun.end, thisRun.freq, thisRun.freq2, thisRun.depth, thisRun.parentRect, thisRun.freq, color, finalSoft);
                //finalFreq = finalFreq * _baseFreq/ (Math.Pow(avgFreq, _depth));
                _fractalImage.add(newRect);
                thisRun.parentRect = newRect;

                if (thisRun.depth == 0)
                {
                    howMany--;

                    _oscillator.SetFrequency(finalFreq);
                    _oscillator.SetAmplitude(finalSoft);
                    _buffer.WriteOscillations(_oscillator, thisRun.start, thisRun.end, _envelope, _minWaves, _maxWaves);
                    //if (finalFreq < 0)
                    //{
                    //    finalFreq *= -1; // TODO: this is a hack
                    //}
                    
                    //if (finalFreq < FREQ_HIST_MAX)
                    //{

                    //    _freqHist[(int)(finalFreq / 100)]++;
                    //}
                    //else
                    //{
                    //    _freqHist[_freqHist.Length - 1]++;
                    //}
                }
                else
                {
                    double ybuffer = (thisRun.ymax - thisRun.ymin) * 0.1;
                    double ystep = ((thisRun.ymax - thisRun.ymin) - 2 * ybuffer) / _transformations.Length;
                    double newymax = thisRun.ymin + ystep + ybuffer;
                    double newymin = thisRun.ymin + ybuffer;

                    foreach (Transformation t in _transformations)
                    {
                       // double length = thisRun.end - thisRun.start;
                        
                        FractalRect newParent = thisRun.parentRect.Clone();
                        newParent.color = t.color;
                        //theStack.Push(new FractalStackObject(thisRun.depth - 1, thisRun.start + length * t.start, thisRun.start + length * t.end, t.getNewFreq(thisRun.freq, thisRun.freq2), newymin, newymax, newParent));
                        //double[,] newVals = t.getNewVals(new double[,]{{thisRun.start, thisRun.freq, 1}});
                        double[] newLocs = t.getNewVals(thisRun.start, thisRun.end);
                        double[] newFreqs = t.getNewFreqs(thisRun.freq, thisRun.freq2);
                        double[] newSofts = t.getNewSofts(thisRun.soft1, thisRun.soft2);
                        




                        theStack.Push(new FractalStackObject(thisRun.depth - 1, newLocs[0], newLocs[1], newFreqs[0], newymin, newymax, newParent, newFreqs[1], newSofts[0], newSofts[1]));
                        //theStack.Push(new FractalStackObject(thisRun.depth - 1, newVals[0,0], thisRun.end, newVals[0, 1], newymin, newymax, newParent, thisRun.freq2, thisRun.soft1, thisRun.soft2));

                        newymin += ystep;
                        newymax += ystep;
                    }
                }

                
            }

            return theStack;

        }

        public void finish()
        {
            _buffer.Fade(1000);
            double peakAmp = _buffer.PeakAmp();
            //if (peakAmp > 0.5)
            //{
                _buffer.Amplify(0.5 / peakAmp);
            //}
        }

        public string frequencyHist()
        {
            string s = "";
            s += "Frequencies: \n";
            int i = 0;
            for (; i < FREQ_HIST_MAX/100 - 1; i++)
            {
                s += i*100 + ": " + _freqHist[i] + "\n";
            }

            s += "> " + i * 100 + ": " + _freqHist[i] + "\n";
            s += "total count = " + totalSteps() + "\n\n";
            return s;
        }

        public Bitmap getScoreAnimation(double time)
        {
            int depth = _depth;
            Bitmap scoreAnimation = _fractalImage.animateScore(time, depth);
            return scoreAnimation;
        }

        public Bitmap getScore()
        {
            return _fractalImage.getScore(_depth);
        }

        public Bitmap getTransitionAnimation(double time)
        {
            return _fractalImage.animateTransition(time, _depth);
        }

        public void dumpScoreAnimationsToFiles(string fileName, double frameRate)
        {
            WavFile.Save(FractalImage.VIDEO_FOLDER + "\\test_fractal.wav", getSound());
            _fractalImage.dumpScoreAnimationFrames(fileName, frameRate, _seconds, _depth);
        }

        public void dumpTransitionAnimationsToFiles(string fileName, double frameRate, int seconds)
        {
            WavFile.Save(FractalImage.VIDEO_FOLDER + "\\test_fractal.wav", getSound());
            _fractalImage.dumpScoreAnimationFrames(fileName, frameRate, seconds, _depth, FractalImage.TRANSITION);
        }

        public SoundBuffer getSound()
        {
            return _buffer;
        }


        public Bitmap getImage()
        {
            return _fractalImage.stillImage(_depth);
        }

        private double averageTransformationFrequency(Transformation[] transformations)
        {
            double returning = 1;
            foreach (Transformation t in transformations)
            {
                returning *= t.multFrequency;
            }
            if (returning < 0)
            {
                returning *= -1;
            }
            returning = Math.Pow(returning, (1.0 / transformations.Length));
            return returning;
        }

        public void setStarMode(Boolean starMode)
        {
            _fractalImage.setStarMode(starMode);
        }


        public void saveAsSVG(string fileName)
        {
            _fractalImage.saveAsSVG(fileName);
        }

    }
    public class FractalStackObject
    {
        public int depth;
        public double start, end, freq, ymin, ymax, freq2, soft1, soft2;
        public FractalRect parentRect;
        public FractalStackObject(int depth, double start, double end, double freq, double ymin, double ymax, FractalRect parentRect, double freq2 = 0, double soft1 = 0, double soft2 = 1)
        {
            this.depth = depth;
            this.start = start;
            this.end = end;
            this.freq = freq;
            this.freq2 = freq2;
            this.ymax = ymax;
            this.ymin = ymin;
            this.parentRect = parentRect;
            this.soft1 = soft1;
            this.soft2 = soft2;
        }




    }




}
