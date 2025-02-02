using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        journal.LoadFromFile();
        // Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to the Journal Program.");
        string selection;
        do {
            printMenu();
            selection = Console.ReadLine();
            if (selection == "1")
            {
                Entry entry = new Entry();
                string date = entry.date();
                string prompt = entry.getPrompt();
                Console.WriteLine($"{date}");
                Console.WriteLine($"{prompt}");
                string answer = Console.ReadLine(); 
                Console.WriteLine();
                 journal.AddEntry(prompt, answer, date);
            }   
            else if (selection == "2") 
            {

                Console.WriteLine();
                Console.WriteLine("\n--- Journal Entries ---");
                journal.DisplayEntries();
                // Display journal
            }  
            else if (selection == "3")  
            {
                Console.WriteLine();
                journal.SaveToFile();
                // Save journal to file
                // Promt for file name
            }  
            else if (selection == "4")  
            {
                Console.WriteLine();
                journal.LoadFromFile();
                // Promt for file name
                // Load journal from filw
            }
            else if (selection == "5")
            {
                Console.WriteLine();
                Console.WriteLine("Goodbye!");
            }  
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid selection. Please try again.");
            }                           
        } while(selection != "5");

        
    }

    static void printMenu ()
    {
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Write Entry");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }

}