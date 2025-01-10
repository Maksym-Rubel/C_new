using _13_structure;

internal class Program
{
    private static void Main(string[] args)
    {
        Fraction a = new Fraction(1,2);
        Fraction b = new Fraction(3,4);


        Console.WriteLine(a);
        Console.WriteLine(b);

        Fraction sum = Fraction.Add(a, b);
        Console.WriteLine("Sum -> " + sum);

        Fraction Sub = Fraction.Substract(a, b);
        Console.WriteLine("Minus -> " + Sub);

        Fraction Mnoz = Fraction.Mnoz(a, b);
        Console.WriteLine("Mnozenia -> " + Mnoz);

        Fraction Dil = Fraction.Dilenia(a, b);
        Console.WriteLine("Dilenia -> " + Dil);



    }
}