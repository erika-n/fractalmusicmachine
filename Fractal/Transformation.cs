using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using SoundLabBasics;


namespace FractalProject
{
    using System.Drawing;
    public class Transformation
    {
        public double start, end;
        public double multFrequency;
        public Color color;
        public int freqMode = 0;
        public double addFrequency;
        const int NATURAL = 1, PYTHAGOREAN = 0;
        private Random random;

        public Transformation()
        {
            random = new Random();
        }

        public Transformation(double start, double end, double multFrequency, Color color, double addFrequency = 0)
        {
            random = new Random();
            this.start = start;
            this.end = end;
            this.multFrequency = multFrequency;
            this.addFrequency = Math.Floor(100 * random.NextDouble());
            this.color = color;

        }

        public double getNewFreq(double freq)
        
        {
           // freq = freq + addFrequency;
           //if (freq < 0)
           // {
           //     freq += -2*addFrequency;
           // }

            freq = freq * multFrequency;
            return freq; 
        }

        public Transformation Clone()
        {
            return new Transformation(this.start, this.end, this.multFrequency, this.color);
        }

    }
}
