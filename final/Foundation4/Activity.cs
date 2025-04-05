public class Activity
{
    public DateTime Date { get; private set;}

    public int Duration { get; private set;}

    public Activity(DateTime date, int duration)
    {
        Date = date;
        Duration = duration;
    }

    public virtual string GetSummary()
    {
        return $"Date: {Date} \nDuration: {Duration}";
    }
}