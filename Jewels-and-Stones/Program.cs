using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewels_and_Stones
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }

        static int NumJewsInStones(string jews, string stones)
        {
            int count = 0;

            List<char> stonelist = new List<char>();

            stonelist.AddRange(stones.ToCharArray());

            foreach (char c in jewels)
            {
                if (stonelist.Contains(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
