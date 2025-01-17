using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList list = new ArrayList() { 41, 2.5, "test", true, ConsoleColor.Red };
        PrintList(list, "Print Array list");

        list.Add("lorem");
        list.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });
        PrintList(list, "Print Array list");


        list.Remove("test");
        list.RemoveAt(0);
        PrintList(list, "Print Array list");

        list.RemoveRange(2, 2);
        PrintList(list, "Print Array list");

        list.Insert(2, "orange");
        PrintList(list, "Print Array list");
        list.TrimToSize();

        Random rnd = new Random();
        for (int i = 0; i < 5; i++)
        {
            list.Add((char)rnd.Next(65,91));
        }
        list.Sort();

        Console.Clear();
        List<string> color = new List<string>()
        {
            "red","green","purple","yellow","gold","magenta"
        };
        PrintList(color, "PrintList");

        color.InsertRange(4, new string[] { "cyan", "pink", "brown" });

        //color.RemoveAll(x => x == "o");
         color.Sort((s1,s2) => s1.CompareTo(s2));
    }
    static void PrintList(IEnumerable list, string text = "")
    {
        Console.WriteLine(text);
        foreach (var item in list)
        {
            Console.WriteLine($"{item,-10}");

        }
        Console.WriteLine();
    }
}