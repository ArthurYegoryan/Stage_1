using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks
{
    internal class Lesson_4_Tasks_151_166
    {
        static void Main()
        {
            // Task_151

            Console.Write("Enter n = ");
            string nStr = Console.ReadLine();
            int n = Convert.ToInt32(nStr);

            int sum = 0;
            
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Sum = {sum}");


            // Task_152

            int mult = 1;

            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    mult *= i;
                }
            }

            Console.WriteLine($"Mult = {mult}");


            // Task_153

            int sum1 = 0;

            for (int i = 2; i <= n; i++)
            {
                if (n % i == 2)
                {
                    sum1 += i;
                }
            }

            Console.WriteLine($"Sum_1 = {sum1}");


            // Task_154

            int mult1 = 1;

            for (int i = 2; i <= n; i++)
            {
                if (n % i == 3)
                {
                    mult1 *= i;
                }
            }

            Console.WriteLine($"Mult_1 = {mult1}");


            // Task_155

            int sum2 = 0;

            for (int i = 10; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    sum2 += i;
                }
            }

            Console.WriteLine($"Sum2 = {sum2}");


            // Task_156

            long mult2 = 1;

            for (int i = 10; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    mult2 *= i;
                }
            }

            Console.WriteLine($"Mult2 = {mult2}");


            // Task_157

            int sum3 = 0;

            for (int i = 100; i < 1000; i++)
            {
                if (i % 5 != 0)
                {
                    sum3 += i;
                }
            }

            Console.WriteLine($"Sum3 = {sum3}");


            // Task_158

            long mult3 = 1;

            for (int i = 100; i < 1000; i++)
            {
                if (i % 2 != 0 && i % 3 != 0)
                {
                    mult3 *= i;
                }
            }

            Console.WriteLine($"Mult3 = {mult3}");


            // Task_159

            double mult4 = 1d;

            for (int i = 100; i < 1000; i++)
            {
                if (i % 3 == 1 && i % 4 == 2)
                {
                    mult4 *= i;
                }
            }

            Console.WriteLine($"Mult4 = {mult4}");


            // Task_160

            for (double i = 100; i < 1000; i++)
            {
                for (double j = Math.Sqrt(100 * 16); j < Math.Sqrt(1000*16); j++)
                {
                    if (Math.Sqrt(i * 16) == j)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
                break;
            }

            Console.ReadKey();
        }
    }
}
