using _08_interDz;

internal class Program
{
    private static void Main(string[] args)
    {
        Money m = new Money(20,350);
        Product moloko = new Product("Молоко",m);
        moloko.Print();
        moloko.MinusPrice(3, 50);
        moloko.Print();
        moloko.MinusPrice(30, 554);


        Car car = new Car("BMW", "BMW");
        car.Show();
        car.Desc();
        Console.WriteLine();
        Console.WriteLine();

        Violin violin = new Violin("Violin");
        Trombone trombone = new Trombone("Trombone");
        violin.Show();
        violin.Sound();
        violin.Desc();
        violin.History();
        Console.WriteLine();
        trombone.Show();
        trombone.Sound();
        trombone.Desc();
        trombone.History();



        Console.WriteLine();

        Security sec = new Security("Tom", 29);
        Manager men = new Manager("Yura", 35);

        sec.Print();
        men.Print();

    }
}