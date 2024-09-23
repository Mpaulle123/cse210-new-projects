using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 100);

        int userNumber = -1;
        while ( userNumber != magicNumber)
        {
            Console.Write("what is the magic number? ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber == magicNumber)
            {
                Console.WriteLine("You guessed the magic number");
            }
        
            else if (userNumber <  magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (userNumber > magicNumber)
            {
                Console.WriteLine("lower");
            }
        }
    }
}