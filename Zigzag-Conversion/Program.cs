using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zigzag_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "PAYPALISHIRING";
            int numRows = 3;

            Console.WriteLine(Convert(s, numRows));
        }

        static string Convert(string s, int numRows)
        {
            char[,] chars = new char[numRows, s.Length / numRows];

            for (int i = 0; i < s.Length / numRows; i++)
            {
                for (int j = 0; j < numRows; j++)
                {
                    chars[i,j] = s[j+i];
                }
            }

            return chars.ToString();
        }
    }
}
