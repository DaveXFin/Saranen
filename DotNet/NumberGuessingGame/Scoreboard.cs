public class Scoreboard
{
    public void DisplayScoreboard()
    {
        string filename = @"C:\Users\David\Desktop\main\Saranen\Scoreboard.txt";
        IEnumerable<string> lines = File.ReadLines(filename);
        int counter = 1;
        foreach (string line in lines)
        {
            string[] parts = line.Split(';');
            int numberOfGuesses = int.Parse(parts[0]);
            string playerName = parts[1];

            Console.WriteLine($"Position: {counter} {playerName} guessed {numberOfGuesses} times");
            counter++;
        }
    }
}