using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        job1.DisplayJobDetails();

        Job job2 = new Job();   
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2023;
        job2._endYear = 2024;

        job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        resume1._name = "Allison Rose";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.DisplayResume();

        // Console.WriteLine($"{job1._jobTitle}");
        // Console.WriteLine($"{job2._jobTitle}");
    }
}