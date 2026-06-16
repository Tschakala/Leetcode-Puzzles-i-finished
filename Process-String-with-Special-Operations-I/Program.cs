using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process_String_with_Special_Operations_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "z*#";

            Console.WriteLine(ProcessStr(s));
        }
        
        static string ProcessStr(string s)
        {
            List<char> result = new List<char>();

            if (s == null || s == string.Empty)
            {
                return s;
            }

            int counter = 0;

            foreach (char c in s)
            {
                if (c >= 'a' && c <= 'z')
                {
                    result.Add(c);
                    counter++;
                }
                else if (c == '#')
                {
                    result.AddRange(result);
                    counter += result.Count;
                }
                else if (c == '*' && result.Count - 1 != -1)
                {
                    result.RemoveAt(result.Count - 1);
                    counter--;
                }
                else if (c == '%')
                {
                    result.Reverse();
                }
            }
            
            return new string(result.ToArray());
        }
    }
}
