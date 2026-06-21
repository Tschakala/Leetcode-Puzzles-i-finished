using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Ice_Cream_Bars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cost = new int[] { 1, 6, 3, 1, 2, 5 };
            int coins = 20;

            Console.WriteLine(MaxIceCream(cost, coins));
        }

        static int MaxIceCream(int[] costs, int coins)
        {
            if (coins < costs.Min())
            {
                return 0;
            }

            List<int> ice = new List<int>();
            ice.AddRange(costs);
            int counter = 0;

            while (ice.Count > 0 && coins >= ice.Min())
            {
                if ((coins - ice.Min()) >= 0)
                {
                    coins -= ice.Min();
                    ice.Remove(ice.Min());
                    counter++;
                }
            }
            return counter;
        }
    }
}
