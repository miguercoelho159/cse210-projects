using System;

class Program
{

    static void Main(string[] args)
    {
        Reference scriptReference = new Reference("Mosiah", 3, 19);
        Scripture m319 = new Scripture(scriptReference, "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.");
        string quitCheck = "";

        Console.WriteLine("Press ENTER to continue. To quit type QUIT.");


        int firstTime = 0;
        


        while ((quitCheck.ToUpper() != "QUIT") && (m319.isAllHidden() != true))
        {
    
            if (firstTime == 0)
            {
                firstTime++;
            }
            else
            {
                m319.HideRandomWord();
            }

            m319.Display();
            quitCheck = Console.ReadLine();
            
            Console.Clear();
        }
    }
}

// It needs some polishing for sure but I think I went above and beyond my understanding
// in this prove assignment. To whoever read this, hopefully it's only Andres, let me know
// what you though of my code and if you can, give me some advice on what I could work on! 