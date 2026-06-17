using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "pwwkew";

            Console.WriteLine(LengthOfLongestSubstring(s));
        }

        static int LengthOfLongestSubstring(string s)
        {
            if (s == string.Empty)
            {
                return 0;
            }

            int maxLength = 0;
            List<char> current = new List<char>();

            foreach (char c in s)
            {
                while (current.Contains(c))
                {
                    current.RemoveAt(0);
                }

                current.Add(c);
                maxLength = Math.Max(maxLength, current.Count);
            }

            return maxLength;
        }
    }
}
