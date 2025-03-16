using System;
using System.ComponentModel.Design;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        var topMenuSelection = RetrieveTopMenuSelection();

        while (topMenuSelection != 6)
        {
            if (topMenuSelection == 1)
            { 
                Console.WriteLine("What type of goal do you want to create? ");
                var goalTypeSelection = RetrieveGoalTypeSelection();

                if (goalTypeSelection == 1)
                {
                    Console.Write("Name: ");
                    var name = Console.ReadLine();
                    Console.Write("Description: ");
                    var description = Console.ReadLine();
                    Console.Write("Points: ");
                    var points = Int32.Parse(Console.ReadLine());
                    var simpleGoal = new Simple {Name = name, Description = description, Points = points};
                    GoalManager.AddGoal(simpleGoal);
                }
                if (goalTypeSelection == 2)
                {
                    Console.Write("Name: ");
                    var name = Console.ReadLine();
                    Console.Write("Description: ");
                    var description = Console.ReadLine();
                    Console.Write("Points: ");
                    var points = Int32.Parse(Console.ReadLine());
                    var eternalGoal = new Eternal {Name = name, Description = description, Points = points};
                    GoalManager.AddGoal(eternalGoal);
                }
                if (goalTypeSelection == 3)
                {
                    Console.Write("Name: ");
                    var name = Console.ReadLine();
                    Console.Write("Description: ");
                    var description = Console.ReadLine();
                    Console.Write("Points: ");
                    var points = Int32.Parse(Console.ReadLine());
                    Console.Write("How many times until you receive bonus points?");
                    var requiredNumberOfTimesToRedeemBonusPoints = int.Parse(Console.ReadLine());
                    Console.Write("Amount for bonus? ");
                    var bonusPoints = int.Parse(Console.ReadLine());
                    var checklistGoal = new Checklist {Name = name, Description = description, Points = points, RequiredNumberOfTimesToRedeemBonusPoints = requiredNumberOfTimesToRedeemBonusPoints, BonusPoints = bonusPoints};
                    GoalManager.AddGoal(checklistGoal);
                }
            }
            else if (topMenuSelection == 2)
            {
                Console.WriteLine($"Total Points: {GoalManager.GetTotalPoints()}");
                Console.WriteLine();
                foreach (var goal in GoalManager.GetGoals())
                {
                    Console.WriteLine(goal.GetDisplay());
                }
                
            }
            else if (topMenuSelection == 3)
            {
                Console.Write("What is the name of the file? ");
                var fileName = Console.ReadLine();
                GoalManager.SaveGoals(fileName);
                Console.WriteLine("File Saved. ");
            }
            else if (topMenuSelection == 4)
            {
                Console.Write("What is the name of the goal file? ");
                var fileName = Console.ReadLine();
                GoalManager.LoadGoals(fileName);
                Console.WriteLine("Goals Loaded");
                Console.WriteLine($"You have {GoalManager.GetTotalPoints()} points");

            }
            else if (topMenuSelection == 5)
            {
                var goals = GoalManager.GetGoals();
                var goalCount = goals.Count();
                
                Console.WriteLine("The goals are:");
                for (int i = 1; i <= goalCount; i++)
                {
                    Console.WriteLine($"{i}. {goals[i - 1].Name}");
                }
                Console.WriteLine("Which did you accomplish?");
                var goalSelection = int.Parse(Console.ReadLine());
                var goal = goals[goalSelection - 1];
                goal.SetCompleted();


            }
            topMenuSelection = RetrieveTopMenuSelection();
        }
    }

    static int RetrieveTopMenuSelection()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine(" 1. Creat new goal");
        Console.WriteLine(" 2. List goals");
        Console.WriteLine(" 3. Save goals");
        Console.WriteLine(" 4. Load goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
        Console.WriteLine();
        Console.Write("Select a choice from the menu: ");
        var selection = int.Parse(Console.ReadLine());
        return selection;
    }

    static int RetrieveGoalTypeSelection()
    {
        Console.WriteLine("Goal Options: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        var selection = int.Parse(Console.ReadLine());
        return selection;
    }

}

