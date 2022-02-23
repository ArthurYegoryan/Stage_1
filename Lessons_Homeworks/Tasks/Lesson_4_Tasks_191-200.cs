using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks.Tasks
{
    internal class Lesson_4_Tasks_191_200
    {
        static void Main()
        {
            Console.Write("Enter N = ");
            string nStr = Console.ReadLine();
            int n = int.Parse(nStr);

            Console.Write("Enter x = ");
            string xStr = Console.ReadLine();
            double x = double.Parse(xStr);


            // Task_191

            double sum = 0;

            for (int i = 0; i <= n; i++)
            {
                sum += Math.Pow(x, i);
            }

            Console.WriteLine($"Sum = {sum}");


            // Task_192

            double sum1 = 0;

            for (int i = 0; i <= n; i++)
            {
                sum1 += Math.Pow(-1, i) * Math.Pow(x, i);
            }

            Console.WriteLine($"Sum1 = {sum1}");


            // Task_193

            int sum2 = 0;
            int fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                sum2 += fact;
            }

            Console.WriteLine($"Sum2 = {sum2}");


            // Task_194

            double sum3 = 1;
            double fact1 = 1;

            for (int i = 1; i <= n; i++)
            {
                fact1 *= i;
                sum3 = sum3 + (double)1/fact;
            }

            Console.WriteLine($"Sum3 = {sum3}");


            // Task_195

            double sum4 = 1;
            double fact2 = 1;

            for (int i = 1; i <= n; i++)
            {
                fact1 *= i;
                sum4 = sum4 + Math.Pow(x, i) / fact;
            }

            Console.WriteLine($"Sum4 = {sum4}");

            Console.ReadKey();
        }
    }
}
