using System.Security.Cryptography.X509Certificates;
using System.IO;

public static class GoalManager
{
    private static List<Goal> _goals = new List<Goal>();

    public static List<Goal> GetGoals() => _goals;

    private static int PreviousTotalPoints = 0;

    public static void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public static int GetTotalPoints() 
    {

        int totalPoints = PreviousTotalPoints;
        foreach (var goal in _goals)
        {
            totalPoints += goal.TotalPoints;
        }
        return totalPoints;
        
    }


    public static void SaveGoals(string fileName)
    {

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {   
            outputFile.WriteLine(GetTotalPoints());
            foreach (var goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }

    public static void LoadGoals(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            if (line.StartsWith("Simple"))
            {
                var simpleGoal = new Simple();
                simpleGoal.CreateGoalFromString(line);
                _goals.Add(simpleGoal);
            }
            else if (line.StartsWith("Eternal"))
            {
                var eternalGoal = new Eternal();
                eternalGoal.CreateGoalFromString(line);
                _goals.Add(eternalGoal);
            }
            else if (line.StartsWith("Checklist"))
            {
                var checklistGoal = new Checklist();
                checklistGoal.CreateGoalFromString(line);
                _goals.Add(checklistGoal);
            }
            else 
            {
                PreviousTotalPoints = int.Parse(line);
            }

        }
    }


}