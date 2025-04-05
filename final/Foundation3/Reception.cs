public class Reception : Event
{

    public string RsvpEmail { get; private set; }
    public Reception(string title, string description, DateTime date, string time, Address location, string rsvpEmail) : base(title, description, date, time, location)
    {
        RsvpEmail = rsvpEmail;
    }
    public override string GetFullDetails()
    {
        return $"{GetShortDescription()}\nType: Reception\nRSVP to: {RsvpEmail}";
    }
}