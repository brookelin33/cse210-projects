using System;
using System.Collections.Generic;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0
        List<int> numbers = new List<int>();

        int number = 0;
        // Console.WriteLine("Write a number to add to the list. Type '0' to quit. ");
        // string usernumber = Console.ReadLine();
        // int number = int.Parse(usernumber);

        do  {
            Console.WriteLine("Write a number to add to the list. Type '0' to quit. ");
            string usernumber = Console.ReadLine();
            number = int.Parse(usernumber);

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

    }
        
}
    //     Compute the sum, or total, of the numbers in the list.
    //     Compute the average of the numbers in the list.
    //     Find the maximum, or largest, number in the list.
    // 
    