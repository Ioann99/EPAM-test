using System;
using System.Collections.Generic;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            Console.WriteLine("Enter string");
            str = Console.ReadLine();

            string[] strArr = SplitToWords(str);
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (string item in strArr)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item] += 1;
                }
                else
                {
                    dictionary.Add(item, 1);
                }

            }

            PrintKeys(dictionary);
        }

        private static void PrintKeys(Dictionary<string, int> dictionary)
        {
            foreach (KeyValuePair<string, int> entry in dictionary)
            {
                if (entry.Value == 1)
                {
                    Console.WriteLine(entry.Key);
                }
            }
            Console.ReadLine();
        }

        static string[] SplitToWords(string str)
        {
            char[] splitters = { ' ' }; 
            return str.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
        }

    }
}
