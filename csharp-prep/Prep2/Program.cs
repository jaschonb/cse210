using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user what grade percentage they have
        Console.WriteLine("What is your grade percentage? ");
        string gradePercentString = Console.ReadLine();
        int gradePercent = int.Parse(gradePercentString);

        string letterGrade = "N/A";
        string sign = "";

        // If / else statement to determine letter grade
        if (gradePercent >= 90) {
            letterGrade = "A";
        } else if (gradePercent >= 80 && gradePercent < 90) {
            letterGrade = "B";
        } else if (gradePercent >= 70 && gradePercent < 80) {
            letterGrade = "C";
        } else if (gradePercent >= 60 && gradePercent < 70) {
            letterGrade = "D";
        } else {
            letterGrade = "F";
        }

        // Adds ability to add a "+" or a "-" to the letter grade
        if (gradePercent > 52 && gradePercent < 97) {
            if (gradePercent % 10 >= 7) {
                sign = "+";
            } else if (gradePercent % 10 <= 2) {
                sign = "-";
            } else {
                sign = "";
            }
        }

        // Writes the letter grade
        Console.WriteLine($"Your grade is a(n) {letterGrade}{sign}");

        // Determine if they pass the class
        if (gradePercent >= 70) {
            Console.WriteLine("Congragulations, you passed! ");
        } else {
            Console.WriteLine("Study harder and you'll get it next time! ");
        }
    }
}