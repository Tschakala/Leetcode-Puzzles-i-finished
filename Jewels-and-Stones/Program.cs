using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Jewels_and_Stones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string jewels = "aA";
            string stones = "aAAbbbb";

            Console.WriteLine(NumJewsInStones(jewels, stones));
        }

        static int NumJewsInStones(string jewels, string stones)
        {
            List<char> stonescontainer = new List<char>();
            List<char> jewelscontainer = new List<char>();

            jewelscontainer.AddRange(jewels);
            stonescontainer.AddRange(stones);

            int counter = 0;
            foreach (char c in stonescontainer)
            {
                if (jewels.Contains(c))
                {
                    counter++;
                }
                
            }
            return counter;

        }
    }
}
