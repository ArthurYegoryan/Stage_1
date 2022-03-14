using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks
{        
    internal class Binary_Search
    {
        public static void BinarySearch(int number, int[] nums, int startIndex, int endIndex)
        {
            int middleIndex = (startIndex + endIndex) / 2;

            if (startIndex > endIndex)
            {
                Console.WriteLine($"Number {number} is not found!");
                return;
            }

            if (number == nums[middleIndex])
            {
                Console.WriteLine($"Number {number} is found in index {middleIndex}");
                return;
            }
            else if (number > nums[middleIndex])
            {
                BinarySearch(number, nums, middleIndex + 1, endIndex);
                return;
            }
            else
            {
                BinarySearch(number, nums, startIndex, middleIndex - 1);
                return;
            }
        }

        static void Main()
        {
            int[] nums = { 14, 20, 26, 35, 48, 50, 61, 68, 75 };

            Console.Write("Array elements are: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
            
            Console.Write("What element do you want to find? ");
            int number = Convert.ToInt32(Console.ReadLine());

            BinarySearch(number, nums, 0, nums.Length - 1);
        }
    }
}
