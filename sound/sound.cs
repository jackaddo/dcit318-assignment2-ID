using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main()
    {
        Animal animalInstance = new Animal();
        Dog dogInstance = new Dog();
        Cat catInstance = new Cat();

        animalInstance.MakeSound();
        dogInstance.MakeSound();
        catInstance.MakeSound();
    }
}
