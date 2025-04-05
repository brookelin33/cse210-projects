public abstract class Event
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public DateTime Date { get; private set; }
    public string Time { get; private set; }

    public Address Location { get; private set; }

    public Event(string title, string description, DateTime date, string time, Address location)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Location = location;
    }

    public virtual string GetStandardDetails() {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nLocation: {Location.ReturnAddress()}";
    }

    public virtual string GetFullDetails() {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nLocation: {Location.ReturnAddress()}";
    }

    public virtual string GetShortDescription() {
        return $"Title: {Title}\nDate: {Date}\nTime: {Time}\nLocation: {Location.ReturnAddress()}";
    }
    
}