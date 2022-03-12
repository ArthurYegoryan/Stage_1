using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Lessons_Homeworks.Tasks
{
    struct ConvertToString
    {
        static int size;
        public ConvertToString(int size1, int[] numbers)
        {
            size = size1;
        }

        public string[] numbersStr = new string[size];

        public void DoConvert(int size1, int[] numbers)          // Index was outside the bounds of the array
        {
            for (int i = 0; i < size1; i++)
            {
                numbersStr[i] = Convert.ToString(numbers[i]);
            }
        }
    }
    internal class Stage_1_Exam_Task_3
    {
        static void Main()
        {
            Console.Write("Enter array size: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];

            Console.WriteLine("Enter numbers array elements:");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Numbers array elements type is: {numbers.GetType()}");
            Console.Write("Elements of numbers array are: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            ConvertToString convertToString = new ConvertToString(size, numbers);

            convertToString.DoConvert(size, numbers);

            Console.WriteLine($"NumbersStr array elements type is: {convertToString.numbersStr.GetType()}");
            Console.Write("Elements of numbers array are: ");

            for (int i = 0; i < convertToString.numbersStr.Length; i++)
            {
                Console.Write(convertToString.numbersStr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}*/
