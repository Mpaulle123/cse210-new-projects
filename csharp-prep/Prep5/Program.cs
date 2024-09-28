using System;

class Program
{
    static void Main(string[] args)

    {
        displayWelcomeMessage();
        string userName = promptUserName();
        int userNumber = promptUserNumber();
        int square = squareNumber(userNumber);
        displayResult(userName, square);


    }
    static void displayWelcomeMessage()
    {
            Console.WriteLine("Welcome to the program ! ");

        }
        


    static string promptUserName()
    {

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

        return name;
        }
        

    static int promptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int userNumber = int.Parse(number);

        return userNumber;
    }
    
    static int squareNumber(int userNumber)
    {
        int square = userNumber * userNumber;
        return square;

    }


    static void displayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}");
    }
}

