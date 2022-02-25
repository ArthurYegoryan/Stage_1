using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks.Tasks
{
    internal class Lesson_5_Tasks_271_280
    {
        static void Main()
        {
            Console.Write("Enter n = ");
            string nStr = Console.ReadLine();
            int n = Convert.ToInt32(nStr);

            string[] charsStr = new string[n];

            Console.WriteLine("Enter chars array symbols:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Char array symbol {i + 1} = ");
                charsStr[i] = Console.ReadLine();
            }
            Console.WriteLine();

            char[] chars = Array.ConvertAll(charsStr, char.Parse);


            // Task_271

            int countA = 0;

            for (int i = 0; i < n; i++)
            {
                if (chars[i] == 'a')
                {
                    countA++;
                }
            }

            Console.WriteLine($"Count of a in chars array = {countA}");


            // Task_272

            int countB = 0;

            for (int i = 0; i < n; i++)
            {
                if (chars[i] == 'b')
                {
                    countB++;
                }
            }

            bool t = false;

            if (countB > n / 2)
            {
                t = true;
            }

            Console.WriteLine($"t = {t}");


            // Task_273

            int sumIndex_S = 0;

            for (int i = 0; i < n; i++)
            {
                if (chars[i] == 's')
                {
                    sumIndex_S += i;
                }
            }

            Console.WriteLine($"Sum of elements equal to s = {sumIndex_S}");


            // Task_274

            double sumIndexBigH = 0;
            int countIndexBigH = 0;

            for (int i = 0; i < n; i++)
            {
                if (chars[i] > 'h')
                {
                    sumIndexBigH += i;
                    countIndexBigH++;
                }
            }

            Console.WriteLine($"Arithmetic average of sum index of elements that > h = {sumIndexBigH / countIndexBigH}");


            // Task_275

            int countElementsSmallK = 0;

            for (int i = 0; i < n; i++)
            {
                if (chars[i] < 'k')
                {
                    countElementsSmallK++;
                }
            }

            Console.WriteLine($"Count of elements < k = {countElementsSmallK}");


            // Task_276

            bool t1 = false;

            for (int i = 0; i < n; i++)
            {
                if (chars[i] == 'r')
                {
                    t1 = true;
                    break;
                }
            }

            Console.WriteLine($"t1 = {t1}");


            // Task_277                                  // Մի հատը չի տպում

            int countD = 0;

            for (int i = 0; i < n; i++)
            {
                if (chars[i] == 'd')
                {
                    countD++;
                }
            }

            char[] chars2 = new char[n - countD];

            for (int i = 0; i < chars2.Length; i++)
            {
                if (chars[i] == 'd')
                {
                    continue;                    
                }
                else
                {
                    chars2[i] = chars[i];
                }
            }

            /*for (int i = 0; i < chars2.Length; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (chars[j] == 'd')
                    {
                        continue;
                        j = i + 1;
                    }
                    else
                    {
                        chars[i] = chars2[j];
                        //break;
                    }
                }
            }*/

            Console.WriteLine("Chars2 elements are:");

            for (int i = 0; i < chars2.Length; i++)
            {
                Console.Write(chars2[i] + " ");
            }
            Console.WriteLine();


            // Task_278

            /*int countOddIndex = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 1)
                {
                    countOddIndex++;
                }
            }

            char[] chars3 = new char[countOddIndex];*/



            Console.ReadKey();
        }
    }
}
