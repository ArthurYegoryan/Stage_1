using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks.Sorting_Algorithms
{
    internal class Quick_Sort
    {
        public static int Pivot(int[] nums, int startIndex, int endIndex)
        {
            int pivotIndex = endIndex;

            int k = startIndex;
            int pivotPosition = startIndex;

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (nums[i] < nums[pivotIndex])
                {
                    int value = nums[k];
                    nums[k] = nums[i];
                    nums[i] = value;
                    ++k;
                    ++pivotPosition;
                }
            }

            int temp = nums[pivotPosition];
            nums[pivotPosition] = nums[pivotIndex];
            nums[pivotIndex] = temp;

            return pivotPosition;
        }

        public static void QuickSort(int[] nums, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                int index = Pivot(nums, startIndex, endIndex);
                QuickSort(nums, startIndex, index - 1);
                QuickSort(nums, index + 1, endIndex);
            }
        }

        static void Main()
        {
            Console.Write("Enter array size: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[size];

            Console.WriteLine("Enter array numbers:");
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            QuickSort(nums, 0, size - 1);

            Console.WriteLine("Sorted array is:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
