using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks_Tasks
{
    internal class Tasks
    {
        static void Main()
        {
            Console.Write("Enter a = ");
            string text1 = Console.ReadLine();
            int a = Convert.ToInt32(text1);

            Console.Write("Enter b = ");
            string text2 = Console.ReadLine();
            int b = Convert.ToInt32(text2);

            Console.Write("Enter c = ");
            string text3 = Console.ReadLine();
            int c = Convert.ToInt32(text3);

            if (a == b || b == c || a == c)
            {
                Console.WriteLine("Numbers must be different!");
                return;
            }


            // Task_21

            int max = a;

            if (b > a && b > c)
            {
                max = b;
            }
            else if (c > a && c > b)
            {
                max = c;
            }

            Console.WriteLine($"Max value = {max}");


            // Task_22

            int min = a;

            if (b < a && b < c)
            {
                min = b;
            }
            else if (c < a && c < b)
            {
                min = c;
            }

            Console.WriteLine($"Min value = {min}");


            // Task_23

            if (a == 1 || b == 1 || c == 1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


            // Task_24         // Խնդրի պահանջով պետք է թվերը տարբեր լինեն

            if ((a == 2 && b == 2 && c != 2) || (a == 2 && b != 2 && c == 2) || (a != 2 && b == 2 && c == 2))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


            // Task_25

            if ((a + b) > c && (a + c) > b && (b + c) > a)
            {
                Console.WriteLine("y = 1");
            }
            else
            {
                Console.WriteLine("y = 2");
            }


            // Task_26

            if (a % 2 == 0 || b % 2 == 0 || c % 2 == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(2);
            }


            // Task_27

            if ((c - b == b - a) || (c - a == a - b) || (b - a == a - c) ||
                (b - c == c - a) || (a - b == b - c) || (a - c == c - b))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


            // Task_28

            double a1 = Convert.ToDouble(a);
            double b1 = Convert.ToDouble(b);
            double c1 = Convert.ToDouble(c);

            if (a1 == 0 || b1 == 0 || c1 == 0)
            {
                Console.WriteLine("Invalid statement!");
                return;
            }

            if ((c1 / b1 == b1 / a1) || (c1 / a1 == a1 / b1) || (b1 / a1 == a1 / c1) ||
                (b1 / c1 == c1 / a1) || (a1 / b1 == b1 / c1) || (a1 / c1 == c1 / b1))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


            // Task_29

            double firstNumber = Math.MinMagnitude(Math.Min(a1, b1), c1);
            double thirdNumber = Math.MaxMagnitude(Math.Max(a1, b1), c1);

            double secondNumber = a1;

            if ((firstNumber == a1 && thirdNumber == c1) || (firstNumber == c1 && thirdNumber == a1))
            {
                secondNumber = b1;
            }
            else if ((firstNumber == a1 && thirdNumber == b1) || (firstNumber == b1 && thirdNumber == a1))
            {
                secondNumber = c1;
            }

            Console.WriteLine($"{firstNumber}, {secondNumber}, {thirdNumber}");


            // Taks_30

            Console.WriteLine($"{thirdNumber}, {secondNumber}, {firstNumber}");

            Console.ReadKey();
        }
    }
}
