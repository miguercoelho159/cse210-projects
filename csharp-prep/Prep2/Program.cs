using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello there, what is your grade percentage?");
        string user_grade = Console.ReadLine();
        int final_grade = int.Parse(user_grade);

        string letter = "";

        if (final_grade >= 90)
        {
            letter = "A";
        }
        else if (final_grade >= 80)
        {
            letter = "B";
        }
        else if (final_grade >= 70)
        {
            letter = "C";
        }
        else if (final_grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your current grade is: {letter}.");

        if (final_grade >= 70)
        {
            Console.WriteLine($"Congrats! You have passed with an {letter}! \n :)");
        }
        else
        {
            Console.WriteLine("Unfortunately you did not pass. \n:,(");
        }
    }
}