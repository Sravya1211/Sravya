using System;
using System.Collections.Generic;

// Abstract Base Class //
abstract class Animal
{
    public string Name { get; set; }  //Shorthand Property

    protected Animal(string name)
    {
        Name = name;
    }

    public abstract void MakeSound();

    public virtual void Describe()
    {
        Console.WriteLine($"This is an animal named {Name}.");
    }
}

// Pet Behavior Interface //
interface IPet
{
    void Play();
}

// Derived Dog Class //
class Dog : Animal, IPet
{
    public Dog(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }

    public override void Describe()
    {
        Console.WriteLine($"{Name} is a loyal and friendly dog.");
    }

    public void Play()
    {
        Console.WriteLine($"{Name} is fetching the ball!");
    }
}

// Derived Cat Class //
class Cat : Animal, IPet
{
    public Cat(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }

    public override void Describe()
    {
        Console.WriteLine($"{Name} is a curious and independent cat which likes to eat Fish alot.");
    }

    public void Play()
    {
        Console.WriteLine($"{Name} is chasing a laser pointer!");
    }
}

// Main program //
class Program
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>
        {
            new Dog("Rambo"),
            new Cat("Flint")
        };

        foreach (var animal in animals)
        {
            animal.MakeSound();
            animal.Describe();
            
            if (animal is IPet pet)
            {
                pet.Play();
            }

            Console.WriteLine();
        }
    }
}