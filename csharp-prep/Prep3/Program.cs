using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string play_again = "yes";

        while (play_again.ToLower() == "yes") {
            int magic_number = randomGenerator.Next(1, 100);
            int guess = -1;
            int counter = 0;
            
            while (guess != magic_number) {
                Console.Write("What is a number between 1 and 100? ");
                string guessString = Console.ReadLine();
                guess = int.Parse(guessString);
                counter += 1;
                if (guess == magic_number) {
                    Console.WriteLine("Your guess was correct!");
                    Console.WriteLine($"You took {counter} guesses!");
                    Console.WriteLine("Would you like to play again? (Yes/No)");
                    play_again =  Console.ReadLine();
                } else if (guess > magic_number) {
                    Console.WriteLine("Your guess is too high!");
                } else {
                    Console.WriteLine("Your guess is too low!");
                }
            }
        }
    }
}
