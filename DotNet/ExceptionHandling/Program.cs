/*
    Programmed along with Jani Järvinen 
    Goal: to learn how to deal with Exception handling 
    using try and catch functions.
*/




try
{
    Console.WriteLine("Enter number 1:");
    decimal number1 = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Enter number 2:");
    decimal number2 = decimal.Parse(Console.ReadLine());

    decimal result = number1 / number2;
    Console.WriteLine(result);
}
catch (DivideByZeroException) // handles the DividebyZeroException
{
    Console.WriteLine("Cannot divide by zero. Please try again.");
}
catch (FormatException) // handles the FormatException
{
    Console.WriteLine("Invalid number entered. Please enter valid decimal numbers.");
}
catch (Exception ex)    // handles the other exceptions as unexpected
{
    Console.WriteLine("An unexpected error occurred! " + ex.Message);
}