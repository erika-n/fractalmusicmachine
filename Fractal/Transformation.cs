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
        const int NATURAL = 1, PYTHAGOREAN = 0;

        public Transformation()
        {

        }

        public Transformation(double start, double end, double multFrequency, Color color)
        {
            this.start = start;
            this.end = end;
            this.multFrequency = multFrequency;
            this.color = color;

        }

        public double getNewFreq(double freq)
        
        {

            freq = freq * multFrequency;
            
            return freq; 
        }

        public Transformation Clone()
        {
            return new Transformation(this.start, this.end, this.multFrequency, this.color);
        }

    }
}
