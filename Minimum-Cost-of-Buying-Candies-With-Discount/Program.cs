using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Cost_of_Buying_Candies_With_Discount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cost = {5,5};
            Console.WriteLine(MinimumCost(cost));
        }

        static int MinimumCost(int[] cost)
        {
            List<int> candy = new List<int>();
            candy.AddRange(cost);
            candy.Sort((a,b) => b.CompareTo(a));

            int count = 0;
            int i = 0;
            int costs = 0;
            while (candy.Count != 0)
            {
                if (count == 2)
                {
                    candy.RemoveAt(i);
                    count = 0;
                }
                else
                {
                    costs += candy[i];
                    candy.RemoveAt(i);
                    count++;
                }
            }

            return costs;
        }
    }
}
