using System.IO;

public class JournalEntry
{
    
    Entry _entry = new Entry();
    
    public void fileLoad(string fileName)
    {

        string[] lines = System.IO.File.ReadAllLines(fileName);
        Console.WriteLine();
        foreach (string line in lines)
        {
            Console.Write(line);
        }
        Console.WriteLine();
    }

    public void fileSave(string fileName)
    {

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(string entry in Entry.entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
}