using System;
using System.Collections.Generic;

namespace string_with_brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            Stack<char> stack = new Stack<char>();

            string brackets;
            char ch;
            bool isCorrect = true;

            dict.Add('}', '{');
            dict.Add(']', '[');
            dict.Add(')', '(');

            Console.WriteLine("Enter brackets.");
            brackets = Console.ReadLine();
            

            foreach (char item in brackets)
            {
                if (stack.Count == 0)
                {
                    stack.Push(item);
                    continue;
                }

                if (dict.ContainsValue(item))
                {
                    stack.Push(item);
                    continue;
                }

                if (dict.ContainsKey(item))
                {
                    ch = stack.Pop();

                    dict.TryGetValue(item, out char tmp);


                    if (tmp != ch)
                    {
                        isCorrect = false;
                    }
                }
            }

            if (stack.Count != 0 || !isCorrect)
            {
                Console.WriteLine("String is uncorrect");
            }
            else
            {
                Console.WriteLine("String is correct");
            }

            Console.ReadLine();
        }
    }
}
