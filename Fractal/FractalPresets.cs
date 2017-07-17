using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Diagnostics;


namespace FractalProject
{
    public class FractalPresets
    {
        public int seconds, depth, attackDecay, minWaves, maxWaves, mod,oscillator;
        public double baseFreq, amplitude;
        public string sample;
        public bool earProtection;
        public int cutoffHigh, cutoffLow;
        public string name;
        public Transformation[] transformations;
        private static Random _random = new Random();

        public static void Save(FractalPresets fractalPresets, string name)
        {

            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(FractalPresets));

            System.IO.StreamWriter file = new System.IO.StreamWriter(SoundLabBasics.SoundUtil.PRESETS_FOLDER + "\\"+
                name + ".xml");
            writer.Serialize(file, fractalPresets);
            file.Close();
        }

        public static FractalPresets Load(string name)
        {
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(FractalPresets));
            System.IO.StreamReader file = new System.IO.StreamReader(SoundLabBasics.SoundUtil.PRESETS_FOLDER + "\\" + 
                name + ".xml");
  
            FractalPresets returning = (FractalPresets)reader.Deserialize(file);

            file.Dispose();
            return returning;
        }


        public static FractalPresets samplePresets()
        {
            const int DEPTH = 3;
            const int SECONDS = 5;
            const double BASE_FREQ = 300;
            const double AMPLITUDE = 0.03;

            const int MIN_WAVES = 10;
            const int MAX_WAVES = 0;
            const int ATTACK_DECAY = 100;
            const int OSCILLATOR = Fractal.SINE;
            const string SAMPLE = "unsure";
            const bool EAR_PROTECTION = false;
            const int CUTOFF_LOW = 200;
            const int CUTOFF_HIGH = 1000;

            FractalPresets sample = new FractalPresets();
            sample.depth = DEPTH;
            sample.seconds = SECONDS;
            sample.baseFreq = BASE_FREQ;
            sample.amplitude = AMPLITUDE;
            sample.minWaves = MIN_WAVES;
            sample.maxWaves = MAX_WAVES;
            sample.attackDecay = ATTACK_DECAY;
            sample.oscillator = OSCILLATOR;
            sample.sample = SAMPLE;
            sample.transformations = sampleTransformations();
            sample.earProtection = EAR_PROTECTION;
            sample.cutoffHigh = CUTOFF_HIGH;
            sample.cutoffLow = CUTOFF_LOW;
            return sample;
        }


        public static Transformation[] sampleTransformations()
        {
            ColorConverter cc = new ColorConverter();
         
            return new Transformation[] {
                         
                new Transformation(0.25, 0.75, 4,  Color.FromArgb(255, 0x33, 0x99, 0x99)),
                new Transformation(0.75, 1.0, 6, Color.FromArgb(255, 0x66, 0x66, 0xcc)),
                new Transformation(0.5, 0,3, Color.FromArgb(255, 0x00, 0x66, 0xcc)), 
                new Transformation(0.5, 1,2,  Color.FromArgb(255, 0x33, 0x99, 0x99)) 



                // Glass xylophone: 
                /**
                new Transformation(0.3333, 0.66666, 0, 1, 0, MOD),
                new Transformation(0.0, 0.66666, 0,0.25, 0, MOD),
                new Transformation(0.6666, 1.0, 0, 0.5, 0, MOD), 
                
                new Transformation(0.0, 0.5, 0, 0.75, 0, MOD), 
               **/
                
                
                
                // test samples
                /**
                new Transformation(0.0, 0.5, 0, 0.5, 0, MOD),
                new Transformation(0.75, 1.0, 0, 0.5, 0, MOD),
                new Transformation(0.25, 0.75, 0, 1.0, 0, MOD), 
                **/


                 // Demo with easy frequencies: 
                /**
                new Transformation(0.6666, 1.0, 2*BASE_ADD_FREQ, 1, 100, MOD),
                new Transformation(0.0, 0.5, BASE_ADD_FREQ,1, 600, MOD),
                new Transformation(0.33333, 0.75, 3*BASE_ADD_FREQ, 400, 400, MOD), 
               **/


               // Nice 0.5: 
              /**
               new Transformation(0.5, 1.0, 0,0.2, 0, MOD),
               new Transformation(0.0, 0.5, 0,0.4, 0, MOD),
               new Transformation(0.0, 0.5, 0,0.1, 0, MOD),
              **/
               
               // NICE base_freq 250
               /**
               new Transformation(0.6666, 1.0, BASE_ADD_FREQ,12, 0, MOD),
               new Transformation(0.0, 0.5, -2*BASE_ADD_FREQ,8, 0, MOD),    
               new Transformation(0.0, 0.66666, BASE_ADD_FREQ,6, 0, MOD),
               new Transformation(0.0, 0.33333, BASE_ADD_FREQ,4, 0, MOD),
               **/
               

               // something else
               /**
               new Transformation(0.0, 0.25, BASE_ADD_FREQ,8, 0, MOD),
               new Transformation(0.25, 0.3, -2*BASE_ADD_FREQ,2, 0, MOD),    
               new Transformation(0.5, 1.0, BASE_ADD_FREQ,6, 0, MOD),
               new Transformation(0.5, 1.0, BASE_ADD_FREQ,4, 0, MOD),
               **/

               // cantor dust
               /**
               new Transformation(0.0, 0.3333, BASE_ADD_FREQ,0.3333, 0, MOD),
               new Transformation(0.6666, 1.0, -2*BASE_ADD_FREQ,0.3333, 0, MOD),    
               **/
               //

               // sierpinsky triangle
               
               /**
               new Transformation(0.25, 0.75, 8 ),    
               new Transformation(0.5, 1.0, 6),
               new Transformation(0.0, 0.5,4),
               **/
               //random
               
               /**
               rand1,
               rand2,
               rand3,
               rand4,
               rand5
              **/

  
     
                
                
                
  
           
        };
            
        }


        public static Transformation randomTransformation()
        {
            Random r = _random;
            //int[] freqMultipliers = { 2, 3, 4, 6, 8 };
            //double freqMultiplier = freqMultipliers[(int) (_random.NextDouble() * freqMultipliers.Length)];

            //double factor = 4;
            //double start = ((int)(r.NextDouble() * factor)) / factor;
            //double end = ((int)(r.NextDouble() * factor)) / factor; ;
            //while (start == end)
            //{
            //    end = ((int)(r.NextDouble() * factor)) / factor;
            //}

            //Transformation t = new Transformation(start, end, freqMultiplier, Color.White);
            //Debug.WriteLine("t: t.start: {0}, t.end: {1}, t.freq: {2}", t.start, t.end, t.multFrequency);
            Transformation t = new Transformation(getRandom(), getRandom(), getRandom() , Color.White, getRandom(), getRandom(), getRandom());
            return t;
        }

        private static double getRandom()
        {
            return (double) _random.Next(0, 4) / 4;
        }
        


    }
}
