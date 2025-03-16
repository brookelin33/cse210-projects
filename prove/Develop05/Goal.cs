using System.Reflection.Metadata.Ecma335;

public abstract record Goal 
{
    public abstract string Name
    {
        get; 
        set; 
    }

    public abstract string Description
    {
        get; 
        set; 
    }

    public abstract int Points
    {
        get; 
        set; 
    }

    public abstract string GetDisplay();

    public abstract void SetCompleted ();

    public abstract int TotalPoints
    {
        get;
    }

    public abstract string GetStringRepresentation();

    public abstract void CreateGoalFromString(string line);

}




