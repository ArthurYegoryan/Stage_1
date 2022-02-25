using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks.Tasks
{
    internal class Lesson_5_Tasks_261_270
    {
        static void Main()
        {
            Console.Write("Enter n = ");
            string nStr = Console.ReadLine();
            int n = Convert.ToInt32(nStr);

            string[] XStr = new string[n];

            Console.WriteLine("Enter X array numbers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"X array number {i + 1} = ");
                XStr[i] = Console.ReadLine();
            }
            Console.WriteLine();

            int[] X = Array.ConvertAll(XStr, int.Parse);

            string[] YStr = new string[n];

            Console.WriteLine("Enter Y array numbers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Y array number {i + 1} = ");
                YStr[i] = Console.ReadLine();
            }
            Console.WriteLine();

            int[] Y = Array.ConvertAll(YStr, int.Parse);


            // Task_261

            int sumX = 0;
            int sumY = 0;

            for (int i = 0; i < n; i++)
            {
                sumX += X[i];
                sumY += Y[i];
            }

            double arithAverageX = (double)sumX / n;
            double arithAverageY = (double)sumY / n;

            Console.WriteLine($"Multiplication of two arrays arithmetic averages = {arithAverageX * arithAverageY}");


            // Task_262

            double sumSquareX = 0;
            double sumSquareY = 0;

            for (int i = 0; i < n; i++)
            {
                sumSquareX += Math.Pow(X[i], 2);
                sumSquareY += Math.Pow(Y[i], 2);
            }

            double averageSumSquareX = Math.Sqrt(sumSquareX / n);
            double averageSumSquareY = Math.Sqrt(sumSquareY / n);

            Console.WriteLine($"Sum of average squares of two arrays = {averageSumSquareX + averageSumSquareY}");


            // Task_263

            int countPosNumbers = 0;

            for (int i = 0; i < n; i++)
            {
                if (X[i] > 0)
                {
                    countPosNumbers++;
                }                
            }
            for (int i = 0; i < n; i++)
            {
                if (Y[i] > 0)
                {
                    countPosNumbers++;
                }
            }

            Console.WriteLine($"Count of positive numbers of two arrays = {countPosNumbers}");


            // Task_264

            int countNegNumbers = 0;

            for (int i = 0; i < n; i++)
            {
                if (X[i] < 0)
                {
                    countNegNumbers++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (Y[i] < 0)
                {
                    countNegNumbers++;
                }
            }

            Console.WriteLine($"Count of negative numbers of two arrays = {countNegNumbers}");


            // Task_265

            int multY = 1;

            for (int i = 0; i < n; i++)
            {
                multY *= Y[i];
            }

            double divSumX_MultY = (double)sumX / multY;

            Console.WriteLine($"Division of sum(x) and multiplication(Y) = {divSumX_MultY}");


            // Task_266

            int sumOddX = 0;
            int sumEvenY = 0;

            for (int i = 0; i < n; i++)
            {
                if (X[i] % 2 == 1)
                {
                    sumOddX += X[i];
                }                
            }
            for (int i = 0; i < n; i++)
            {
                if (Y[i] % 2 == 0)
                {
                    sumEvenY += Y[i];
                }
            }

            int sub_SumOddX_sumEvenY = sumOddX - sumEvenY;

            Console.WriteLine($"Subtraction of sum(odd x) and sum(even y) = {sub_SumOddX_sumEvenY}");


            // Task_267

            int sumMult7 = 0;

            for (int i = 0; i < n; i++)
            {
                if (X[i] == 0)
                {
                    continue;
                }
                else if (X[i] % 7 == 0)
                {
                    sumMult7 += X[i];
                }                
            }
            for (int i = 0; i < n; i++)
            {
                if (Y[i] == 0)
                {
                    continue;
                }
                else if (Y[i] % 7 == 0)
                {
                    sumMult7 += Y[i];
                }
            }

            Console.WriteLine($"Sum of multiple 7 of two arrays = {sumMult7}");


            // Task_268

            Console.Write("Enter k = ");
            string kStr = Console.ReadLine();
            int k = Convert.ToInt32(kStr);

            int countMultK = 0;

            for (int i = 0; i < n; i++)
            {
                if (X[i] == 0)
                {
                    continue;
                }
                else if (X[i] % k == 0)
                {
                    countMultK++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (Y[i] == 0)
                {
                    continue;
                }
                else if (Y[i] % k == 0)
                {
                    countMultK++;
                }
            }

            Console.WriteLine($"Count of multiple k of two arrays = {countMultK}");


            // Task_269

            int sumEvenIndexX_OddIndexY = 0;

            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    sumEvenIndexX_OddIndexY += X[i];
                }
            }
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 1)
                {
                    sumEvenIndexX_OddIndexY += Y[i];
                }
            }

            Console.WriteLine($"Sum = {sumEvenIndexX_OddIndexY}");


            // Task_270

            double sumSquare = 0;

            for (int i = 0; i < n; i++)
            {
                sumSquare += Math.Pow(X[i], 2);
                sumSquare += Math.Pow(Y[i], 2);
            }

            Console.WriteLine($"Sum of square of 2 arrays = {sumSquare}");

            Console.ReadKey();
        }
    }
}
