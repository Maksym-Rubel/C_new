using _06_overload_operators;
using System.Runtime.CompilerServices;

internal class Program
{

    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    };
    private static void Main(string[] args)
    {
        //string str = null;
        //int value = null ;
        //Console.WriteLine(str);
        //Console.WriteLine(value);
        //Console.WriteLine(default(string));
        //Console.WriteLine(default(int[]));
        //Console.WriteLine(default(int));
        //Console.WriteLine(default(bool));

        //str = "Lorem ipsum";

        //if(str == null)
        //{
        //    Console.WriteLine("Default text");
        //}
        //else
        //{
        //    Console.WriteLine(str);
        //}

        //Console.WriteLine(str != null ? str : "Default text");
        //str = null;
        //Console.WriteLine(str??"Default text");

        //Person person = new Person() { Name = "Denis" };

        //Person person = null;
        //Console.WriteLine(person.Name??"NoName");

        //Console.WriteLine(str?.Length ?? -1);
        //Console.WriteLine(str?.Replace('m','@'));


        //Nullable<int> value = null;
        //Console.WriteLine(value.GetValueOrDefault());

        //int?number = null;

        //int[] arr = null;
        //Console.WriteLine(arr?[0] ?? -1);

        //arr ??= new int[6] { 1, 2, 3, 4, 5, 6 };
        //Console.WriteLine(arr?[0] ?? -1);

        Fraction one = new Fraction(1,2);
        Fraction two = new Fraction(2,3);

        Console.WriteLine($"One :: {one}; Two :: {two}");
        Console.WriteLine($"{one} + {two} = {one + two}");

        int value = 2;
        

    }
}