public class Swimming : Activity
{
    public int NumberOfLaps { get; private set; }

    public Swimming(DateTime date, int duration, int numberOfLaps) : base(date, duration)
    {
        NumberOfLaps = numberOfLaps;
    }   

    public override string GetSummary()
    {
        return $"{base.GetSummary()}\nLaps: {NumberOfLaps}";
    }
}