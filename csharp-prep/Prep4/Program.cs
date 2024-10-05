using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> userList = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter numbers (Write 0 when you are done) : ");

            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                userList.Add(number);
            }
        }

        //I will now display the sum

        int sum = 0;
        foreach (int numbers in userList)
        {
            sum += numbers;

        }
        Console.WriteLine("The sum is:" + sum);

        // now i will calculate the average. I understood that to have a decimal number as result,
        // I must declare the variable as a float

        float average = ((float)sum) / userList.Count;

        Console.WriteLine("The average is:" + average);

        if (userList.Count > 0)
        {
            int maxNumber = userList.Max();
            Console.WriteLine("The maximum number in the list is:" + maxNumber);
        }

    }
}