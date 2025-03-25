using System;
using System.IO;
using System.Linq;

namespace ConsoleApp2
{
    public class LongestWordFinder
    {
        public static string FindLongestWord(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return string.Empty;
            }

            string text = File.ReadAllText(filePath);
            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            return words.OrderByDescending(word => word.Length).FirstOrDefault();
        }
    }
}
