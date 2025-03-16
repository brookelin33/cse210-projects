public record Checklist : Goal
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
    
    public override int TotalPoints
    {
        get
        {
            if (!IsCompleted())
                return CurrentNumberOfTimesToRedeemBonusPoints * Points;
            else 
                return CurrentNumberOfTimesToRedeemBonusPoints * Points + BonusPoints;
        }
    }

    public int RequiredNumberOfTimesToRedeemBonusPoints
    {
        get;
        set;
    }

    public int CurrentNumberOfTimesToRedeemBonusPoints
    {
        get;
        set;
    }

    public int BonusPoints 
    {
        get;
        set;
    }

    public override string GetDisplay()
    {
        string isCompleted;
        if (IsCompleted ())
            isCompleted = "X";
        else
            isCompleted = " ";

        return $"[{isCompleted}] {Name} - {Description} - {Points} -- Currently Completed: {CurrentNumberOfTimesToRedeemBonusPoints}/{RequiredNumberOfTimesToRedeemBonusPoints}";
    }

    public override void SetCompleted()
    {
        CurrentNumberOfTimesToRedeemBonusPoints++;
        // if we've reached the limit, then add bonus
        // else just add the normal
    }


    public bool IsCompleted()
    {
        if (RequiredNumberOfTimesToRedeemBonusPoints == CurrentNumberOfTimesToRedeemBonusPoints)
            return true;
        else 
            return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist:{Name},{Description},{Points},{BonusPoints},{CurrentNumberOfTimesToRedeemBonusPoints},{RequiredNumberOfTimesToRedeemBonusPoints}";
    }

    public override void CreateGoalFromString(string line)
    {
        var goalTypeSplit = line.Split(":");
        var splitPieces = goalTypeSplit[1].Split(",");
        Name = splitPieces[0];
        Description = splitPieces[1];
        Points = int.Parse(splitPieces[2]);
        BonusPoints = int.Parse(splitPieces[3]);
        CurrentNumberOfTimesToRedeemBonusPoints = int.Parse(splitPieces[4]);
        RequiredNumberOfTimesToRedeemBonusPoints = int.Parse(splitPieces[5]);
    }
}