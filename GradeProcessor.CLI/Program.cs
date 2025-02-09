// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

Console.WriteLine("Welcome to the Grade Processor!");
List<int> grades = new List<int>();

// Input grades
Console.WriteLine("Enter grades one by one (type 'done' to finish):");
while (true)
{
    Console.Write("Enter grade: ");
    string input = Console.ReadLine();
    if (input.ToLower() == "done") break;

    if (int.TryParse(input, out int grade) && grade >= 0 && grade <= 100)
    {
        grades.Add(grade);
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid grade (0-100).");
    }
}

if (grades.Count == 0)
{
    Console.WriteLine("No grades entered. Exiting program.");
    return;
}

// Process Grades
try
{
    double average = GradeProcessor.Core.GradeProcessor.CalculateAverage(grades);
    int maxGrade = GradeProcessor.Core.GradeProcessor.CalculateMaxGrade(grades);
    double median = GradeProcessor.Core.GradeProcessor.CalculateMedianGrade(grades);

    Console.WriteLine("\nGrade Summary:");
    Console.WriteLine($"Maximum Grade: {maxGrade}");
    Console.WriteLine($"Median Grade: {median}");
    Console.WriteLine($"Average Grade: {average:F2}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
