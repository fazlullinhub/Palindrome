using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter string to check it out on palindrome: ");
            string input = Console.ReadLine();

            string processedInput = input.Replace("", "").ToLower();

            bool isPalindrome = CheckPalindrome(processedInput);
            if (isPalindrome)
            {
                Console.WriteLine("The string is palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not palindrome.");
            }
        }

        static bool CheckPalindrome(string input)
        {
            Queue<char> queue = new Queue<char>();

            foreach (char c in input)
            {
                queue.Enqueue(c);
            }

            for (int i = 0; i < input.Length; i++)
            {
                char front = queue.Dequeue();
                if (front != input[input.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
