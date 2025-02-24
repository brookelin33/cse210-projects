using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        ScriptureLibrary myLibrary = new ScriptureLibrary();
        Verse myVerse = myLibrary.GetScripture();

        myVerse.DisplayVerse();

        while (!myVerse.CheckAllHidden())
        {
            Console.WriteLine();
            Console.WriteLine("--Press 'ENTER' to continue");
            Console.WriteLine("--Type 'quit' to quit");

            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                break;
            }

            myVerse.HideWords(2);
            Console.Clear();
            myVerse.DisplayVerse();
        }
    }
}
