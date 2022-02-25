using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks.Tasks
{
    internal class Lesson_5_Tasks_251_260
    {
        /*static void Main()
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

            int[] numbers = Array.ConvertAll(numbersStr, int.Parse);


            // Task_251

            int max = numbers.Max();
            Console.WriteLine($"Maximum value of array = {max}");


            // Task_252

            int min = numbers.Min();
            Console.WriteLine($"Minimum value of array = {min}");


            // Task_253

            int sumMaxMin = max + min;
            Console.WriteLine($"Sum of max and min values = {sumMaxMin}");


            // Task_254

            int multMaxMin = max * min;
            Console.WriteLine($"Multiplication of max and min values = {multMaxMin}");


            // Task_255
                        
            max = numbers[0];
            int indexMax = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    indexMax = i;
                }
            }

            int sumMaxIndex = max + indexMax;
            Console.WriteLine($"Sum of max value and its index = {sumMaxIndex}");


            // Task_256

            min = numbers[0];
            int indexMin = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    indexMin = i;
                }
            }

            int sumMinIndex = min + indexMin;
            Console.WriteLine($"Sum of min value and its index = {sumMinIndex}");


            // Task_257

            Console.WriteLine($"Index of the first max value = {indexMax}");


            // Task_258

            int indexMaxLast = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] >= max)
                {
                    indexMaxLast = i;
                }
            }

            Console.WriteLine($"Index of the last max value = {indexMaxLast}");


            // Task_259

            Console.WriteLine($"Index of the first min value = {indexMin}");


            // Task_260

            int indexMinLast = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] <= min)
                {
                    indexMinLast = i;
                }
            }

            Console.WriteLine($"Index of the last min value = {indexMinLast}");

            Console.ReadKey();
        }*/
    }
}
