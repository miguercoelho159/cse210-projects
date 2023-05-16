public class Prompt
{
    List<string> _promptList = new List<string>()
    {
        ("Who was the most interesting person I interacted with today? "),
        ("What was the best part of my day? "),
        ("How did I see the hand of the Lord in my life today? "),
        ("What was the strongest emotion I felt today? "),
        ("If I had one thing I could do over today, what would it be? ")
    };

    string randomPrompt = GetRandomPrompt(_promptList);

    public string GetRandomPrompt(List<string> promptList)
    {
        Random random = new Random();
        int randomIndex = random.Next(promptList.Count);
        return _promptList[randomIndex];   

        Prompt prompt = new Prompt();
        string randomPrompt = prompt._randomPrompt; 
        
    }

}