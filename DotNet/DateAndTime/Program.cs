// using System.Globalization;


// Console.WriteLine("Welcome to Date and time application");

// // Asks user for the first date
// Console.WriteLine("Enter a date and time (mm/dd/yyyy hh:mm:ss)");
// string firstDateInput = Console.ReadLine();


// // Asks user for the second date
// Console.WriteLine("Enter another date and time (mm/dd/yyyy hh:mm:ss)");
// string secondDateInput = Console.ReadLine();


DateReader reader = new();
DateTime date1 = reader.ReadADate();
DateTime date2 = reader.ReadADate();


Console.WriteLine(date1);
Console.WriteLine(date2);

TimeSpan diff = date2 - date1;
Console.WriteLine(diff);

int days = diff.Days;
int hours = diff.Hours;
int min = diff.Minutes;

string dateDiff = $"Date difference is {days} day(s)" + $"{hours} hours(s) and {min} minute(s).";

Console.WriteLine(dateDiff);

Console.WriteLine("Total difference in hours: " + diff.TotalHours);