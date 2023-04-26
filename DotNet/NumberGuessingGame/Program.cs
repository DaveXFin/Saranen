// coded along with Jani Järvinen

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the Number Guessing Game!");



// Generates a random number between 1 and 20
int correct = Random.Shared.Next(1, 21);
Console.WriteLine(correct);



//for loop to tracks the number fo guesses
for (int index = 0; index < 3; index++)
{
    //Asks player to guess a number
    Console.WriteLine("Please enter your guess between 1 and 20:");
    string guessValue = Console.ReadLine();
    int guess = int.Parse(guessValue);
    
    //checks the players guess with the generated value
    if (guess == correct)
    {
        Console.WriteLine("You guessed the correct value! You win the Game!");
        break;

    }
    else if (guess < correct)
    {
        Console.WriteLine("The correct number is larger.");
        
    }
    else
    {
        Console.WriteLine("The correct number is smaller.");
        
    }
}

Console.WriteLine("Game ended");

//Displays high score
Scoreboard HighScore = new();

HighScore.DisplayScoreboard();