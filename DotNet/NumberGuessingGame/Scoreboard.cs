// Coded along with Jani Järvinen
public class Scoreboard
{
    //Retrieves the csv file.
    const string HighScoreFilename =@"C:\Users\David\Desktop\main\Saranen\DotNet\NumberGuessingGame\Scoreboard.csv";
    
    
    public void RecordPlayerScore(int numberOfGuesses)
    {
        Console.WriteLine("Please enter your name for new score:");

        string playerName = Console.ReadLine();

        string csvLine = numberOfGuesses  + ";" + playerName + System.Environment.NewLine;
        
        File.AppendAllText(HighScoreFilename, csvLine);

    }
    
    // Displays the score in ordered list
    public void DisplayScoreboard()
    {
        
        string[] lines = File.ReadAllLines(HighScoreFilename);
        Array.Sort(lines); 

        int counter = 1;
        
        foreach (string line in lines)
        {
            string[] parts = line.Split(';');
            int numberOfGuesses = int.Parse(parts[0]);
            string playerName = parts[1];

            Console.WriteLine($"Position {counter}: {playerName}, guessed: {numberOfGuesses} times");
            counter++;
        }
    }
}