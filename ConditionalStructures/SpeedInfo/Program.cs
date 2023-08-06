using System;

namespace SpeedInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // трябва да се напише програма която чете скорост с реално число
            double number = double.Parse(Console.ReadLine());
            // при скорост до 10 slow 
            if (number <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (number <= 50)
            {
                Console.WriteLine("average");
            }
            else if (number <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (number <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else if (number > 1000)
            {
                Console.WriteLine("extremely fast");
            }


        }
    }
}