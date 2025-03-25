using System;

namespace ConsoleApp2
{
    public class TimeValidator
    {
        public static void ValidateTime(string input)
        {
            if (TimeSpan.TryParse(input, out TimeSpan time) && time.TotalMinutes >= 0 && time.TotalMinutes < 1440)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
        }
    }
}
