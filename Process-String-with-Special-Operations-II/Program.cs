using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process_String_with_Special_Operations_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "%#bz%xum##i##vzo#pwc*#dkwbh####%uf%s*%cgppqhqa%h#l##o%ij%%cz%iga##e###u%#e####jfwx##%%*x%m*%#";

            long k = 6523; 

            Console.WriteLine(ProcessStr(s, k));
        }

        static char ProcessStr(string s, long k)
        {
            long len = 0;

            foreach (char c in s)
            {
                if (c >= 'a' && c <= 'z')
                {
                    len++;
                }
                else if (c == '#')
                {
                    len *= 2;
                }
                else if (c == '*')
                {
                    if (len > 0)
                        len--;
                }
            }

            if (k >= len)
                return '.';

            for (int i = s.Length - 1; i >= 0; i--)
            {
                char c = s[i];

                if (c >= 'a' && c <= 'z')
                {
                    len--;

                    if (k == len)
                        return c;
                }
                else if (c == '#')
                {
                    len /= 2;

                    if (k >= len)
                        k -= len;
                }
                else if (c == '*')
                {
                    len++;
                }
                else if (c == '%')
                {
                    k = len - 1 - k;
                }
            }

            return '.';
        }
    }
}
