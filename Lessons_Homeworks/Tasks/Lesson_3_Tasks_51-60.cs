using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks_Tasks_1
{
    internal class Tasks_1
    {
        /*static void Main()
        {
            Console.Write("Enter 3-digits number: ");
            string text = Console.ReadLine();
            int abc = Convert.ToInt32(text);

            if (abc / 100 >= 10 || abc / 100 == 0)
            {
                Console.WriteLine("Invalid statement!");
                return;
            }


            // Task_51

            int a = abc / 100;
            int b = abc % 100 / 10;
            int c = abc % 10;

            bool t = false;

            if (c == a + b)
            {
                t = true;
            }

            Console.WriteLine(t);


            // Task_52

            bool t1 = false;

            if (a == b || a == c || b == c)
            {
                t1 = true;
            }

            Console.WriteLine(t1);


            // Task_53

            Console.Write("Enter k = ");
            string text1 = Console.ReadLine();
            int k = Convert.ToInt32(text1);

            double result;

            if (abc > k)
            {
                result = (double)abc / (a + b + c);
            }
            else
            {
                result = (double)(a + b + c) / abc;
            }

            Console.WriteLine(result);


            // Task_54

            int max = a;
            if (b > a && b > c)
            {
                max = b;
            }
            else if (c > a && c > b)
            {
                max = c;
            }

            Console.WriteLine(max);


            // Task_55

            int min = a;
            if (b < a && b < c)
            {
                min = b;
            }
            else if (c < a && c < b)
            {
                min = c;
            }

            Console.WriteLine(min);


            // Task_56

            double result1;

            if (c > b)
            {
                result1 = (double)(a + b + c) / abc;
                Console.WriteLine(result1);
            }
            else
            {
                Console.WriteLine(abc);
            }


            // Task_57

            double a1 = Convert.ToDouble(a);
            double b1 = Convert.ToDouble(b);
            double c1 = Convert.ToDouble(c);

            if (c1 == 0)
            {
                Console.WriteLine("Invalid statement!");
                return;
            }

            if (abc > 300)
            {
                Console.WriteLine(b1 / c1);
            }
            else
            {
                Console.WriteLine(a1 / c1);
            }


            // Task_58

            char f = 'b';
            if (a + b < 5)
            {
                f = 'a';
            }

            Console.WriteLine(f);


            // Task_59

            double firstNumber = Math.MinMagnitude(Math.MinMagnitude(a1, b1), c1);
            double thirdNumber = Math.MaxMagnitude(Math.MaxMagnitude(a1, b1), c1);

            double secondNumber = a1;
            if ((firstNumber == a1 && thirdNumber == b1) || (firstNumber == b1 && thirdNumber == a1))
            {
                secondNumber = c1;
            }
            else if ((firstNumber == a1 && thirdNumber == c1) || (firstNumber == c1 && thirdNumber == a1))
            {
                secondNumber = b1;
            }

            Console.WriteLine($"{firstNumber}, {secondNumber}, {thirdNumber}");


            // Task_60

            Console.WriteLine($"{thirdNumber}, {secondNumber}, {firstNumber}");

            Console.ReadKey();
        }*/
    }
}
