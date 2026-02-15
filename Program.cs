using System;
using System.Collections.Generic;
using System.Linq;
using MyFirstApp;

partial class Program
{   
    static void Main()
    {
       // Start with some initial data
       List<int> numbers = new List<int> { 85, 90, 78, 92, 88 };
       
       Console.WriteLine("=== Student Score System ===");
       Console.WriteLine("Instructions: Enter a score (0-100) or type 's' to Stop and view report.");

       while(true)
        {
            Console.Write("Enter score (or 's' to stop): ");
            string input = Console.ReadLine();

            // Check if the user wants to "push" the stop button
            if (input.ToLower() == "s")
            {
                Console.WriteLine("Stopping input...");
                break;
            }

            if(int.TryParse(input, out int score))
            {
                if(score < 0 || score > 100)
                {
                    Console.WriteLine("Error: Score must be between 0 and 100.");
                    continue;
                }
                numbers.Add(score); // Add valid score to list
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number or 's' to stop.");
            }
        }

        // Generate the final report
        DisplayReport(numbers);
    }

    static void DisplayReport(List<int> scoreList)
    {
        if(scoreList.Count == 0)
        {
            Console.WriteLine("No scores to report."); // Handle empty list
            return;
        }

        // Use Calculator class for logic (Remember to fix the spelling in Calculator.cs!)
        double average = Calculator.GetAverage(scoreList); 
        int maxScore = scoreList.Max();
        int minScore = scoreList.Min();

        Console.WriteLine("\n====================");
        Console.WriteLine("    FINAL REPORT    ");
        Console.WriteLine("====================");
        Console.WriteLine($"Total Records:  {scoreList.Count}");
        Console.WriteLine($"Average Score:  {average:F2}");
        Console.WriteLine($"Highest Score:  {maxScore}");
        Console.WriteLine($"Lowest Score:   {minScore}");
        Console.WriteLine("====================");
    }
}