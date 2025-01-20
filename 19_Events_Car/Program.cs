using _19_Events_Car;

internal class Program
{
    private static void Main(string[] args)
    {
        Game race = new Game();

        race.AddCar(new Cars("Easy car"));
        race.AddCar(new SportCar("SportCar"));
        race.AddCar(new Truck("Truck"));
        race.AddCar(new Bus("Bus"));

        Console.WriteLine("Rice start");
        race.Start();

    }
}