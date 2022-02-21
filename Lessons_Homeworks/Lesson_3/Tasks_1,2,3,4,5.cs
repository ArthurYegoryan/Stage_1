using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks.Lesson_3
{
    internal class Lesson_3_3
    {
        static void Main()
        {
            // Task_1
            int number = 4321;

            int a = number / 1000 * 1000;
            int b = number % 1000 / 100 * 100;
            int c = number % 100 / 10 * 10;
            int d = number % 10;

            Console.WriteLine($"4321 = {a} + {b} + {c} + {d}");


            // Task_2
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Where are you from? ");
            string place = Console.ReadLine();

            Console.WriteLine($"You are {firstName} {lastName}, you are from {place}.");


            // Task_3
            Console.Write("Enter the week day: ");
            string day = Console.ReadLine();

            if (day == "Monday")
            {
                Console.WriteLine(1);
            }
            else if (day == "Tuesday")
            {
                Console.WriteLine(2);
            }
            else if (day == "Wednesday")
            {
                Console.WriteLine(3);
            }
            else if (day == "Thursday")
            {
                Console.WriteLine(4);
            }
            else if (day == "Friday")
            {
                Console.WriteLine(5);
            }
            else if (day == "Saturday")
            {
                Console.WriteLine(6);
            }
            else if (day == "Sunday")
            {
                Console.WriteLine(7);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }


            // Task_4
            Console.Write("Enter the 1-st int number: ");
            string text1 = Console.ReadLine();
            double number1 = Convert.ToDouble(text1);

            Console.Write("Enter the 2-nd byte number: ");
            string text2 = Console.ReadLine();
            double number2 = Convert.ToDouble(text2);

            Console.Write("Enter the 3-rd short number: ");
            string text3 = Console.ReadLine();
            double number3 = Convert.ToDouble(text3);

            Console.Write("Enter the 4-th int number: ");
            string text4 = Console.ReadLine();
            double number4 = Convert.ToDouble(text4);

            double firstNumber = Math.MaxMagnitude(Math.MaxMagnitude(number1, number2), Math.MaxMagnitude(number3, number4));
            double fourthNumber = Math.MinMagnitude(Math.MinMagnitude(number1, number2), Math.MinMagnitude(number3, number4));

            double secondNumber = 0;
            double thirdNumber = 0;

            if ((firstNumber == number1 && fourthNumber == number2) || (firstNumber == number2 && fourthNumber == number1))
            {
                secondNumber = Math.MaxMagnitude(number3, number4);
                thirdNumber = Math.MinMagnitude(number3, number4);
            }
            else if ((firstNumber == number1 && fourthNumber == number3) || (firstNumber == number3 && fourthNumber == number1))
            {
                secondNumber = Math.MaxMagnitude(number2, number4);
                thirdNumber = Math.MinMagnitude(number2, number4);
            }
            else if ((firstNumber == number1 && fourthNumber == number4) || (firstNumber == number4 && fourthNumber == number1))
            {
                secondNumber = Math.MaxMagnitude(number2, number3);
                thirdNumber = Math.MinMagnitude(number2, number3);
            }

            if ((firstNumber == number2 && fourthNumber == number3) || (firstNumber == number3 && fourthNumber == number2))
            {
                secondNumber = Math.MaxMagnitude(number1, number4);
                thirdNumber = Math.MinMagnitude(number1, number4);
            }
            else if ((firstNumber == number2 && fourthNumber == number4) || (firstNumber == number4 && fourthNumber == number2))
            {
                secondNumber = Math.MaxMagnitude(number1, number3);
                thirdNumber = Math.MinMagnitude(number1, number3);
            }

            if ((firstNumber == number3 && fourthNumber == number4) || (firstNumber == number4 && fourthNumber == number3))
            {
                secondNumber = Math.MaxMagnitude(number1, number2);
                thirdNumber = Math.MinMagnitude(number1, number2);
            }

            Console.WriteLine($"{firstNumber}, {secondNumber}, {thirdNumber}, {fourthNumber}");


            // Task_5_Alice
            Console.Write("Enter random number: ");
            string numStr = Console.ReadLine();
            int num = Convert.ToInt32(numStr);

            int roundNum;

            if (num % 100 <= 50)
            {
                roundNum = num / 100 * 100;
            }
            else
            {
                roundNum = (num / 100 + 1) * 100;
            }

            Console.WriteLine("Round number = " + roundNum);

            Console.ReadKey();
        }
    }
}
