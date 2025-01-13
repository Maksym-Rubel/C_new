internal class Program
{
    private static void Main(string[] args)
    {
        Action act = () => { Console.WriteLine("Hello from std delagates(Action)"); };
        act += Hello;
        act();
        Action<string,int> act2 = (str,numb) => { Console.WriteLine($"#{numb} :: {str}"); };

        act2("test", 100);
        Console.WriteLine();

        Func<int,int,double> func = (one,two) => (one + two) / 2.0;

        Console.WriteLine($"Func avg :: {func(10,11)}");

        Predicate<string> pred = a => Char.IsUpper(a[0]);

        string wordA = "Program";
        string wordB = "python";
        Console.WriteLine($"Has first uper letter :: {pred(wordA)}");
        Console.WriteLine($"Has first uper letter :: {pred(wordB)}");

        Comparison<string> cmp = (s1,s2) => s1.Length.CompareTo(s2.Length);

        Console.WriteLine(cmp(wordA,wordB));
    }

    static void Hello()
    {
        Console.WriteLine("Hello Action");
    }
}