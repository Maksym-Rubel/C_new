using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> dic = new Dictionary<string, string>()
        {
            ["Hello"] = "привіт",
            ["bye"] = "бувай",
            ["program"] = "програма",
            ["developer"] = "розробник"
        };
        Console.OutputEncoding = Encoding.UTF8;
        foreach (var key in dic)
        {
            Console.WriteLine($"{key.Key, -10} {key.Value}");
        }


        SortedDictionary<string, string> sortdic = new SortedDictionary<string, string>()
        {
            ["Hello"] = "привіт",
            ["bye"] = "бувай",
            ["program"] = "програма",
            ["developer"] = "розробник"
        };

    }
}