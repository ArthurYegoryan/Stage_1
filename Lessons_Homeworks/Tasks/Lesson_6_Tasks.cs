using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks.Tasks
{
    internal class Lesson_6_Tasks
    {
        public static void UserName(string username)          // Task_1
        {
            Console.WriteLine($"Welcome {username}!");
            Console.WriteLine("Have a nice day!");
        }

        public static string Name(string name)                // Task_2
        {
            return name;
        }

        public static int Sum(int number1, int number2)       // Task_3
        {
            int sum = number1 + number2;
            return sum;
        }

        public static int CountSpaces(string text)            // Task_4
        {
            int countSpaces = 0;
            foreach (char space in text)
            {
                if (space == ' ')
                {
                    countSpaces++;
                }
            }
            return countSpaces;
        }

        public static int SumElements(int size, int[] numbers)        // Task_5
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static void SwapElements(ref int number1, ref int number2)       // Task_6
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }

        public static double Pow(int baseNum, int exponent)            // Task_7
        {
            double result = Math.Pow(baseNum, exponent);
            return result;
        }

        public static void Fibonacci(int fibNum)                   // Task_8
        {
            if (fibNum <= 0)
            {
                Console.WriteLine("Invalid statement!");
                return;
            }
            else if (fibNum == 1)
            {
                Console.WriteLine("0");
                return;
            }                
            else if (fibNum == 2)
            {
                Console.WriteLine("0, 1");
                return;
            }

            int fib1 = 0, fib2 = 1, fib3 = 0;
            Console.Write($"{fib1} {fib2}");

            for (int i = 0; i < fibNum - 2; i++)
            {
                fib3 = fib1 + fib2;
                Console.Write($" {fib3}");
                fib1 = fib2;
                fib2 = fib3;
            }
        }

        public static bool IsPrime(int number)               // Task_9
        {
            for (double i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;                
            }
            return true;
        }

        public static int SumDigits(int number)            // Task_10
        {
            int number1 = number;
            
            int count = 1;
            while (number1 / 10 != 0)
            {
               number1 /= 10;
               count++;
            }

            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = number % 10;
                number = number / 10;
            }

            int sum = numbers.Sum();

            return sum;
        }

        public static int Factorial(int number)              // Task_11
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }

            for (int i = number - 1; i >= 2; i--)
            {
                number *= i;
            }
            return number;
        }

        public static int Fibonacci1(int fibNum)             // Task_12
        {
            if (fibNum == 1)
                return 0;
            else if (fibNum == 2)
                return 1;

            int fibNum1 = 0;
            int fibNum2 = 1;
            int fibNum3 = 0;

            for (int i = 0; i < fibNum - 2; i++)
            {
                fibNum3 = fibNum1 + fibNum2;
                fibNum1 = fibNum2;
                fibNum2 = fibNum3;
            }
            return fibNum3;
        }
        static void Main()
        {
            // Task_1

            /*Console.Write("Enter user name: ");
            string username = Console.ReadLine();

            UserName(username);*/


            // Task_2

            /*Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Welcome friend {Name(name)}!");
            Console.WriteLine("Have a nice day!");*/


            // Task_3

            /*Console.Write("Enter the first number: ");
            string number1Str = Console.ReadLine();
            int number1 = Convert.ToInt32(number1Str);

            Console.Write("Enter the second number: ");
            string number2Str = Console.ReadLine();
            int number2 = Convert.ToInt32(number2Str);

            Console.Write($"The sum of two numbers is: {Sum(number1, number2)}");*/


            // Task_4

            /*Console.WriteLine("Enter a text:");
            string text = Console.ReadLine();

            Console.WriteLine($"{text}. contains {CountSpaces(text)} spaces");*/


            // Task_5

            /*Console.Write("Enter array size: ");
            string sizeStr = Console.ReadLine();
            int size = Convert.ToInt32(sizeStr);

            string[] numbersStr = new string[size];
            
            Console.WriteLine("Enter array elements:");

            for (int i = 0; i < size; i++)
            {  
                Console.Write($"Number {i + 1} = {numbersStr[i]}");
                numbersStr[i] = Console.ReadLine();
            }

            int[] numbers = Array.ConvertAll(numbersStr, int.Parse);

            Console.Write($"The sum of the elements of the array is {SumElements(size, numbers)}");*/


            // Task_6

            /*Console.Write("Enter the 1-st number: ");
            string number1Str = Console.ReadLine();
            int number1 = Convert.ToInt32(number1Str);

            Console.Write("Enter the 2-nd number: ");
            string number2Str = Console.ReadLine();
            int number2 = Convert.ToInt32(number2Str);

            SwapElements(ref number1, ref number2);

            Console.WriteLine($"Now the 1-st number is: {number1} and the 2-nd number is: {number2}");*/


            // Task_7

            /*Console.Write("Enter base number: ");
            string baseNumStr = Console.ReadLine();
            int baseNum = Convert.ToInt32(baseNumStr);

            Console.Write("Enter the exponent: ");
            string exponentStr = Console.ReadLine();
            int exponent = Convert.ToInt32(exponentStr);

            Console.WriteLine($"So the number {baseNum}^{exponent} = {Pow(baseNum,exponent)}");*/


            // Task_8

            /*Console.Write("Enter number of Fibonacci series: ");
            string fibNumStr = Console.ReadLine();
            int fibNum = Convert.ToInt32(fibNumStr);

            Fibonacci(fibNum);*/


            // Task_9

            /*Console.Write("Enter a number: ");
            string numberStr = Console.ReadLine();
            int number = Convert.ToInt32(numberStr);

            //IsPrime(number);

            if (IsPrime(number) == true)
                Console.WriteLine($"{number} is a prime number");
            else
                Console.WriteLine($"{number} isn't a prime number");*/


            // Task_10

            /*Console.Write("Enter a number: ");
            string numberStr = Console.ReadLine();
            int number = Convert.ToInt32(numberStr);

            Console.WriteLine($"The sum of the digits of the number {number} is: {SumDigits(number)}");*/


            // Task_11

            /*Console.Write("Enter a number: ");
            string numberStr = Console.ReadLine();
            int number = Convert.ToInt32(numberStr);

            Console.WriteLine($"The factorial of 5 is {Factorial(number)}");*/


            // Task_12

            Console.Write("Enter a number: ");
            string fibNumStr = Console.ReadLine();
            int fibNum = Convert.ToInt32(fibNumStr);

            Console.WriteLine($"The Fibonacci of {fibNum}-th term is {Fibonacci1(fibNum)}");
        }
    }
}
