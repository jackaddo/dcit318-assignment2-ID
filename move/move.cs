using System;

// Define an interface called IMovable
interface IMovable
{
    void Move();
}

// Create a class Car that implements IMovable
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Create a class Bicycle that implements IMovable
class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Car and Bicycle
        Car car = new Car();
        Bicycle bicycle = new Bicycle();

        // Call the Move() method on each instance
        car.Move();
        bicycle.Move();
    }
}
