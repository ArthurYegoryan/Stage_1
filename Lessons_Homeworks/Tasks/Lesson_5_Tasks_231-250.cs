using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks.Tasks
{
    internal class Lesson_5_Tasks_231_250
    {
        /*static void Main()
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

            int[] numbers = Array.ConvertAll(numbersStr, int.Parse);


            // Task_231

            double sumEvenSquare = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEvenSquare += Math.Pow(numbers[i], 2);
                }
            }

            Console.WriteLine($"Sum of square of even numbers = {sumEvenSquare}");


            // Task_232

            int countEvenSquare = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    countEvenSquare++;
                }
            }

            Console.WriteLine($"Count of even numbers = {countEvenSquare}");


            // Task_233

            int sumEven = 0;
            int multEven = 1;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEven += numbers[i];
                    multEven *= numbers[i];
                }
            }

            Console.WriteLine($"Sum and multiplication of even numbers = {sumEven} and {multEven}");


            // Task_234

            int sumOdd = 0;
            int countOdd = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    sumOdd += numbers[i];
                    countOdd++;
                }
            }

            Console.WriteLine($"Arithmetic average of odd numbers = {(double)sumOdd / countOdd}");


            // Task_235

            double sumOddSquare = 0;
            int countOddSquare = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    sumOddSquare += Math.Pow(numbers[i], 2);
                    countOddSquare++;
                }
            }

            Console.WriteLine($"Average of squares of odd numbers = {Math.Sqrt(sumOddSquare / countOddSquare)}");


            // Task_236

            int countOdd1 = 0;
            int multOdd = 1;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    multOdd *= numbers[i];
                    countOdd1++;
                }
            }

            Console.WriteLine($"Count of odd numbers = {countOdd1} and multiplication = {multOdd}");


            // Task_237

            int count0 = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] == 0)
                {
                    count0++;
                }
            }

            Console.WriteLine($"Count of 0 numbers = {count0}");


            // Task_238

            int sumMult3 = 0;
            int countMult3 = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] == 0)
                {
                    continue;
                }
                else if (numbers[i] % 3 == 0)
                {
                    sumMult3 += numbers[i];
                    countMult3++;
                }
            }

            Console.WriteLine($"Arithmetic average of multiple of 3 = {(double)sumMult3 / countMult3}");


            // Task_239

            double sumSquare5 = 0;
            int countNumber5 = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 5 == 0)
                {
                    sumSquare5 += Math.Pow(numbers[i], 2);
                    countNumber5++;
                }
            }

            Console.WriteLine($"Average of squares of multiple 5 = {Math.Sqrt(sumSquare5 / countNumber5)}");


            // Task_240

            int countNumber7 = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] == 0)
                {
                    continue;
                }
                else if (numbers[i] % 7 == 0)
                {
                    countNumber7++;
                }
            }

            Console.WriteLine($"Count of numbers of multiple 7 = {countNumber7}");


            // Task_241

            Console.Write("Enter k = ");
            string kStr = Console.ReadLine();
            int k = Convert.ToInt32(kStr);

            int sumMultipleK = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % k == 0)
                {
                    sumMultipleK += numbers[i];
                }
            }

            Console.WriteLine($"Sum of numbers of multiple k = {sumMultipleK}");


            // Task_242

            Console.Write("Enter m = ");
            string mStr = Console.ReadLine();
            int m = Convert.ToInt32(mStr);

            int multMultipleM = 1;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % m == 0)
                {
                    multMultipleM *= numbers[i];
                }
            }

            Console.WriteLine($"Multiplication of numbers of multiple m = {multMultipleM}");


            // Task_243

            Console.Write("Enter t = ");
            string tStr = Console.ReadLine();
            int t = Convert.ToInt32(tStr);

            int countMultipleT = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % t == 0)
                {
                    countMultipleT++;
                }
            }

            Console.WriteLine($"Count of multiple t = {countMultipleT}");


            // Task_244

            int multMultiple5_2 = 1;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 5 == 2)
                {
                    multMultiple5_2 *= numbers[i];
                }
            }

            Console.WriteLine($"Multiplication = {multMultiple5_2}");


            // Task_245

            double sumSquare_3 = 0;

            for (int i = 0; i < n; i++)
            {
                if ((numbers[i] + i) % 3 == 0)
                {
                    sumSquare_3 += Math.Pow(numbers[i], 2);
                }
            }

            Console.WriteLine($"Sum of square = {sumSquare_3}");


            // Task_246

            int sumAverage = 0;
            int count = 0;

            for (int i = 1; i < n; i++)
            {
                if (Math.Sqrt(i) - (int)Math.Sqrt(i) == 0)
                {
                    sumAverage += numbers[i];
                    count++;
                }
            }

            Console.WriteLine($"Arithmetic average = {(double)sumAverage / count}");


            // Task_247

            double sumSquare = 0;
            int count1 = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] > i)
                {
                    sumSquare += Math.Pow(numbers[i], 2);
                    count1++;
                }
            }

            Console.WriteLine($"Average of square = {Math.Sqrt(sumSquare / count1)}");


            // Task_248

            Console.Write("Enter k1 = ");
            string k1Str = Console.ReadLine();
            int k1 = Convert.ToInt32(k1Str);

            int sum = 0;
            
            for (int i = 0; i < n; i++)
            {
                if (Math.Pow((numbers[i] + i), 2) % k1 == 0)
                {
                    sum += numbers[i];
                }
            }

            Console.WriteLine($"Sum = {sum}");


            // Task_249

            int count2 = 0;

            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(numbers[i] - i) > k1)
                {
                    count2++;
                }
            }

            Console.WriteLine($"Count = {count2}");


            // Task_250

            double multSquare = 1;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] * i % 3 == 2)
                {
                    multSquare *= Math.Pow(numbers[i], 2);
                }
            }

            Console.WriteLine($"Multiplication of squares = {multSquare}");

            Console.ReadKey();
        }*/
    }
}
