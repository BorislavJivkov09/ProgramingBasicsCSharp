using System;


namespace PurviOpit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //да се изчете от конзолата сметката на ани
            //ако има отстъпка трябва сметката да е по голяма или равна на 10.50
            //ако има отстъпка трябва да изпише Console.WriteLine("Ще имате отстъпка") ако не ("Еми.. шанс")
            double smetka = double.Parse(Console.ReadLine());
            double smetkaOtstupka = 10.50;
            if (smetka >= smetkaOtstupka)
            {
                Console.WriteLine("Ще имате отстъпка");
            }

            if (smetka < smetkaOtstupka)
            {
                Console.WriteLine("Еми.. шанс");
            }
        }
    }
}