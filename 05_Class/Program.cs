using _05_Class;

internal class Program
{
    static class AreaShepes
    {
        const double PI = 3.14;
        public static double TrianArea(double height, double side)
        {
            return 0.5 * height * side;

        }
        public static double CircleArea(double radius)
        {
            return PI * Math.Pow(radius, 2);
        }
    }
    private static void Main(string[] args)
    {
        //Character character = new Character("Elf",100,10);
        //character.Print();
        //Console.WriteLine(character);
        //Character ch_2 = new Character(damage: 15, name: "Mag", hp: 150);
        //ch_2.Name = "Kind Elf";
        //Console.WriteLine(ch_2);

        //Character ch_3 = new Character() { Name = "Ranger", Damage = 10, Hp = 100 };
        //Console.WriteLine(ch_3);

        //Console.WriteLine("Main started .....");
        //Console.WriteLine($"Last id :: {Employee.LastId}");
        //Employee employee = new Employee() { Namel = "Denis", Birth = DateTime.Parse("30/10/2000")};
        //Console.WriteLine(employee);
        //Console.WriteLine($"Age :: {employee.Age}");

        //Employee employee2 = new Employee()
        //{
        //    Namel = "Ivan",
        //    Birth = new DateTime(2005, 12, 29),
        //    Position = Position.QA,
        //};
        //Console.WriteLine(employee2);
        //Console.WriteLine($"Age :: {employee2.Age}");

        //Console.WriteLine($"Same position {Employee.SamePosition(employee,employee2)}");
        //Console.WriteLine($"Last id :: {Employee.LastId}");


        //Console.WriteLine(AreaShepes.TrianArea(10,15));


        City Rivne = new City("Rivne", "Ukraine", 200000, 380, "Rivnenskiy");
     

        Rivne.PrintCity();
        Rivne.NameCity = "Lviv";
        Console.WriteLine();
        Rivne.PrintCity();
        Rivne.EnterCIty();
        Rivne.PrintCity();
        Console.WriteLine();
        Console.WriteLine();


        Spivrob Maksym = new Spivrob("Rubel Maksym Volodymyrovych","rubelmaksum2404gmail.com","Programist","Programiruvaty",0977982404,new DateTime(2009,04,24));

        Maksym.PrintEmp();
        Maksym.EnterSpivrob();
        Console.WriteLine();

        Maksym.PrintEmp();


    }
}