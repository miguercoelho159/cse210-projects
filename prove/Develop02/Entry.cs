public class Entry
{
    public static List<string> entries = new List<string>();

    public void submitEntry(string entry, string prompt)
    {
        DateTime currentTime = DateTime.Now;
        string dateText = currentTime.ToShortDateString();
        entries.Add($"----------------\n{dateText}\nQuestion:\n{prompt}\nEntry:\n\n{entry}\n----------------");
    }

    public void displayEntries()
    {
        foreach (string entry in entries)
        {
            Console.WriteLine($"\n{entry}");
        }
    }
}