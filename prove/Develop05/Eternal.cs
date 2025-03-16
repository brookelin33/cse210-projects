public record Eternal : Goal
{
    public override string Name
    {
        get; 
        set; 
    }

    public override string Description
    {
        get; 
        set; 
    }

    public override int Points
    {
        get; 
        set; 
    }

    public int NumberOfTimesCompleted
    {
        get;
        set;
    }

    public override string GetDisplay()
    {
        return $"[ ] {Name} - {Description} - {Points}";
    }

    public override void SetCompleted()
    {
        NumberOfTimesCompleted++;
    }

    public override int TotalPoints
    {
        get
        {
            return NumberOfTimesCompleted * Points;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal:{Name},{Description},{Points},{NumberOfTimesCompleted}";
    }

    public override void CreateGoalFromString(string line)
    {
        var goalTypeSplit = line.Split(":");
        var splitPieces = goalTypeSplit[1].Split(",");
        Name = splitPieces[0];
        Description = splitPieces[1];
        Points = int.Parse(splitPieces[2]);
        NumberOfTimesCompleted = int.Parse(splitPieces[3]);
    }
}