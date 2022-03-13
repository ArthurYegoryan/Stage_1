using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks.Sorting_Algorithms
{
    internal class Merge_Sort
    {
        public static void Merge(int[] nums, int startIndex, int middle, int endIndex)
        {
            int[] sortedArray = new int[nums.Length];

            int i = startIndex;
            int j = middle + 1;
            int k = 0;

            while (i <= middle && j <= endIndex)
            {
                if (nums[i] < nums[j])
                {
                    sortedArray[k] = nums[i];
                    i++;
                    k++;
                }
                else
                {
                    sortedArray[k] = nums[j];
                    j++;
                    k++;
                }
            }

            while (i <= middle)
            {
                sortedArray[k] = nums[i];
                k++;
                i++;
            }

            while (j <= endIndex)
            {
                sortedArray[k] = nums[j];
                k++;
                j++;
            }

            for (int l = startIndex; l <= endIndex; l++)
            {
                nums[l] = sortedArray[l - startIndex];
            }
        }

        public static void Devide(int[] nums, int startIndex, int endIndex)
        {
            int middle = (startIndex + endIndex) / 2;

            if (startIndex < endIndex)
            {
                Devide(nums, startIndex, middle);
                Devide(nums, middle + 1, endIndex);

                Merge(nums, startIndex, middle, endIndex);
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

            Devide(nums, 0, nums.Length - 1);

            Console.WriteLine("Sorted array is:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
