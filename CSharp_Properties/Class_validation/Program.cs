using System;

class Person
{
    public string Name { get; set; }
    
    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age must be a positive number.");
            }
            age = value;
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            
            Person person = new Person { Name = name, Age = age };
            
            Console.WriteLine($"Name: {person.Name} Age: {person.Age}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid integer for age.");
        }
    }
}
