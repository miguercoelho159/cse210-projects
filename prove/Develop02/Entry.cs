public class Entry
{
    private string _entry = "";
    private string _date;

    public void CreateEntry()
    {   
        // Prompt p = new Prompt();
        Console.Write("Tell me about your day: \n> "); // Console.WriteLine("$"p.GetPrompt");
        _entry = Console.ReadLine();

    }

    public void Display()
    {
        Console.WriteLine($"{_entry} | {_date}");
    }
}
