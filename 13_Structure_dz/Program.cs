using _13_Structure_dz;
using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Vectors vectors = new Vectors(2,2,2);
        Vectors vectors1 = new Vectors(2, 2, 2);


        vectors.Enter();
        vectors1.Enter();
        Console.WriteLine();

        Console.WriteLine();
        vectors.Print();
        Console.WriteLine();

        vectors1.Print();
        Console.WriteLine();
        Console.WriteLine();

        vectors.Mnoz(2);
        vectors.Print();
        Console.WriteLine();

        Vectors res = vectors.Add(vectors, vectors1);
        Vectors res2 = vectors.Min1(vectors, vectors1);
        res.Print();
        Console.WriteLine();

        res2.Print();





    }
}