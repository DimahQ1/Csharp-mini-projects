using System;
class Program
{
    // Load File And Names Array
    static string[] LoadNames(string path)
    {
        string[] Names = new string[10]; // Just 10 Names 
        try
        {
            if (File.Exists(path))
            {
                return Names = File.ReadAllLines(path);
            }
            Console.WriteLine("File not found!");
            return Names;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
            return Names;
        }

    }
    static void Main()
    {
        // Declare Limits for hint and try
        int counter = 0, maxTry = 3;

        // Path and Names Array
        string path = "D:\\Projects\\C#\\Guessing-name-game\\Names.txt";
        string[] Names = LoadNames(path);

        // Limit for starting game
        if (Names.Count() > 5)
        {
            // Create a random number for select from array
            Random random = new Random();
            string selectedName = Names[random.Next(Names.Count())]; //Selected name to guess

            // Funny sentences 
            Console.WriteLine("Welcome to Guessing Name Game!");
            Console.WriteLine("We have 10 Iranian Names and you have JUST 3 hint!!!");
            Console.WriteLine("So...");
            Thread.Sleep(3000); // short wait to start
            Console.WriteLine("Let's Goooooooo!!!!");

            // Loop for guessing game
            while (true)
            {
                Console.WriteLine("Enter your guess: ");
                string answer = Console.ReadLine();
                if (answer.ToLower() == selectedName.ToLower()) // Make it to lower for finding that name
                {
                    Console.WriteLine("WUHOOOOOO! You Won!");// Find message and break the loop
                    break;
                }
                // Just 3 hint and if you cant find you lose
                if (counter < maxTry)
                {
                    counter++;
                    string hint = selectedName.Substring(0, counter);// Hint

                    Console.WriteLine($"Hint: Its \"{hint}....\"");
                }
                else
                {
                    Console.WriteLine($"Oops You LOST! Correct answer is {selectedName}"); // Lost Message
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Oops! Not enough names to play"); // Not enough Name in text file to start game
        }
        
    }
}