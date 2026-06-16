using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Roman_to_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string test = "MCMXCIV";

            Console.WriteLine(RomanToInteger(test));
        }

        static int RomanToInteger(string s)
        {
            List<char> values = new List<char>();
            List<int> intvalues = new List<int>();
            int sameval = 0;

            int result = 0;
            foreach (char c in s)
            {
                values.Add(c);
            }

            int j = 0;
            foreach (char c in values)
            {
                if (values[j] == 'M')
                {
                    intvalues.Add(1000);
                }
                else if (values[j] == 'D')
                {
                    intvalues.Add(500);
                }
                else if (values[j] == 'C')
                {
                    intvalues.Add(100);
                }
                else if (values[j] == 'L')
                {
                    intvalues.Add(50);
                }
                else if (values[j] == 'X')
                {
                    intvalues.Add(10);
                }
                else if (values[j] == 'V')
                {
                    intvalues.Add(5);
                }
                else if (values[j] == 'I')
                {
                    intvalues.Add(1);
                }
                j++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (i+2 <= s.Length)
                {
                    if (intvalues[i] == intvalues[i + 1])
                    {
                        sameval++;
                    }
                    else if (intvalues[i] > intvalues[i + 1])
                    {
                        if (sameval != 0)
                        {
                            sameval++;
                            result += sameval * intvalues[i];
                            sameval = 0;
                        }
                        else
                        {
                            result += intvalues[i];
                        }
                    }
                    else
                    {
                        result -= intvalues[i];
                    }
                }
                else
                {
                    if (sameval != 0)
                    {
                        sameval++;
                        result += intvalues[i] * sameval;
                    }
                    else
                    {
                        result += intvalues[i];
                    }
                    
                }

            }



            return result;
        }
    }
}
