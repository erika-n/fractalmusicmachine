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
        public double soft1, soft2;
        public Color color;
        public int freqMode = 0;
        public double addFrequency;
        const int NATURAL = 1, PYTHAGOREAN = 0;
        private Random random;
        private double[,] tMatrix; 

        public Transformation()
        {
            random = new Random();
        }

        public Transformation(double start, double end, double multFrequency, Color color, double addFrequency = 0, double soft1 = 0, double soft2 = 0)
        {
            random = new Random();
            this.start = start;
            this.end = end;
            this.multFrequency = multFrequency;
            this.color = color;
            this.addFrequency = addFrequency;
            this.tMatrix = new double[,]{
                {   
                    start, end
                }, 
                {   
                    multFrequency, addFrequency
                }, 
                {

                soft1, soft2                        
                }
            } ;
            this.soft1 = soft1;
            this.soft2 = soft2;
        }





        public double[] getNewSofts(double soft1, double soft2)
        {
            return getNewVals(soft1, soft2, this.soft1, this.soft2);
        }

        public double[] getNewFreqs(double freq, double freq2)
        {

            return getNewVals(freq, freq2, this.multFrequency, this.addFrequency);
 
        }

        public double[] getNewVals(double s, double e, double s_factor, double e_factor){
            double len = e - s;
            double newStart = len * s_factor + s;
            double newEnd = len * e_factor + s;

            return new double[] { newStart, newEnd };
        }

        public double[] getNewVals(double start, double end)
        {
            return getNewVals(start, end, this.start, this.end);
        }


        public double[,] getNewVals(double[,] vals)
        {

            return MultiplyMatrix(vals, this.tMatrix);
        }





        public Transformation Clone()
        {
            return new Transformation(this.start, this.end, this.multFrequency, this.color);
        }

        private double[,] MultiplyMatrix(double[,] A, double[,] B)
        {
            int rA = A.GetLength(0);
            int cA = A.GetLength(1);
            int rB = B.GetLength(0);
            int cB = B.GetLength(1);
            double temp = 0;
            double[,] matrix = new double[rA, cB];
            if (cA != rB)
            {
                Console.WriteLine("matrix can't be multiplied !!");
                return null;
            }
            else
            {
                for (int i = 0; i < rA; i++)
                {
                    for (int j = 0; j < cB; j++)
                    {
                        temp = 0;
                        for (int k = 0; k < cA; k++)
                        {
                            temp += A[i, k] * B[k, j];
                        }
                        matrix[i, j] = temp;
                    }
                }
                return matrix;
            }
        }


    }
}
