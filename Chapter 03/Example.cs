class ControlStructures
{
    public static void Main()
    {
        // Create an instance of the Random class to generate random numbers
        Random randomNums = new Random();

        // Generate a random number between 1 and 10
        int randomguess = randomNums.Next(1, 11);

        // Variable to store the user's guess initialized to 0
        int GuessbyUser = 0;

        // Inform the user about the game
        Console.WriteLine("This is a Number Guessing Game");
        Console.WriteLine("I chose a number between 1 and 10. Can you identify it?");

        // Loop until the user guesses the correct number
        while (GuessbyUser != randomguess)
        {
            // Prompt the user to enter their guess
            Console.Write("What is your guess? ");

            // Read the user's input
            string? enter = Console.ReadLine();

            // Try to parse the user's input to an integer
            if (int.TryParse(enter, out GuessbyUser))
            {
                // Check if the user's guess is lower than the random number
                if (GuessbyUser < randomguess)
                {
                    Console.WriteLine("Lower than mine! Guess again");
                }
                // Check if the user's guess is higher than the random number
                else if (GuessbyUser > randomguess)
                {
                    Console.WriteLine("Higher than mine! Guess again");
                }
                // If the user's guess is correct
                else
                {
                    Console.WriteLine("Great! You got the number");
                }
            }
            // If the user's input is not a valid number
            else
            {
                Console.WriteLine("Your guess must be between 1 and 10");
            }
        }
    }
}
