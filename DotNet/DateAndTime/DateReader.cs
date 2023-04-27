public class DateReader
{
    
    public DateTime ReadADate()
    {
        DateTime dateValue = default;
        while(true)
        {
            Console.WriteLine("Please enter a date:");
            string input = Console.ReadLine();
            
            try
            {
                dateValue = DateTime.Parse(input);
                break;
            }
            catch
            {
                Console.WriteLine("The you entered was invalid. Use format mm/dd/yyyy");
            }
        }
        return dateValue;
    }
}