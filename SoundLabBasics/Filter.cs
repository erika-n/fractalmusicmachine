using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLabBasics
{
    public class Filter
    {
        // with guidance from http://www.dspguide.com/filtexam.htm

        int KERNEL_SIZE = 1000;
        
        double[] _kernel;
        double _amp = 0.1;
        public Filter()
        {
            _kernel = new double[KERNEL_SIZE];
            double cf = 0.01; // cutoff frequency  
            for (int i = 0; i < KERNEL_SIZE; i++)
            {
                if (i - KERNEL_SIZE / 2 == 0) 
                {
                    _kernel[i] = 2 * Math.PI * cf;
                }
                else
                {
                    _kernel[i] = Math.Sin(2 * Math.PI * cf * (i - KERNEL_SIZE / 2))/ (i - KERNEL_SIZE / 2);
               }
                //_kernel[i] = _kernel[i] *(0.54 - 0.46 * Math.Cos(2 * Math.PI * i / KERNEL_SIZE));

               
            }
        }

        public SoundBuffer apply(SoundBuffer input)
        {
            SoundBuffer output = new SoundBuffer(new double[input.Length - KERNEL_SIZE], new double[input.Length - KERNEL_SIZE]);
            for (int j = KERNEL_SIZE; j < input.Length; j++)
            {
                output.Write(0, j - KERNEL_SIZE);
                for (int i = 0; i < KERNEL_SIZE; i++)
                {
                    output.AddLeft(input.ReadLeft(j - i) * _kernel[i]*_amp, j - KERNEL_SIZE);
                    output.AddRight(input.ReadRight(j - i) * _kernel[i]*_amp, j - KERNEL_SIZE);
                }
            }

            return output;
        }
    }
}
