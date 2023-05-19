using System;

class Program
{


    static void Main(string[] args)
    {

        Prompt _prompt = new Prompt();
        Entry _entry = new Entry();
        JournalEntry _journalEntry = new JournalEntry();

        Console.WriteLine("Welcome to the Journal program!");
        

        string response = "";
        string[] options = {"A", "D", "L", "S", "Q"};


        while (response != "Q")
        {


            while (options.Contains(response)==false)
            {
                Console.WriteLine("\nPlease select one of the choices below :");
                Console.WriteLine("(A)dd \n (D)isplay \n (L)oad \n (S)ave \n (Q)uit ");
                Console.WriteLine("What would you like to do? ");
                response = Console.ReadLine() ?? String.Empty;
                response = response.ToUpper();
            }


            switch (response)
            {

                case "A":
                    string prompt = _prompt.GetRandomPrompt();
                    Console.WriteLine($"\nPlease respond to the prompt:\n{prompt}\n");
                    string entry = Console.ReadLine() ?? String.Empty;
                    _entry.submitEntry(entry, prompt);
                    Console.WriteLine();
                    break;


                case "D":


                    _entry.displayEntries();
                    break;


                case "L":


                    Console.WriteLine("What file would you like to load?");
                    string fileNameLoad = Console.ReadLine() ?? String.Empty;
                    _journalEntry.fileLoad(fileNameLoad);
                    break;


                case "S":
                    Console.WriteLine("What file would you like to save?");
                    string fileNameSave = Console.ReadLine() ?? String.Empty;
                    _journalEntry.fileSave(fileNameSave);
                    break;


                case "Q":
                    Environment.Exit(0);
                    break;


            }
            response = "";
        }
    }
}