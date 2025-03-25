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
            var count = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0) count++;
            }
            Console.WriteLine("total count is "+ count +'\n');
        }
    }
}
