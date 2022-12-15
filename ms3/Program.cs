using System;
using System.Linq;

namespace ms3
{
    class Program
    {
        static void Main(string[] args)
        {
            double f12 = 100, f122 = 0, f211 = 0, f21 = 100, min = 99, min2 = 99, maxmin = -1000, maxmin2 = -1000;
            int a = 1000, c = 3;
            double[,] array = new double[a, c];
            double[,] array2 = new double[a, c];
            double[] array3 = new double[a];
            int b = 0;
            for (double x1 = -1; x1 <= 1; x1 = x1 + 0.1)
            {
                for (double x2 = -2; x2 <= 2; x2 = x2 + 0.1)
                {
                    f12 = 8 * Math.Pow(x1, 2) + 16 * x1 + 6 * Math.Pow(x2, 2) - 12 * x2 + 50;
                    min = Math.Min(f12, min);
                }
                maxmin = Math.Max(min, maxmin);
                min = 99;
            }

            b = 0;
            for (double x1 = -2; x1 <= 2; x1 = x1 + 0.1)
            {
                for (double x2 = -1; x2 <= 1; x2 = x2 + 0.1)
                {
                    f21 = -8 * Math.Pow(x1, 2) + 24 * x1 + 11 * Math.Pow(x2, 2) - 17 * x2 + 4;
                    min2 = Math.Min(f21, min2);
                }
                maxmin2 = Math.Max(min2, maxmin2);
                min2 = 99;
            }
            Console.WriteLine($"{maxmin} --- maxmin \n{maxmin2} --- maxmin2");

            b = 0;
            for (double x1 = -1; x1 <= 1; x1 = x1 + 0.1)
            {
                for (double x2 = -2; x2 <= 2; x2 = x2 + 0.1)
                {
                    f12 = 8 * Math.Pow(x1, 2) + 16 * x1 + 6 * Math.Pow(x2, 2) - 12 * x2 + 50;
                    f122 = f12 - maxmin;
                    if (f122 > 0)
                    {
                        array[b, 0] = x1;
                        array[b, 1] = x2;
                        array[b, 2] = f122;

                        
                        b++;
                    }
                }
            }

            b = 0;
            for (double x1 = -2; x1 <= 2; x1 = x1 + 0.1)
            {
                for (double x2 = -1; x2 <= 1; x2 = x2 + 0.1)
                {
                    f21 = -8 * Math.Pow(x1, 2) + 24 * x1 + 11 * Math.Pow(x2, 2) - 17 * x2 + 4;
                    f211 = f21 - maxmin2;
                    if (f211 > 0)
                    {
                        array2[b, 0] = x2;
                        array2[b, 1] = x1;
                        array2[b, 2] = f211;

                        b++;
                    }
                }
            }

          
        }
    }
}