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

            double num = 100;

            while (num < 1000)
            {
                if (Math.Sqrt(num * 16) - (int)Math.Sqrt(num * 16) == 0)
                {
                    Console.WriteLine($"Number = {num}");
                    break;
                }
                num++;
            }


            // Task_161

            double num1 = 1000;

            while (num1 < 10000)
            {
                if (Math.Sqrt(num1 * 26) - (int)Math.Sqrt(num1 * 26) == 0)
                {
                    Console.WriteLine($"Number1 = {num1}");
                    break;
                }
                num1++;
            }


            // Task_162

            double num2 = 9999;

            while (num2 >= 1000)
            {
                if (Math.Sqrt(num2 * 14) - (int)Math.Sqrt(num2 * 14) == 0)
                {
                    Console.WriteLine($"Number2 = {num2}");
                    break;
                }
                num2--;
            }


            // Task_163

            while (num2 >= 1000)
            {
                if (Math.Sqrt(num2 * 18) - (int)Math.Sqrt(num2 * 18) == 0)
                {
                    Console.WriteLine($"Number3 = {num2}");
                    break;
                }
                num2--;
            }


            // Task_164

            Console.Write("Enter n1 = ");
            string n1Str = Console.ReadLine();
            int n1 = Convert.ToInt32(n1Str);

            double num3 = 100;
            bool is_found = false;

            while (num3 < 1000)
            {
                if (Math.Sqrt(num3) - (int)Math.Sqrt(num3) == 0 && (int)Math.Sqrt(num3) > n1)
                {
                    is_found = true;
                    Console.WriteLine($"Number4 = {num3}");
                    break;
                }
                num3++;
            }

            if (is_found == false)
            {
                Console.WriteLine("Number doesn't exist!");
            }


            // Task_165

            Console.Write("Enter n2 = ");
            string n2Str = Console.ReadLine();
            double n2 = Convert.ToInt32(n2Str);

            bool t = false;

            while (n2 / 3 >= 1)
            {
                if (n2 / 3 == 1)
                {
                    t = true;
                }
                n2 /= 3;
            }

            Console.WriteLine($"t = {t}");

            // Task_166

            int y = 0;

            Console.Write("Enter n3 = ");
            string n3Str = Console.ReadLine();
            double n3 = Convert.ToInt32(n3Str);

            while (n3 / 4 >= 1)
            {
                if (n3 / 4 == 1)
                {
                    y = 1;
                }
                n3 /= 4;
            }

            Console.WriteLine($"y = {y}");

            Console.ReadKey();
        }
    }
}
