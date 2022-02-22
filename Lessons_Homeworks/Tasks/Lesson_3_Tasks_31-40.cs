using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks.Tasks
{
    internal class Lesson_3_Tasks_31_40
    {
        /*static void Main()
        {
            Console.Write("Enter a = ");
            string aText = Console.ReadLine();
            byte a = Convert.ToByte(aText);

            Console.Write("Enter b = ");
            string bText = Console.ReadLine();
            byte b = Convert.ToByte(bText);

            Console.Write("Enter c = ");
            string cText = Console.ReadLine();
            byte c = Convert.ToByte(cText);

            Console.Write("Enter d = ");
            string dText = Console.ReadLine();
            byte d = Convert.ToByte(dText);

            if (a == b || a == c || a == d || b == c || b == d || c == d)
            {
                Console.WriteLine("Invalid statement!\nNumbers must be different.");
                return;
            }


            // Task_31
            
            byte maxValue = Math.Max(Math.Max(a, b), Math.Max(c, d));
            Console.WriteLine($"Max value = {maxValue}");


            // Task_32

            byte minValue = Math.Min(Math.Min(a, b), Math.Min(c, d));
            Console.WriteLine($"Min value = {minValue}");


            // Task_33

            if (a == 1 || b == 1 || c == 1 || d == 1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


            // Task_34

            if ((a + b) == (c + d) || (a + c) == (b + d) || (a + d) == (b + c))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


            // Task_35

            if (a == (b + c + d) || b == (a + c + d) || c == (a + b + d) || d == (a + b + c))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


            // Task_36

            if ((a % 2 == 1 && b % 2 == 1) || (a % 2 == 1 && c % 2 == 1) || (a % 2 == 1 && d % 2 == 1) ||
                (b % 2 == 1 && c % 2 == 1) || (b % 2 == 1 && d % 2 == 1) || (c % 2 == 1 && d % 2 == 1))
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(2);
            }


            // Task_39

            byte firstName = minValue;
            byte fourthName = maxValue;
            byte secondName = 0;
            byte thirdName = 0;

            if ((firstName == a && fourthName == b) || (firstName == b && fourthName == a))
            {
                if (c < d)
                {
                    secondName = c;
                    thirdName = d;
                }
                else
                {
                    secondName = d;
                    thirdName = c;
                }
            }
            else if ((firstName == a && fourthName == c) || (firstName == c && fourthName == a))
            {
                if (b < d)
                {
                    secondName = b;
                    thirdName = d;
                }
                else
                {
                    secondName = d;
                    thirdName = b;
                }
            }
            else if ((firstName == a && fourthName == d) || (firstName == d && fourthName == a))
            {
                if (b < c)
                {
                    secondName = b;
                    thirdName = c;
                }
                else
                {
                    secondName = c;
                    thirdName = b;
                }
            }
            else if ((firstName == b && fourthName == c) || (firstName == c && fourthName == b))
            {
                if (a < d)
                {
                    secondName = a;
                    thirdName = d;
                }
                else
                {
                    secondName = d;
                    thirdName = a;
                }
            }
            else if ((firstName == b && fourthName == d) || (firstName == d && fourthName == b))
            {
                if (a < c)
                {
                    secondName = a;
                    thirdName = c;
                }
                else
                {
                    secondName = c;
                    thirdName = a;
                }
            }
            else if ((firstName == c && fourthName == d) || (firstName == d && fourthName == c))
            {
                if (a < b)
                {
                    secondName = a;
                    thirdName = b;
                }
                else
                {
                    secondName = b;
                    thirdName = a;
                }
            }

            Console.WriteLine($"{firstName}, {secondName}, {thirdName}, {fourthName}");


            // Task_40

            Console.WriteLine($"{fourthName}, {thirdName}, {secondName}, {firstName}");


            // Task_37

            if (((secondName - firstName) == (thirdName - secondName)) && ((secondName - firstName) == (fourthName - thirdName)) ||
                ((thirdName - fourthName) == (secondName - thirdName)) && ((thirdName - fourthName) == (firstName - secondName)))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


            // Task_38

            double firstName1 = Convert.ToDouble(firstName);
            double secondName1 = Convert.ToDouble(secondName);
            double thirdName1 = Convert.ToDouble(thirdName);
            double fourthName1 = Convert.ToDouble(fourthName);

            if (((secondName1 / firstName1) == (thirdName1 / secondName1)) && ((secondName1 / firstName1) == (fourthName1 / thirdName1)) ||
                ((thirdName1 / fourthName1) == (secondName1 / thirdName1)) && ((thirdName1 / fourthName1) == (firstName1 / secondName1)))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Console.ReadKey();
        }*/
    }
}
