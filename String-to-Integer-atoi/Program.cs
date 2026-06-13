using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_to_Integer_atoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "-2147483648";

            Console.WriteLine(myAtoi(s)); 
        }

        static int myAtoi(string s)
        {
            List<char> chars = s.ToCharArray().ToList();
            bool isNegative = false;
            bool hitstart = false;
            bool hitplus = false;
            bool hitminus = false;
            bool hitend = false;
            bool hitzero = false;
            bool onlynumbers = false;
            string max = "2147483647";
            string min = "2147483648";

            int count = 0;

            foreach(char c in s)
            {
                if (!char.IsDigit(c))
                {
                    onlynumbers = false;
                    break;
                }
                else
                {
                    onlynumbers = true;
                }
            }

            foreach (char c in s)
            {
                if ((c >= '0' && c <= '9') && hitstart == false)
                {
                    if (c >= '1' && c <= '9')
                    {
                        hitstart = true;
                    }
                    else
                    {
                        hitzero = true;
                        if (onlynumbers)
                        {
                            if (chars.Contains('0') || chars.Contains('1') || chars.Contains('2') || chars.Contains('3') || chars.Contains('4') || chars.Contains('5') || chars.Contains('6') || chars.Contains('7') || chars.Contains('8') || chars.Contains('9'))
                            {
                                hitzero = false;
                            }
                        }
                        else
                        {
                            if (char.IsDigit(chars[count + 1]) && chars[count + 1] != '0')
                            {
                                hitzero = false;
                            }
                        }

                        chars.RemoveAt(count);
                        count--;
                    }
                }
                else if (hitstart == false)
                {
                    if (!char.IsDigit(c) && c != ' ' && c != '-' && c != '+' || hitplus || hitminus)
                    {
                        return 0;
                    }
                    else if (c == '+')
                    {
                        hitplus = true;
                    }
                    else if (c == '-' && !hitplus)
                    {
                        isNegative = true;
                        hitminus = true;
                    }

                    chars.RemoveAt(count);
                    count--;
                }
                else if (hitstart == true)
                {
                    if (char.IsDigit(c) && hitend == false)
                    {
                    }
                    else
                    {
                        hitend = true;
                        chars.RemoveAt(count);
                        count--;
                    }
                }
                count++;
            }

            if ((chars.Count > max.Length || chars.Count == max.Length && string.Compare(new string(chars.ToArray()), max, StringComparison.Ordinal) > 0) && !isNegative)
            {
                return int.MaxValue;
            }
            else if ((chars.Count > min.Length || chars.Count == min.Length && string.Compare(new string(chars.ToArray()), min, StringComparison.Ordinal) > 0) && isNegative)
            {
                return int.MinValue;
            }

            if (hitstart == false || hitzero == true)
            {
                return 0;
            }

            if (isNegative)
            {
                chars.Insert(0, '-');
            }

            if (int.TryParse(new string(chars.ToArray()),out int result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
    }
}
