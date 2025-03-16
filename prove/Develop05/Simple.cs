public record Simple : Goal
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

    public override string GetDisplay()
    {
        string isCompleted;
        if (IsCompleted)
            isCompleted = "X";
        else
            isCompleted = " ";

        return $"[{isCompleted}] {Name} - {Description} - {Points}";
    }

    public override int TotalPoints
    {
        get 
        {
            if (IsCompleted)
                return Points;
            else
                return 0;
        }
    }

    public bool IsCompleted 
    { 
        get; 
        set; 
    }

    public override void SetCompleted()
    {
        IsCompleted = true;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple:{Name},{Description},{Points},{IsCompleted}";
    }

    public override void CreateGoalFromString(string line)
    {
        var goalTypeSplit = line.Split(":");
        var splitPieces = goalTypeSplit[1].Split(",");
        Name = splitPieces[0];
        Description = splitPieces[1];
        Points = int.Parse(splitPieces[2]);
        IsCompleted = bool.Parse(splitPieces[3]);
    }
}