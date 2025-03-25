using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class FacebookPost
    {
        public static void DisplayLikes(List<string> names)
        {
            if (names.Count == 1)
            {
                Console.WriteLine($"{names[0]} likes your post.");
            }
            else if (names.Count == 2)
            {
                Console.WriteLine($"{names[0]} and {names[1]} like your post.");
            }
            else if (names.Count > 2)
            {
                Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post.");
            }
        }
    }
}
