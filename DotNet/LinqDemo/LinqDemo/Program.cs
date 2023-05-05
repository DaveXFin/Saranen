using System.Runtime.InteropServices;

int[] numbers = { 4, 56, 2, 24, 5, 23, 95, 75 };

Array.Sort(numbers);

foreach (var number in numbers)
{
    if (number > 20)
    {
        Console.WriteLine(number);
    }
}

// LINQ query approach using the previous logic
var results = from n in numbers
              where n > 20
              select n;
foreach (var number in results)
{
    Console.WriteLine(number);
}