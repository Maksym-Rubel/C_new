using _06_operatorDZ;
using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        MyVector one = new MyVector(2, 4);
        MyVector two = new MyVector(3, 5);

        Console.WriteLine($"{one} + {two} = {one + two}");
        Console.WriteLine($"{one += two}");

        Console.WriteLine($"{one} - {two} = {one - two}");
        Console.WriteLine($"{one} * {two} = {one * two}");
        Console.WriteLine($"{one} --> {--one}");
        Console.WriteLine($"{one} --> {++one}");
        Console.WriteLine("X : " + one[0]); 
        Console.WriteLine("Y : " + one[1]);






    }
}