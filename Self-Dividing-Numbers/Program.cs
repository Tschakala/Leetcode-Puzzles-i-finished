using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Dividing_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int left = 1;
            int right = 22;
            SelfDividingNumbers(left, right);
        }

        static IList<int> SelfDividingNumbers(int left, int right)
        {
            List<int> result = new List<int>();
            bool valid = true;

            for (int i = left; i <= right; i++)
            {
                string x = i.ToString();
                valid = true;
                foreach (char c in x)
                {
                    int num = c - '0';
                    if (num == 0 || i % num != 0)
                    {
                        valid = false;
                        break;
                    }
                }
                if (valid)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
