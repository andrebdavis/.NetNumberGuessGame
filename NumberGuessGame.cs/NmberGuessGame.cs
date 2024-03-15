using System;
class Program
{
    static void Main()
    {
        //Generte a random number between 1 and 100
        Random random = new Random();
        int randomNumber = random.Next(1, 100);

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("Ive picked a random number between 1 and 100. Try to guess it!");

    }

    }
