using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Roman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 8237;
            Console.WriteLine(IntToRoman(num));
        }

        static string IntToRoman(int num)   
        {
            string result = string.Empty;
            int temp = 0;
            int count = 0;

            if (num >= 1000)
            {
                temp = num % 1000;
                num = num - temp;
                count += (num / 1000);
                for (int i = 0; i < count; i++)
                {
                    result += 'M';
                }
            }

            if (num >= 100)
            {
                if (temp != 0 || result.Length != 0)
                {
                    num = temp;
                }
                count = 0;
                temp = num % 100;
                if (num - temp != 0)
                {
                    num = num - temp;
                }
                count += (num / 100);
                if (count <= 3)
                {
                    for (int i = 0; i < count; i++)
                    {
                        result += 'C';
                    }
                }
                else if (count == 5)
                {
                    result += 'D';
                }
                else if (count < 5)
                {
                    int x = 5 - count;
                    for (int i = 0; i < x; i++)
                    {
                        result += 'C';
                    }
                    result += 'D';
                }
                else if (count > 5 && count < 9)
                {
                    int x = count - 5;
                    result += 'D';
                    for (int i = 0; i < x; i++)
                    {
                        result += 'C';
                    }
                }
                else
                {
                    result += 'C';
                    result += 'M';
                }
            }

            if (num >= 10)
            {
                if (temp != 0 || result.Length != 0)
                {
                    num = temp;
                }
                count = 0;
                temp = num % 10;
                if (num - temp != 0)
                {
                    num = num - temp;
                }
                count += (num / 10);
                if (count <= 3)
                {
                    for (int i = 0; i < count; i++)
                    {
                        result += 'X';
                    }
                }
                else if (count == 5)
                {
                    result += 'L';
                }
                else if (count < 5)
                {
                    int x = 5 - count;
                    for (int i = 0; i < x; i++)
                    {
                        result += 'X';
                    }
                    result += 'L';
                }
                else if (count > 5 && count < 9)
                {
                    int x = count - 5;
                    result += 'L';
                    for (int i = 0; i < x; i++)
                    {
                        result += 'X';
                    }
                }
                else
                {
                    result += 'X';
                    result += 'C';
                }
            }

            if (num >= 1 || result.Length != 0)
            {
                if (temp != 0 || result.Length != 0)
                {
                    num = temp;
                }
                count = 0;
                count += num;
                if (count <= 3)
                {
                    for (int i = 0; i < count; i++)
                    {
                        result += 'I';
                    }
                }
                else if (count == 5)
                {
                    result += 'V';
                }
                else if (count < 5)
                {
                    int x = 5 - count;
                    for (int i = 0; i < x; i++)
                    {
                        result += 'I';
                    }
                    result += 'V';
                }
                else if (count > 5 && count < 9)
                {
                    int x = count - 5;
                    result += 'V';
                    for (int i = 0; i < x; i++)
                    {
                        result += 'I';
                    }
                }
                else
                {
                    result += 'I';
                    result += 'X';
                }
            }

            return result;
        }
    }
}
