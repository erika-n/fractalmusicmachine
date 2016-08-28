using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLabBasics
{
    public class SoundUtil
    {
        public const int SAMPLE_RATE = 44100;
        public const string PROGRAM_NAME = "Fractal Music Machine";
        public static string SAMPLES_FOLDER = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + PROGRAM_NAME + "\\sounds";
        public static string SAVE_FOLDER = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + PROGRAM_NAME + "\\saved";
        public static string PRESETS_FOLDER = SAVE_FOLDER;
       
    }
}
