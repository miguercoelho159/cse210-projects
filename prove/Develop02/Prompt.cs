public class Prompt
{
    List<string> prompts = new List<string>();
    public Prompt()
    {
        prompts.Add("What was something that made me smile today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today, and why?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
    }
    
    public string GetRandomPrompt()
    {
        var random = new Random();
        var randomNumber = random.Next(0, prompts.Count);
        string item = prompts[randomNumber];

        return item;
    }
}