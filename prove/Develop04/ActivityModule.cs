class ActivityModule
{
    private string _activity;
    private string _startMessage;
    protected int _duration;
    public List<string> spinner = new List<string>();


    public ActivityModule(string activity, string startMessage)
    {

        _activity = activity;
        _startMessage = startMessage;
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
    }


    public void Counter(int time)
    {
        int i = 0;

        while (i != time)
        {
            Console.Write($"\b\b {time-i}");
            Thread.Sleep(1000);
            i++;
        }
        Console.Write("\b");
    }


    public void DisplayTransScreen()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activity} activity.\n{_startMessage}\n");
        Console.WriteLine("How much time in seconds do you wish to do this activity? ");

        string durString = Console.ReadLine();
        int duration = int.Parse(durString);
        SetDuration(duration);

        Console.Clear();
        Console.WriteLine("Get ready...");

        Pause(2);
    }

    public void Pause(int time)
    {
        int i = 0;
        int z = 0;

        while (i != time)
        {
            while (z <= 3)
            {
                Console.Write(spinner[z]);
                Thread.Sleep(333);
                Console.Write("\b");
                z++;
            }
            z = 0;
            i++;
        }

        Console.Clear();
    }


    public string GetStartMessage()
    {
        return _startMessage;
    }

    public void EndMessage()
    {
        Console.WriteLine("Well done!!");
        Pause(2);

        Console.WriteLine($"You have completed another {_duration} seconds of the {_activity} Activity.");
        
        Pause(3);

    }


    public void SetDuration(int duration)
    {
        _duration = duration;
        
    }
}