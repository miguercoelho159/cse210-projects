using System;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();

    public static void CreateGoal(string user, string goalType, string goalName, string goalDesc, int pointWorth, bool isComplete, int totalTimes, int doneTimes, int bonus)
    {
        if (user == "user")
        {
            Console.WriteLine("\nWhat is the name of your goal? ");
            goalName = Console.ReadLine();
            Console.WriteLine("Give a small description: ");
            goalDesc = Console.ReadLine();
            Console.WriteLine("How much is this goal worth? ");
            pointWorth = int.Parse(Console.ReadLine());
        }
        if (goalType == "Simple")
        {
            SimpleGoal simpleGoal = new SimpleGoal(goalType, goalName, goalDesc, pointWorth, false);
            goals.Add(simpleGoal);
        }
        if (goalType == "Eternal")
        {
            EternalGoal eternalGoal = new EternalGoal(goalType, goalName, goalDesc, pointWorth, false);
            goals.Add(eternalGoal);
        }
        if (goalType == "Checklist")
        {
            if (user == "user")
            {
                Console.WriteLine("Complete how many times for bonus? ");
                totalTimes = int.Parse(Console.ReadLine());
                Console.WriteLine("What will the bonus be? ");
                bonus = int.Parse(Console.ReadLine());
            }
            ChecklistGoal checklistGoal = new ChecklistGoal(goalType, goalName, goalDesc, pointWorth, false, totalTimes, doneTimes, bonus);
            goals.Add(checklistGoal);
        }
    }

    static void Main(string[] args)
    {
        int totalPoints = 0;
        Console.Clear();
        string response = "";

        while (response != "6")
        {
            Console.WriteLine($"\nYou have {totalPoints} points.\n");
            Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit\nSelect a choice from the menu: ");
            response = Console.ReadLine() ?? String.Empty;
            switch (response)
            {
                case "1":
                    string response2 = "";
                    
                    Console.WriteLine("Which type of goal would you like to create?\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
                    response2 = Console.ReadLine() ?? String.Empty;

                    switch (response2)
                    {
                        case "1":
                            CreateGoal("user", "Simple", "", "", 0, false, 0, 0, 0);
                            break;
                        case "2":
                            CreateGoal("user", "Eternal", "", "", 0, false, 0, 0, 0);
                            break;
                        case "3":
                            CreateGoal("user", "Checklist", "", "", 0, false, 0, 0, 0);
                            break;
                    }
                    response2 = "";
                    break;
                case "2":
                    Console.WriteLine("\nMy goals are:");
                    int i = 0;

                    foreach (Goal goal in goals)
                    {
                        i++;
                        Console.WriteLine($"{i}. [{goal.GetCompleteString()}] {goal.GetGoalName()} ({goal.GetGoalDesc()}) {goal.GetListEnding()}");
                    }
                    break;
                case "3":
                    Console.WriteLine("What is the filename for the goal file? ");
                    string filename = Console.ReadLine();

                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        outputFile.WriteLine($"{totalPoints}");
                        foreach (Goal goal in goals)
                        {
                            outputFile.WriteLine(goal.GetGoalSave());
                        }
                    }
                    break;
                case "4":
                    Console.WriteLine("What is the filename for the goal file? ");
                    filename = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    goals.Clear();
                    
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(",");
                        if (parts.Count() == 1)
                        {
                            totalPoints = int.Parse(line);
                        }
                        else
                        {
                            CreateGoal("computer", $"{parts[0]}", $"{parts[1]}", $"{parts[2]}", int.Parse($"{parts[3]}"), bool.Parse($"{parts[4]}"), int.Parse($"{parts[5]}"), int.Parse($"{parts[6]}"), int.Parse($"{parts[7]}"));
                        }
                    }
                    break;
                case "5":
                    Console.WriteLine("The goals are:");

                    i=0;
                    foreach (Goal goal in goals)
                    {
                        i++;
                        Console.WriteLine($"{i}. {goal.GetGoalName()}");
                    }

                    Console.WriteLine("Which goal did you accomplish? ");
                    int goalSelect = int.Parse(Console.ReadLine());

                    if ((goals[goalSelect-1].GetCompleted()) == false)
                    {
                        totalPoints += (goals[goalSelect-1].RewardPoints());
                        goals[goalSelect-1].Completed();
                    }
                    else
                    {
                        Console.WriteLine("Goal already complete!");
                    }
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
            }
            response = "";
        }
    }
}