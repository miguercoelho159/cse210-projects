public class Car {

// instances/ variables
public string brand;
public int miles;
public string color;

// constructor
public Car()
{

}

// methods (functions)

public void move_forward()
{
    Console.WriteLine("It's moving");
}

public void displayInfo() 
{
    Console.WriteLine($"Brand: {brand}  |  Miles: {miles}  |  Color: {color}");

}

}
