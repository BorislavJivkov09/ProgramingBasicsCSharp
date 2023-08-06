namespace PasswordGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //трябва да се направи програма която да чете парола
            string password = Console.ReadLine();
            string correct = "s3cr3t!P@ssw0rd";

            //ако е вярна да се изпише welcome ако е грешна да изпишем wrong password
            if (password == correct)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}