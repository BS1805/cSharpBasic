using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file path: ");
            string filePath = Console.ReadLine();

            string longestWord = LongestWordFinder.FindLongestWord(filePath);

            if (!string.IsNullOrEmpty(longestWord))
            {
                Console.WriteLine("Longest word: " + longestWord);
            }
        }
    }
}
