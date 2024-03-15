using System;
class Program
{
    static void Main(string[] args)
    {
        // Generte a random number between 1 and 100
        Random random = new Random();
        int randomNumber = random.Next(1, 100);

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("Ive picked a random number between 1 and 100. Try to guess it!");

        int guess = 0;

        // Loop until the player guesses the correct number 
        while (guess != randomNumber)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            // Validate user input
            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer ");
                continue; // loop to propmt the user again

            }
            else if (guess > randomNumber)
            {
                
            }


        }
    }
}