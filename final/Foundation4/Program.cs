using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Now, 30, 5),
            new Cycling(DateTime.Now, 45, 10),
            new Swimming(DateTime.Now, 60, 3)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}