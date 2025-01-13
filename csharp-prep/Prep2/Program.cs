using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your percentage?");
        string percentage = Console.ReadLine();
        if (int.Parse(percentage) >= 90)
        {
            Console.WriteLine("You have an A.");
        }
        else if (int.Parse(percentage) >= 80)
        {
            Console.WriteLine("You have a B.");
        }
        else if (int.Parse(percentage) >= 70)
        {
            Console.WriteLine("You have a C.");
        }
        else if (int.Parse(percentage) >= 60)
        {
            Console.WriteLine("You have a D.");
        }
        else if (int.Parse(percentage) < 60)
        {
            Console.WriteLine("You have a F.");
        }
        if (int.Parse(percentage) >= 70)
        {
            Console.WriteLine("You have passed the course. Congradulations!");
        }
        else if (int.Parse(percentage) <70)
        {
            Console.WriteLine("You did not pass the class. You'll get it next time!");
        }

    }
}