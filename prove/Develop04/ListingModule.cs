class ListingModule : ActivityModule
{
    
    private List<string> prompts = new List<string>();

    public ListingModule(string activity, string startMessage) : base(activity, startMessage)
    {
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");
    }

    public void Activity()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 4);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {prompts[randomNumber]} ---");
        Console.Write("\nYou may begin in: ");
        Counter(5);
        Console.Write("\b\n");

        int i = 0;
        var time = DateTime.UtcNow;
        while (DateTime.UtcNow - time < TimeSpan.FromSeconds(_duration))
        {
            Console.Write(" > ");
            Console.ReadLine();
            i++;
        }

        Console.WriteLine($"You listed {i} items!\n");
        EndMessage();
    }
}