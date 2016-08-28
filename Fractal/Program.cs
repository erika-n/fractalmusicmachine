using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoundLabBasics;
using System.Diagnostics;
using System.Drawing;

namespace FractalProject
{
    class Program
    {


        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("Running...");
            Fractal fractal = testFractal();
            stopWatch.Stop();
            Console.WriteLine("Elapsed time: " + stopWatch.ElapsedMilliseconds/1000);
            Console.ReadLine();
        }

        public static Fractal testFractal()
        {
            FractalPresets thePresets = FractalPresets.Load("testFractal");
            foreach(Transformation t in thePresets.transformations){
                t.color = Color.FromArgb(255, 0x33, 0x99, 0x99);
            }
          
            Fractal fractal = new Fractal(thePresets);
            fractal.run(fractal.totalSteps());
            //fractal.runRecursively();


            Console.Write(fractal.frequencyHist());
            WavFile.Save("test_fractal.wav", fractal.getSound());
            WavFile.Save(FractalImage.VIDEO_FOLDER + "test_fractal.wav", fractal.getSound());
            Bitmap fractalImage = fractal.getScore();
            fractalImage.Save(FractalImage.VIDEO_FOLDER + "test_fractal.gif");
            return fractal;
        }

        public static void testFractalImages(Fractal fractal)
        {
            fractal.dumpScoreAnimationsToFiles("test_video", 25);
            
        }


    }
}
