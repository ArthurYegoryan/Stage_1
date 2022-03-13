using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks
{
    internal class SortingAlgorithms
    {
        public static void Bubble_Sort(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                bool isSorted = true;
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        isSorted = false;
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
                if (isSorted)
                    break;
            }
        }

        public static void Selection_Sort(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
        }

        public static void Insertion_Sort(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                while (nums[i] < nums[i - 1])
                {
                    int temp = nums[i];
                    nums[i] = nums[i - 1];
                    nums[i - 1] = temp;
                    i--;
                    if (i == 0)
                    {
                        break;
                    }
                }
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

            //Bubble_Sort(nums);
            //Selection_Sort(nums);
            Insertion_Sort(nums);

            Console.WriteLine("Sorted array is:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
