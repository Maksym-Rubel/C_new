using _32_Serialize;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car(111, "Toyota", 2.3);
        Car car_2 = new Car(222, "Ford", 2.6);

        //Console.WriteLine($"Origin car    :: {car}");

        //XmlSerializer xs = new XmlSerializer(typeof(Car));

        //string fname = "../../../car.xml";
        //using (FileStream fs = new FileStream(fname,FileMode.Create))
        //{
        //    xs.Serialize(fs, car);

        //    fs.Position = 0;

        //    Car res = (xs.Deserialize(fs) as Car)!;
        //    Console.WriteLine($"Recovered car :: {res}");
        //}

        string fname = "../../../salon.xml";
        List<Car> salonList = new List<Car>()
        {
            car,
            car_2,
            new Car(33,"BMW",2.9)
        };
        XmlSerializer xs = new XmlSerializer(typeof(List<Car>));
        //using (TextWriter tw = new StreamWriter(fname))
        //{
        //    xs.Serialize(tw, salonList);

        //}
        using(TextReader sr = new StreamReader(fname))
        {
            var listCar = xs.Deserialize(sr) as List<Car>;
            Console.WriteLine($"Recoveres cars :: \n{String.Join<Car>("\n",listCar)}");
        }


    }
}