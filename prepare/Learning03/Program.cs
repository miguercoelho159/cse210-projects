using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction firstFraction = new Fraction();

        Console.WriteLine(firstFraction.GetFractionString());
        Console.Write(firstFraction.GetDecimalValue());


        Fraction secondFraction = new Fraction(5);

        Console.WriteLine(secondFraction.GetFractionString());
        Console.Write(secondFraction.GetDecimalValue());


        Fraction thirdFraction = new Fraction(3, 4);

        Console.WriteLine(thirdFraction.GetFractionString());
        Console.Write(thirdFraction.GetDecimalValue());


        Fraction fourthFraction = new Fraction(1, 3);

        Console.WriteLine(fourthFraction.GetFractionString());
        Console.Write(fourthFraction.GetDecimalValue());
        
    }
}