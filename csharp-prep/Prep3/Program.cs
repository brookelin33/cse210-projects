using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Console.WriteLine("Hello Prep3 World!");
        Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();

        string guess = "";

        do{
        Console.Write("What is your guess? ");
        guess = Console.ReadLine();
        
        if (int.Parse(guess) > int.Parse(magicNumber))
        {
            Console.WriteLine("Guess lower. ");
        }
        else if (int.Parse(guess) < int.Parse(magicNumber))
        {
            Console.WriteLine("Guess higher. ");
        }
        else
        {
            Console.WriteLine("You guessed it! ");
        }
        } 
        while (int.Parse(guess) != int.Parse(magicNumber));
}
    } 