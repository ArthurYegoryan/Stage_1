using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks.Tasks
{
    internal class Lesson_5_Tasks_211_230
    {
        static void Main()
        {
            Console.Write("Enter n = ");
            string nStr = Console.ReadLine();
            int n = Convert.ToInt32(nStr);
                        
            string[] numbersStr = new string[n];

            Console.WriteLine("Enter array numbers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Number {i + 1} = ");
                numbersStr[i] = Console.ReadLine();
            }
            Console.WriteLine();

            int[] numbers = Array.ConvertAll(numbersStr, int.Parse);              // Կամ int.Parse-ի փոխարեն Convert.ToInt32

            
            // Task_211

            int sum = 0;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] > 0)
                {
                    sum += numbers[i];
                    count++;
                }
            }

            float arithAverage = (float)sum / count;

            Console.WriteLine($"Arithmetic average = {arithAverage}");


            // Task_212

            double sumSquare = 0;
            int count1 = 0;
            
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] > 0)
                {
                    sumSquare += Math.Pow(numbers[i], 2);
                    count1++;
                }
            }

            double midSquare = Math.Sqrt(sumSquare/count1);

            Console.WriteLine($"Middle square = {midSquare}");


            // Task_213

            double sumSquareMin = 0;
            int count2 = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] < 0)
                {
                    sumSquareMin += Math.Pow(numbers[i], 2);
                    count2++;
                }
            }

            double midSquareMin = Math.Sqrt(sumSquareMin / count2);

            Console.WriteLine($"Middle square of negative numbers = {midSquareMin}");


            // Task_214

            int sumMin = 0;
            int count3 = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] < 0)
                {
                    sumMin += numbers[i];
                    count3++;
                }
            }

            float arithAverageMin = (float)sumMin / count3;

            Console.WriteLine($"Arithmetic average of negative numbers = {arithAverageMin}");


            // Task_215

            int sumEven = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven += numbers[i];
                }
            }

            Console.WriteLine($"Sum of even numbers = {sumEven}");


            // Task_216

            int multEven = 1;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    multEven *= numbers[i];
                }
            }

            Console.WriteLine($"Multiplication of even numbers = {multEven}");

            Console.ReadKey();
        }
    }
}
