using System;

class Program
{

    static void Main(string[] args)
    {

        BreathingModule breathingModule = new BreathingModule("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectingModule reflectingModule = new ReflectingModule("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListingModule listingModule = new ListingModule("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        string response = "";
        
        while (response != "4")
        {

            Console.Clear();

            Console.WriteLine("Menu options:\n  1. Breathing activity\n  2. Reflecting activity\n  3. Listing activity\n  4. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            response = Console.ReadLine() ?? String.Empty;

            switch (response)
            {

                case "1":
                    breathingModule.DisplayTransScreen();
                    breathingModule.Activity();
                    break;

                case "2":
                    reflectingModule.DisplayTransScreen();
                    reflectingModule.Activity();
                    break;

                case "3":
                    listingModule.DisplayTransScreen();
                    listingModule.Activity();
                    break;
                    
                case "4":
                    Environment.Exit(0);
                    break;
                    
            }

            response = "";
        }
    }
}


// Phew..now this one was a hassle. 