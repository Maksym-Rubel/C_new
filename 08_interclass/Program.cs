using _08_interclass;

internal class Program
{
    private static void Main(string[] args)
    {
        Tiger tg = new Tiger("Cot",10,112);
        tg.Print();
        tg.Sleep(4);
        Console.WriteLine();
        Console.WriteLine();
        Сrocodile cr = new Сrocodile("Perry",8,76);
        Kangaroo kg = new Kangaroo("Kang", 5,43);
        Animal[] an = new Animal[] { tg, cr, kg };
        foreach (Animal an1 in an)
        {
            an1.Print();
            if (an1 is Tiger)
            {
                (an1 as Tiger)?.Hunt();
            }
            if (an1 is Kangaroo)
            {
                (an1 as Kangaroo)?.Run();
            }
            if (an1 is Сrocodile)
            {
                (an1 as Сrocodile)?.Hunt();
            }

        }
        Console.WriteLine();
        cr.Eat("meat");
    }
}