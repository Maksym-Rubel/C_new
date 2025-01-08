using _10_Interface_class;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        Array1 arr = new Array1(numbers);


        arr.Show();
        arr.Show("First");



        Console.WriteLine(arr.Max());
        Console.WriteLine(arr.Min());
        Console.WriteLine(arr.Avg());
        Console.WriteLine(arr.Search(7));


    



    }
}