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
            Console.Write("Enter the speed limit: ");
            int speedLimit = int.Parse(Console.ReadLine());

            Console.Write("Enter the speed of the car: ");
            int carSpeed = int.Parse(Console.ReadLine());

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int demeritPoints = (carSpeed - speedLimit) / 5;
                Console.WriteLine($"Demerit Points: {demeritPoints}");

                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
            }

        }
    }
}
