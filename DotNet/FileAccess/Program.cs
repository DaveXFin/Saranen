
string filename = @"C:\Users\David\Desktop\main\Saranen\Numbers.txt";

IEnumerable<string> lines = File.ReadLines(filename);

int sum = 0;
foreach (string line in lines)
{
    int number = int.Parse(line);
    sum += number; // adds the value
}
Console.WriteLine("Sum of numbers in the file is: " + sum);