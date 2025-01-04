using _07_exception_dz;

internal class Program
{
    private static void Main(string[] args)
    {
        
        
        try
        {
            CreditCard acount = new CreditCard("Maks", "4441114432081048", "04/28", "388");
            Console.WriteLine(acount);
        }
        catch (ArgumentException ex)
        {

            Console.WriteLine($"Error: {ex.Message}");
        }

        try
        {
            CreditCard acount = new CreditCard(" ", "4441114432081048", "04/28", "388");
            Console.WriteLine(acount);
        }
        catch (ArgumentException ex)
        {

            Console.WriteLine($"Error: {ex.Message}");
        }

        try
        {
            CreditCard acount = new CreditCard("Maks", "44448", "04/28", "388");
            Console.WriteLine(acount);
        }
        catch (ArgumentException ex)
        {

            Console.WriteLine($"Error: {ex.Message}");
        }

        try
        {
            CreditCard acount = new CreditCard("Maks", "4441114432081048", "15/28", "388");
            Console.WriteLine(acount);
        }
        catch (ArgumentException ex)
        {

            Console.WriteLine($"Error: {ex.Message}");
        }
        try
        {
            CreditCard acount = new CreditCard("Maks", "4441114432081048", "04/28", " ");
            Console.WriteLine(acount);
        }
        catch (ArgumentException ex)
        {

            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}