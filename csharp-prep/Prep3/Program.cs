using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello and welcome to Miguel's Number Guesser Game!");
        Console.Write("I'll generate a number for you and you'll guess... (Press ENTER if you'd like to continue)");
        
        Random random_generator = new Random();

        int generated_num = random_generator.Next(1,100);
        string user_number = Console.ReadLine();

        int user_guess = -1;

        while (user_guess != generated_num)
        {   
            Console.WriteLine("Please choose a number to be guessed: ");
            user_guess = int.Parse(Console.ReadLine());

            if (generated_num > user_guess)
            {
                Console.WriteLine("Higher! ");
            }
            else if (generated_num < user_guess)
            {
                Console.WriteLine("Lower! ");
            }
            else
            {
                Console.WriteLine($"Congrats! You guessed the magic number! It is: {generated_num}");
            }   
        }
    }  
}