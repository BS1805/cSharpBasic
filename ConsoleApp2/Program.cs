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
            Console.Write("Enter a time in 24-hour format (HH:mm): ");
            string input = Console.ReadLine();

            TimeValidator.ValidateTime(input);
        }
    }
}
