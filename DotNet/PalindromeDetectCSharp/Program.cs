// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter a string:");

string input = Console.ReadLine();


// method 1
string reversed ="";
for (int index = input.Length - 1; index >= 0 ; index--)
{
    reversed += input[index];
}

Console.WriteLine(reversed);

// compare the input to the reversed string
bool isPalindrome = (input == reversed);

if (isPalindrome)
{
    Console.WriteLine("The Input is a palindrome");
}
else
{   
    Console.WriteLine("The input is not a palindrome");
}