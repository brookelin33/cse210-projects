public class Running : Activity
{
    public int Distance {get; private set;}

    public Running(DateTime date, int duration, int distance) : base(date, duration)
    {
        Distance = distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}\nDistance: {Distance} miles";
    }
}