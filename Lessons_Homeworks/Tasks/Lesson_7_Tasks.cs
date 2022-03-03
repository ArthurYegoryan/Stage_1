using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks.Tasks
{    
    internal class Lesson_7_Tasks
    {
        public static int FibNum(int fibNum)          // Task_Alice
        {
            if (fibNum == 1) 
                return 0;
            else if (fibNum == 2)
                return 1;

            return FibNum(fibNum - 1) + FibNum(fibNum - 2);
        }

        public static string Reverse(string text)            // Task_Arthur
        {
            if (text.Length <= 1)
            {
                return text;
            }
            
            char firstLetter = text[0];
            string reverse = text.Substring(1);

            return Reverse(reverse) + firstLetter;
        }

        public static void MultTable(int number, int i)           // Task_David
        {
            if (i > 10)
                return;            

            Console.WriteLine($"{number} * {i} = " + (number * i));

            MultTable(number, i + 1);
        }

        public static int CountPrimeNumbers(int num, int count)        // Task_Syuzi   ???
        {
            if (num - 1 < 2)
                return 0;

            /*for (int i = 2; i <= Math.Sqrt(num-1); i++)
            {
                if ((num - 1) % i != 0)
                {
                    count++;
                }
            }*/

            CountPrimeNumbers(num - 1, count);

            return count;
        }
        /*static void Main()
        {
            // Task_Alice

            Console.Write("Enter Fibonacci number of element: ");
            int fibNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Fibonacci {fibNum}-th element is {FibNum(fibNum)}");


            // Task_Arthur

            Console.WriteLine("Enter a string: ");
            string text1 = Console.ReadLine();

            Console.WriteLine($"Reverse string is {Reverse(text1)}");


            // Task_David

            Console.Write("Enter a number: ");
            string numberStr = Console.ReadLine();
            int number = Convert.ToInt32(numberStr);

            int i = 1;
            MultTable(number, i);


            // Task_Syuzi

            Console.Write("Enter a number: ");
            string numStr = Console.ReadLine();
            int num = Convert.ToInt32(numStr);

            int count = 0;

            Console.WriteLine($"Count of prime numbers 0 to {num} = {CountPrimeNumbers(num, count)}");

            // Task_Hovo

            Console.Write("Enter error code: ");
            string text = Console.ReadLine();

            Errors errors = new Errors();

            if (text == "CS1002")
                errors = Errors.CS1002;
            else if (text == "CS1003")
                errors = Errors.CS1003;
            else if (text == "CS1513")
                errors = Errors.CS1513;
            else if (text == "CS1514")
                errors = Errors.CS1514;
            else if (text == "CS1525")
                errors = Errors.CS1525;
            else if (text == "CS0017")
                errors = Errors.CS0017;
            else if (text == "CS0030")
                errors = Errors.CS0030;
            else if (text == "CS0103")
                errors = Errors.CS0103;
            else if (text == "CS0246")
                errors = Errors.CS0246;
            else if (text == "CS8641")
                errors = Errors.CS8641;
            else
            {
                Console.WriteLine("Invalid error code!");
                return;
            }

            PrintMessage(errors);
        }*/

        /*public static void PrintMessage(Errors errors)                     // Task_Hovo
        {
            switch (errors)
            {
                case Errors.CS1002:
                    Console.WriteLine("; expected");
                    Console.WriteLine((int)Errors.CS1002);
                    return;
                case Errors.CS1003:
                    Console.WriteLine("Syntax error, '(' expected");
                    Console.WriteLine((int)Errors.CS1003);
                    return;
                case Errors.CS1513:
                    Console.WriteLine("} expected");
                    Console.WriteLine((int)Errors.CS1513);
                    return;
                case Errors.CS1514:
                    Console.WriteLine("{ expected");
                    Console.WriteLine((int)Errors.CS1514);
                    return;
                case Errors.CS1525:
                    Console.WriteLine("Invalid expression term '}'");
                    Console.WriteLine((int)Errors.CS1525);
                    return;
                case Errors.CS0017:
                    Console.WriteLine("Program has more than one entry point defined");
                    Console.WriteLine((int)Errors.CS0017);
                    return;
                case Errors.CS0030:
                    Console.WriteLine("Cannot convert type 'string' to 'int'");
                    Console.WriteLine((int)Errors.CS0030);
                    return;
                case Errors.CS0103:
                    Console.WriteLine("The name 'name' does not exist in the current context");
                    Console.WriteLine((int)Errors.CS0103);
                    return;
                case Errors.CS0246:
                    Console.WriteLine("The type or namespace name 'name' could not be found");
                    Console.WriteLine((int)Errors.CS0246);
                    return;
                case Errors.CS8641:
                    Console.WriteLine("'else' cannot start a statement");
                    Console.WriteLine((int)Errors.CS8641);
                    return;
                default:
                    Console.WriteLine("Invalid error!");
                    return;
            }
        }*/

        /*public enum Errors
        {
            CS1002,
            CS1003,
            CS1513,
            CS1514,
            CS1525,
            CS0017,
            CS0030,
            CS0103,
            CS0246,
            CS8641,
        }*/
    }
}
