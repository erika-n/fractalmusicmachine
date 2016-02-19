using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLabBasics
{
    public class Experiment1
    {
        // Results of stretching and folding experiment:
        // stretching and folding a single point tends to produce a siren-like noise.

        // Resultes of mandelbrot experiment:
        // mandelbrot goes too smoothly up and down to sonify directly this way.


        private SoundBuffer _soundBuffer;
        public Experiment1(int seconds)
        {

        }



        public SoundBuffer Sound {get {return _soundBuffer;}}
    }
}
