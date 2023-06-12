class BreathingModule : ActivityModule
{
    public BreathingModule(string activity, string startMessage) : base(activity, startMessage)
    {
    }

    public void Activity()
    {
        int i = 0;
        int totalActivities = ((_duration/3)+1)/2;
        
        while (i <= totalActivities)
        {
            Console.Write("\nBreath in...    ");
            Counter(3);
            Console.Clear();
            Console.Write("\nBreath out...   ");
            Counter(3);
            Console.Clear();

            i++;
        }
        
        EndMessage();
    }
}