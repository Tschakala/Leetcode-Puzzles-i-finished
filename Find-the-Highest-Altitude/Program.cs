using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Highest_Altitude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] gain = new int[] { -4, -3, -2, -1, 4, 3, 2 };
            Console.WriteLine(LargestAltitude(gain));
        }

        static int LargestAltitude(int[] gain)
        {
            int hight = 0;
            int highest = 0;

            foreach (int i in gain)
            {
                hight += i;

                if (highest < hight)
                {
                    highest = hight;
                }
            }

            return highest;
        }
    }
}
