using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Number_of_Balloons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "nlaebolko";
            Console.WriteLine(MaxNumberOfBalloons(text));
        }

        static int MaxNumberOfBalloons(string text)
        {
            List<char> list = new List<char>();
            list.AddRange(text);
            string balloon = "balloon";
            int c = 0;
            int count = list.Count();
            int x = 0;

            for (int i = 0; i < count; i++)
            {
                if (x >= 7)
                {
                    x = 0;
                }
                if (list.Contains(balloon[x]))
                {
                    c++;
                    list.Remove(balloon[x]);
                    x++;
                }
                else
                {
                    return c / 7;
                }
            }

            return c / 7;
        }
    }
}
