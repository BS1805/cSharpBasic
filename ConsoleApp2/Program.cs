using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            string input;

            Console.WriteLine("Enter names (press Enter to stop):");

            while (true)
            {
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
            }

            FacebookPost.DisplayLikes(names);
        }
    }
}
