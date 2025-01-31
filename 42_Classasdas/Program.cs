using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("------------------ Task 1 -----------------");
        string[] arr = new[] { "112031", "3123", "123123", "123213", "1231" };

        foreach (string str in arr)
        {
            Match match = Regex.Match(str, @"\b\d{4}\b");

            while (match.Success)
            {
                Console.WriteLine($"Value: {match.Value}, Length: {match.Length}");
                match = match.NextMatch(); 
            }
        }
        Console.WriteLine("------------------ Task 2 -----------------");

        string[] arr1 = new[] { "asd123zxc456", "sda231ss123", "dsads2312dsda", "bnm567hjk890", "231dwad231" };

        foreach (string str in arr1)
        {
            Match match = Regex.Match(str, @"\b\D{3}\d{3}\D{3}\d{3}\b");

            while (match.Success)
            {
                Console.WriteLine($"Value: {match.Value}, Length: {match.Length}");
                match = match.NextMatch();
            }
        }
        Console.WriteLine("------------------ Task 3 -----------------");

        string[] arr2 = new[] { "WWW", "PDF", "Bmp", "BMP", "pdf" };

        foreach (string str in arr2)
        {
            Match match = Regex.Match(str, @"\b[A-Z]{3}\b");

            while (match.Success)
            {
                Console.WriteLine($"Value: {match.Value}, Length: {match.Length}");
                match = match.NextMatch();
            }
        }
    }
}