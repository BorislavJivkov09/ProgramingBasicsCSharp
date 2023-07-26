using System;

namespace BiggerNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Четем две цели числа от конзолата

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            //Сравняваме ги и изписваме по-голямото

            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else 
            {
                Console.WriteLine(num2);
            }
        }
    }
}