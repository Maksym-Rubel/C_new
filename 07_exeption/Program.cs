using _07_exeption;

internal class Program
{
    static int DivivdeNumber(int a, int b)
    {
        int result = 0;
        try
        {
            result = a / b;
        }
        catch (DivideByZeroException ex)
        {

            throw;
        }
        return result;
    }
    private static void Main(string[] args)
    {
        //int a, b, result;
        //while (true)
        //{
        //    try
        //    {
        //        Console.WriteLine("Enter two number :: ");
        //        a = int.Parse(Console.ReadLine()!);
        //        b = int.Parse(Console.ReadLine()!);
        //        result = DivivdeNumber(a, b);
        //        Console.WriteLine($"{a} / {b} = {result}");
        //        break;
        //    }
        //    catch (DivideByZeroException ex)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine($"\t {ex.Message}");
        //        Console.WriteLine($"\t {ex.HelpLink}");
        //        Console.WriteLine($"\t {ex.Source}");
        //        Console.WriteLine($"\t {ex.TargetSite}");
        //        foreach (var key in ex.Data.Keys)
        //        {
        //            Console.WriteLine($"{key} --> {ex.Data[key]}");
        //        }
        //        Console.ResetColor();
        //    }
        //    catch(Exception ex)
        //    {
        //        Console.ForegroundColor= ConsoleColor.Red;
        //        Console.WriteLine($"\t Message   :: {ex.Message}");
        //        Console.ResetColor();
        //    }
        //}

        //Product product = new Product();
        //try
        //{
        //    product.Name = "black bread";
        //    product.DateIn = DateTime.Parse("10/12/2024");
        //}
        //catch (BadDateProductException ex)
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine($"\t {ex.Message}");
        //    Console.WriteLine($"\t {ex.errorDate}");
        //    Console.WriteLine($"\t {ex.Source}");
        //    Console.WriteLine($"\t {ex.TargetSite}");
        //}
        //catch (Exception ex)
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine($"\t {ex.Message}");
        //    Console.WriteLine($"\t {ex.HelpLink}");
        //    Console.WriteLine($"\t {ex.Source}");
        //    Console.WriteLine($"\t {ex.TargetSite}");
        //    foreach (var key in ex.Data.Keys)
        //    {
        //        Console.WriteLine($"{key} --> {ex.Data[key]}");
        //    }
        //    Console.ResetColor();
        //}
        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.WriteLine($"Name product :  {product.Name,-15} Date : {product.DateIn}");
        //Console.ResetColor();

        try
        {
            Acount acount = new Acount("rubelmaksum2404@gmail.com","maksum1");
            Console.WriteLine($"All kruto");
        }
        catch (ArgumentException ex)
        {

            Console.WriteLine($"Error: {ex.Message}");
        }
        try
        {
            Acount acount = new Acount("!rubelmaksum2404@gmail.com", "maksum1");
        }
        catch (ArgumentException ex)
        {

            Console.WriteLine($"Error: {ex.Message}");
        }
        try
        {
            Acount acount = new Acount("dru", "maksum1");
        }
        catch (ArgumentException ex)
        {

            Console.WriteLine($"Error: {ex.Message}");
        }
        try
        {
            Acount acount = new Acount("wdwdwad", "maksum1");
        }
        catch (ArgumentException ex)
        {

            Console.WriteLine($"Error: {ex.Message}");
        }
        try
        {
            Acount acount = new Acount("rubelmaksum2404@gmail.com", "maksum");
            Console.WriteLine($"All kruto");
        }
        catch (ArgumentException ex)
        {

            Console.WriteLine($"Error: {ex.Message}");
        }
        try
        {
            Acount acount = new Acount("rubelmaksum2404@gmail.com", "maksumm");
            Console.WriteLine($"All kruto");
        }
        catch (ArgumentException ex)
        {

            Console.WriteLine($"Error: {ex.Message}");
        }

    }
}