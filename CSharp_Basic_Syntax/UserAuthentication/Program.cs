using System;

class Program
{
    static void Main()
    {
        // Define constant username and password
        const string CORRECT_USERNAME = "Sravya";
        const string CORRECT_PASSWORD = "Sravya123";

        try
        {
            // Get username from user
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(username))
            {
                throw new Exception("username cannot be empty");
            }

            // Get password from user
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("password cannot be empty");
            }

            // Check if the credentials match
            if (username == CORRECT_USERNAME && password == CORRECT_PASSWORD)
            {
                Console.WriteLine($"Welcome, {username}! You have successfully logged in.");
            }
            else
            {
                Console.WriteLine("Login failed. Please check your username and password.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unhandled Exception:\n{ex.Message}");
        }
    }
}