internal class Program
{
    static void printAll(int[] arr)
    {
        var query = from numb in arr
                    select numb;
        Print(query, "\tArr");
    }
    static void printOdd(int[] arr)
    {
        var query = from numb in arr
                    where numb % 2 == 0
                    select numb;
        Print(query, "\tArr");
    }
    static void printOd1(int[] arr)
    {
        var query = from numb in arr
                    where numb % 2 != 0
                    select numb;
        Print(query, "\tArr");
    }
    static void printBilshe(int[] arr)
    {
        Console.Write("Enter number --> ");
        int num = int.Parse(Console.ReadLine()!);
        var query = from numb in arr
                    where numb > num
                    select numb;
        Print(query, "\tArr");
    }
    static void printDiapazon(int[] arr)
    {
        Console.Write("Enter number (num/num) --> ");
        string[] num = Console.ReadLine()!.Split("/");
        int num1 = int.Parse(num[0]);
        int num2 = int.Parse(num[1]);

        var query = from numb in arr
                    where numb > num1 && numb < num2
                    select numb;
        Print(query, "\tArr");
    }
    static void printSeven(int[] arr)
    {

        var query = from numb in arr
                    where numb % 7 == 0
                    orderby numb  
                    select numb;
        Print(query, "\tArr");
    }
    static void printEight(int[] arr)
    {

        var query = from numb in arr
                    where numb % 8 == 0
                    orderby numb descending
                    select numb;
        Print(query, "\tArr");
    }

    static void printSAll(string[] arr)
    {
        var query = from numb in arr
                    select numb;
        Print(query, "\tArr");
    }
    static void printSsAll(string[] arr)
    {
        Console.Write("Enter number --> ");
        int num = int.Parse(Console.ReadLine()!);
        var query = from numb in arr
                    where numb.Length == num
                    select numb;
        Print(query, "\tArr");
    }
    static void printStart(string[] arr)
    {
        var query = from numb in arr
                    where numb.StartsWith("A")
                    select numb;
        Print(query, "\tArr");
    }
    static void printEnd(string[] arr)
    {
        var query = from numb in arr
                    where numb.EndsWith("M") || numb.EndsWith("m")
                    select numb;
        Print(query, "\tArr");
    }
    static void printStartEnd(string[] arr)
    {
        var query = from numb in arr
                    where numb.StartsWith("N") && numb.EndsWith("K") || numb.StartsWith("N") && numb.EndsWith("k")
                    select numb;
        Print(query, "\tArr");
    }
    static void printStarts(string[] arr)
    {
        var query = from numb in arr
                    where numb.StartsWith("Ne") 
                    orderby numb.Length
                    select numb;
        Print(query, "\tArr");
    }
    private static void Main(string[] args)
    {
        int[] arr = { 1, -45, -8, 6, 3, 5, 10, -14, -12 ,7, 16, -32};
        printAll(arr);
        printOdd(arr);
        printOd1(arr);
        printBilshe(arr);
        printDiapazon(arr);
        printSeven(arr);
        printEight(arr);
        string[] arr1 = { "Newton", "Rivne", "New York", "Warsaw", "Newburg", "Berlin", "Tokio", "Amsterdam" };
        printSAll(arr1);
        printSsAll(arr1 );
        printStart(arr1);
        printEnd(arr1);
        printStartEnd(arr1);
        printStarts(arr1);

    }
    static void Print<T>(IEnumerable<T> query, string text = "")
    {
        Console.WriteLine($"{(text.Length == 0 ? "" : "\n\t")} {text}");
        foreach (T item in query)
        {
            Console.Write($"{item,-10}");
        }
        Console.WriteLine();
    }
}