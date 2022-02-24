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

            Console.WriteLine($"Multiplication of even index numbers = {multEven}");


            // Task_217

            double multOddSquare = 1;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 1)
                {
                    multOddSquare *= Math.Pow(numbers[i], 2);
                }
            }

            Console.WriteLine($"Multiplication of odd index numbers squares = {multOddSquare}");


            // Task_218

            decimal sumOddAbs = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 1)
                {
                    sumOddAbs += Math.Abs(numbers[i]);
                }
            }

            Console.WriteLine($"Sum of absalout of odd index numbers = {sumOddAbs}");

            // Task_219

            Console.Write("Enter k = ");
            string kStr = Console.ReadLine();
            int k = Convert.ToInt32(kStr);

            int count4 = 0;

            for (int i = 1; i < n; i++)
            {
                if (i % k == 0)
                {
                    count4++;
                }
            }

            Console.WriteLine($"Count of multiple numbers of i = {count4}");


            // Task_220

            int countPos = 0;
            int countNeg = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] > 0)
                {
                    countPos++;
                }
                else if (numbers[i] < 0)
                {
                    countNeg++;
                }
            }

            Console.WriteLine($"Count of positive numbers = {countPos}");
            Console.WriteLine($"Count of negative numbers = {countNeg}");


            // Task_221

            Console.Write("Enter a = ");
            string aStr = Console.ReadLine();
            int a = Convert.ToInt32(aStr);

            Console.Write("Enter b = ");
            string bStr = Console.ReadLine();
            int b = Convert.ToInt32(bStr);

            int sum1 = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] >= a && numbers[i] <= b)
                {
                    sum1 += numbers[i];
                }
            }

            Console.WriteLine($"Sum of [a;b] numbers = {sum1}");


            // Task_222

            Console.Write("Enter c = ");
            string cStr = Console.ReadLine();
            int c = Convert.ToInt32(cStr);

            Console.Write("Enter d = ");
            string dStr = Console.ReadLine();
            int d = Convert.ToInt32(dStr);

            int mult = 1;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] >= c && numbers[i] < d)
                {
                    mult *= numbers[i];
                }
            }

            Console.WriteLine($"Multiplication of [c;d) numbers = {mult}");


            // Task_223

            int count5 = 0;
            
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] > a && numbers[i] < b)
                {
                    count5++;
                }
            }

            Console.WriteLine($"Count of (a;b) numbers = {count5}");


            // task_224

            Console.Write("Enter k1 = ");
            string k1Str = Console.ReadLine();
            int k1 = Convert.ToInt32(k1Str);
            
            double sumCubes = 0;

            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(numbers[i]) < k1)
                {
                    sumCubes += Math.Pow(numbers[i], 3);
                }
            }

            Console.WriteLine($"Sum of number cubes, that abs(number) < k1 = {sumCubes}");


            // Task_225

            Console.Write("Enter t = ");
            string tStr = Console.ReadLine();
            int t = Convert.ToInt32(tStr);

            int mult1 = 1;
            
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(numbers[i]) < t)
                {
                    mult1 *= numbers[i];
                }
            }

            Console.WriteLine($"Multiplication of abs(numbers) < t = {mult1}");


            // Task_226

            int count6 = 0;
            
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(numbers[i]) < k1)
                {
                    count6++;
                }
            }

            Console.WriteLine($"Count of numbers, that abs(number) < k1 = {count6}");


            // Task_227

            int sumAverage1 = 0;
            int count7 = 0;

            for (int i = 1; i < n; i++)
            {
                if (i % k1 == 0)
                {
                    sumAverage1 += numbers[i];
                    count7++;
                }
            }

            Console.WriteLine($"Arithmetic average1 = {(double)sumAverage1 / count7}");


            // Task_228

            int sum2 = 0;

            for (int i = 1; i < n; i++)
            {
                if (i % k == 0)
                {
                    sum2 += numbers[i];
                }
            }

            Console.WriteLine($"Sum2 = {sum2}");


            // Task_229

            int mult2 = 1;

            for (int i = 0; i < n; i++)
            {
                if ((numbers[i] - i) > 0)
                {
                    mult2 *= numbers[i];
                }
            }

            Console.WriteLine($"Mult2 = {mult2}");


            // Task_230

            // Պահանջը չեմ հասկանում

            Console.ReadKey();
        }
    }
}
