using _12_Structure_demo;

internal class Program
{
    private static void Main(string[] args)
    {
        City city = new City();
        Console.WriteLine(city);

        City rivne = new City("Rivne",240_451);
        Console.WriteLine(rivne);

        City clone = rivne;

    }
}