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



        Console.WriteLine(arr.Less(3));
        Console.WriteLine(arr.Greater(3));

        arr.ShowEven();
        arr.ShowOdd();


        Console.WriteLine(arr.CountDistinct());
        Console.WriteLine(arr.EqualToValue(3));






    }
}