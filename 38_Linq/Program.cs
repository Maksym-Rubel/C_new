internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 1, -45, -8, 6, 3, 5, 10, -14, -12 };

        Print(arr, "Print array origin");
        IEnumerable<int> query = from numb in arr
                                 select numb * -1;

        List<int> ints = query.ToList();
        Print(ints, "Teset select");

        query = arr.Select(ConvertData);
        Print(query, "Teset select");
        query = arr.Select(delegate (int item) { return item * 2; });
        Print(query, "Teset select");
        query = arr.Select(item => item/2);
        Print(query, "Teset select");

        query = from numb in arr
                where numb % 2 == 0
                select numb;
        Print(query, "Teset select");


        query = arr.Where(arr => arr % 2 != 0).Select(x => (int)Math.Pow(x,2));
        Print(query, "Teset select");


        string[] colors = { "red", "pink", "violet", "purple", "lime", "gold", "brown", "black" };
        var res = from c in colors
                  where c.Length == 4
                  select c;
        Print(res, "Teset select");

        res = colors.Where(c => c.Length == 4);
        Print(res, "Teset select");
        Console.WriteLine($"Color with max length {colors.Max(x => x.Length)}");


        res = from c in colors
              where c.Contains('a')
              select c;
        Print(res, "Teset select");


    }

    static void Print<T>(IEnumerable<T> query, string text = "")
    {
        Console.WriteLine($"{(text.Length == 0 ? "" : "\n\t")} {text}");
        foreach (T item in query)
        {
            Console.Write($"{item,-7}");
        }
        Console.WriteLine();
    }
    static int ConvertData(int value)
    {
        return (int)Math.Pow(value, 2);
    }
}