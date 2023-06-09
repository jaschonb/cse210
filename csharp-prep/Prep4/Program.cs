using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        string numberString = "";
        List<float> numbers = new List<float>();
        float sum = 0;
        float largestNum = 0;
        float smallestNum = 999999999;

        // Ask the user for a list of numbers and add them to a list
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (numberString != "0") {
            Console.Write("Enter number: ");
            numberString = Console.ReadLine();

            if (numberString != "0") {
                numbers.Add(float.Parse(numberString));
            }
        }

        // Go through the list of numbers and sum it up and find the largest number
        for (int i = 0; i < numbers.Count; i++) {
            sum += numbers[i];
            if (numbers[i] > largestNum) {
                largestNum = numbers[i];
            }
            if (numbers[i] < smallestNum && numbers[i] > 0) {
                smallestNum = numbers[i];
            }
        }

        // Output the deliverables
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / numbers.Count()}");
        Console.WriteLine($"The largest number is: {largestNum}");
        Console.WriteLine($"The smallest positive number is: {smallestNum}");
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (float number in numbers) {
            Console.WriteLine(number);
        }

    }
}