using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Median_of_Two_Sorted_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] nums1 = { 1, 2 };
            int [] nums2 = { 3, 4 };

            Console.WriteLine(FindMedianSortedArrays(nums1, nums2));
        }

        static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double median = 0;
            List<int> total = new List<int>(nums1.Length + nums2.Length);
            total.AddRange(nums1);
            total.AddRange(nums2);

            total.Sort();

            if (total.Count % 2 == 0)
            {
                median = (total[total.Count / 2 - 1] + total[total.Count / 2]) / 2.0;
            }
            else
            {
                median = total[total.Count / 2];
            }
            return median;
        }
    }
}
