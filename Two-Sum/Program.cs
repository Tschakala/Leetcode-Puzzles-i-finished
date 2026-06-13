using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test = TwoSum(new int[] { 2, 5, 5, 11 }, 10);
            foreach (int i in test)
            {
                Console.WriteLine(i);
            }
        }

        static int[] TwoSum(int[] nums, int target)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        result.Add(i);
                        result.Add(j);
                        return result.ToArray();
                    }
                }
            }
            return result.ToArray();
        }
    }
}
