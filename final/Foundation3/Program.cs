using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureLocation = new Address("123 Main St", "Orem", "UT", "USA");
        DateTime lectureDate = new DateTime(2025, 04, 01);
        Lecture lecture = new Lecture("C# Basics", "Learn the basics of C# programming", lectureDate, "10:00pm", lectureLocation, "John Doe", 50);
        Console.WriteLine("--- Lecture Details ---");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("----------------------");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("----------------------");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Address receptionLocation = new Address("456 Main St", "Orem", "UT", "USA");
        DateTime receptionDate = new DateTime(2025, 04, 12);
        Reception reception = new Reception("Saunders Wedding Reception", "Come celebrate our wedding!!", receptionDate, "6:00pm", receptionLocation, "dXH2E@example.com");
        Console.WriteLine("--- Reception Details ---");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("----------------------");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("----------------------");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Address outdoorLocation = new Address("789 Main St", "Orem", "UT", "USA");
        DateTime outdoorDate = new DateTime(2025, 09, 09);
        Outdoor outdoor = new Outdoor("Family Picnic", "Come join us for a family picnic", outdoorDate, "12:00pm", outdoorLocation, "sunny");
        Console.WriteLine("--- Outdoor Details ---");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine("----------------------");
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine("----------------------");
        Console.WriteLine(outdoor.GetShortDescription());
        Console.WriteLine();
    }
}