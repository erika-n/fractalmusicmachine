using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLabBasics
{
    public class WavFile
    {

        // convert two bytes to one double in the range -1 to 1
        static double bytesToDouble(byte firstByte, byte secondByte)
        {
            // convert to range from -1 to (just below) 1
            return bytesToShort(firstByte, secondByte)/ 32768.0;
        }
        static short bytesToShort(byte firstByte, byte secondByte)
        {
            // convert two bytes to one short (little endian)
            return (short)((secondByte << 8) | firstByte);
        }

        // Opens wav file and returns mono sound buffer (left channel only)
        public static SoundBuffer Open(string filename)
        {
            double[] left, right;
            byte[] wav = System.IO.File.ReadAllBytes(filename);

            // Determine if mono or stereo
            int channels = wav[22];     // Forget byte 23 as 99.999% of WAVs are 1 or 2 channels
            
            // Get past all the other sub chunks to get to the data subchunk:
            int pos = 12;   // First Subchunk ID from 12 to 16

            // Keep iterating until we find the data chunk (i.e. 64 61 74 61 ...... (i.e. 100 97 116 97 in decimal-- "data")
            while (!(wav[pos] == 100 && wav[pos + 1] == 97 && wav[pos + 2] == 116 && wav[pos + 3] == 97))
            {
                pos += 4;
                int chunkSize = wav[pos] + wav[pos + 1] * 256 + wav[pos + 2] * 65536 + wav[pos + 3] * 16777216;
                pos += 4 + chunkSize;
            }
            pos += 8;

            // Pos is now positioned to start of actual sound data.
            int samples = (wav.Length - pos) / 2;     // 2 bytes per sample (16 bit sound mono)
            if (channels == 2) samples /= 2;        // 4 bytes per sample (16 bit stereo)

            // Allocate memory (right will be null if only mono sound)
            left = new double[samples];
           if (channels == 2) right = new double[samples]; 
                else right = null; 
           
            // Write to double array/s:
            int i = 0;
            while (pos < wav.Length && i < left.Length)
            {
                left[i] = bytesToDouble(wav[pos], wav[pos + 1]);
                pos += 2;
                if (channels == 2)
                {
                    right[i] = bytesToDouble(wav[pos], wav[pos + 1]);
                    pos += 2;
                }
                i++;
            }
            return new SoundBuffer(left, right);
        }


        /// <summary>
        /// Saves data as a wav file at the given sample rate.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="sampleData"></param>
        /// <param name="samplesPerSecond"></param>
        public static void Save(string fileName, SoundBuffer sampleData)
        {
            System.IO.FileStream stream = System.IO.File.Create(fileName);
            System.IO.BinaryWriter writer = new System.IO.BinaryWriter(stream);
            int RIFF = 0x46464952;
            int WAVE = 0x45564157;
            int formatChunkSize = 16;
            int headerSize = 8;
            int format = 0x20746D66;
            short formatType = 1;
            short tracks = 2;
            short bitsPerSample = 16;
            short frameSize = (short)(tracks * ((bitsPerSample + 7) / 8));
            int bytesPerSecond = SoundUtil.SAMPLE_RATE * frameSize;
            int waveSize = 4;
            int data = 0x61746164;
            int samples = (int)sampleData.Length;
            int dataChunkSize = samples * frameSize;
            int fileSize = waveSize + headerSize + formatChunkSize + headerSize + dataChunkSize;
            writer.Write(RIFF);
            writer.Write(fileSize);
            writer.Write(WAVE);
            writer.Write(format);
            writer.Write(formatChunkSize);
            writer.Write(formatType);
            writer.Write(tracks);
            writer.Write(SoundUtil.SAMPLE_RATE);
            writer.Write(bytesPerSecond);
            writer.Write(frameSize);
            writer.Write(bitsPerSample);
            writer.Write(data);
            writer.Write(dataChunkSize);

            
            short sl, sr;
   
            double[] left = sampleData.GetLeft();
            double[] right = sampleData.GetRight();
            bool isMono = sampleData.Mono;
            for (int i = 0; i < sampleData.Length; i++)
            {
                sl = (short)(30000*left[i]);
                if (isMono)
                {
                    sr = sl;
                }
                else
                {
                    sr = (short)(30000 * right[i]);
                }
                stream.WriteByte((byte)(sl & 0xff));
                stream.WriteByte((byte)(sl >> 8));
                stream.WriteByte((byte)(sr & 0xff));
                stream.WriteByte((byte)(sr >> 8));
            }
            writer.Close();
            stream.Close();
            stream.Dispose();
            writer.Dispose();
        }

        public static short toShort(double sample)
        {
            double sample_l = sample * 1000.0;
            //if (sample_l < -32767.0f) { sample_l = -32767.0f; }
            //if (sample_l > 32767.0f) { sample_l = 32767.0f; }
            return (short)sample_l;
        }



    }



}



