using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{     internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 and 10: ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
