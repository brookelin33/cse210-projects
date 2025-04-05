public class Cycling : Activity
{
    public int Speed { get; private set; }

    public Cycling(DateTime date, int duration, int speed) : base(date, duration)
    {
        Speed = speed;
    }   

    public override string GetSummary()
    {
        return $"{base.GetSummary()}\nSpeed: {Speed} mph";
    }
}