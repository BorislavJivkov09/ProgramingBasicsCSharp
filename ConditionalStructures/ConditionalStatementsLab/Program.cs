using System;

namespace ConditionalStatementsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //от конзолата четем оценка

            double grade = double.Parse(Console.ReadLine());

            //проверяваме оценката и изписваме резултата
            // ако е 5.50 или по-голяма изписваме Excellent

            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}