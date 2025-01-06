using _08_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        TV tv = new TV("LG");
        Smartphone smartphone = new Smartphone("Nokia");
        tv.Print();
        smartphone.Print();

        Device[] dec = new Device[] { tv,smartphone};
        foreach (Device d in dec)
        {
            d.Print();
        }
    }
}