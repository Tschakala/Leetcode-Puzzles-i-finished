using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Integers
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int number = random.Next();
            number = -123;
            Console.WriteLine(number);
            Console.WriteLine(reverse(number));
        }

        static int reverse(int x)
        {
            bool isNegative = false;
            List<char> reversed = x.ToString().ToCharArray().ToList();

            if (reversed[0] == '-')
            {
                isNegative = true;
                reversed.RemoveAt(0);
            }

            for (int i = 0; i < reversed.Count / 2; i++)
            {
                char temp = reversed[reversed.Count - i - 1];
                reversed[reversed.Count - i - 1] = reversed[i];
                reversed[i] = temp;
            }

            if (int.TryParse(new string(reversed.ToArray()), out int result))
            {
                if (isNegative)
                {
                    result = -result;
                }
                return result;
            }
            else
            {
                return 0;
            }
        }
    }
}
