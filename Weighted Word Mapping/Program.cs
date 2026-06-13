using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weighted_Word_Mapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "haus", "drucker", "flugzeug" };

            int[] weight = new int[26];


            int count = 1;
            for (int i = 0; i < weight.Length; i++)
            {
                weight[i] = count;
                /*Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(weight[i]);
                Console.ResetColor();*/
                count++;
            }
            Console.WriteLine(MapWordWeights(words, weight)); 

        }

        static string MapWordWeights(string[] words, int[] weights)
        {
            string result = "";
            
            foreach (string word in words)
            {
                int sum = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    sum += weights[word[i] - 97];
                    /*Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(sum);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(weights[word[i] - 97]);
                    Console.ResetColor();*/
                }
                sum = sum % 26;
                //Console.WriteLine(sum);
                sum = 26 - sum;
                result += (char)(sum + 96);
                //Console.WriteLine(result);
            }
            return result;
        }
    }
}
