//using _32_Serialize;
//using Newtonsoft.Json;
//using System.Text.Json;
//using System.Text.Json.Serialization;

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Car car = new Car(111, "Toyota", 2.3);
//        Car car_2 = new Car(222, "Ford", 2.6);

//        //string fname_1 = "../../../car.json";

//        //string json = JsonSerializer.Serialize<Car>(car);
//        //File.WriteAllText(fname_1, json);
        
//        //Car res = JsonSerializer.Deserialize<Car>(File.ReadAllText(fname_1))!;


//        string fname_2 = "../../../salon.json";
//        //List<Car> salonList = new List<Car>()
//        //{
//        //    car,
//        //    car_2,
//        //    new Car(33,"BMW",2.9)
//        //};



//        //string json = JsonSerializer.Serialize<List<Car>>(salonList);
//        //File.WriteAllText(fname_2, json);

//        //string json1 = JsonConvert.SerializeObject(car);
//        //List<Car> res = JsonSerializer.Deserialize<List<Car>>(File.ReadAllText(fname_2))!;

//        //Console.WriteLine(String.Join("\n", res));
//        Dictionary<int,Car> salonList = new Dictionary<int,Car>()
//        {
//            [car.id] = car,
//            [car.id] = car_2,
//            [car.id] = new Car(33,"BMW",2.9)
//        };



//        string json = JsonSerializer.Serialize<Dictionary<int, Car>>(salonList);
//        File.WriteAllText(fname_2, json);

//        Dictionary<int,Car> res = JsonSerializer.Deserialize<Dictionary<int, Car>>(File.ReadAllText(fname_2))!;

//        foreach(var item in res)
//        {
//            item.Value.id = item.Key;
//            Console.WriteLine(item.Value);
//        }
//    }
//}