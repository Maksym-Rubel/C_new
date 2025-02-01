using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

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
        Console.WriteLine("------------------ Task 4 -----------------");

        string line = "19**-20**";
        var regex = new Regex(@"^(19|20)\d{2}$");

    
        string[] years = { "1900", "2005", "2099", "2100", "1999", "2015", "2200" };

        foreach (var year in years)
        {
            Console.WriteLine($"{year} --> {regex.IsMatch(year)}");
        }

      
        var text = "977982404 9700083923 938458623 974900493";
   
        var output = Regex.Replace(text, @"\d{9}", m => string.Format("{0:+38-0##-##-##-###}", Convert.ToInt64(m.Value)));
        Console.WriteLine(text);
        Console.WriteLine(output);

        string pattern = @"\+38-0\d{2}-\d{2}-\d*00-\d{3}|\+38-0\d{2}-\d*00-\d{2}-\d{3}|\+38-0\d{2}-\d{2}-\d{2}-\d{1}\d*23";
        

        MatchCollection matches = Regex.Matches(output, pattern);
        List<string> foundNumbers = new List<string>();
        foreach (Match match in matches)
        {
            foundNumbers.Add(match.Value);
        }
        Console.WriteLine("Знайдені номери:");
        foreach (string number in foundNumbers)
        {
            Console.WriteLine(number);
        }
    }
} 