using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _08_interDz
{
    internal class Car : Device
    {
        public Car(string name = "NoName", string brand = "NoBrand")
           : base(name, brand)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Car sound");
        }
        public override void Show()
        {
            Console.WriteLine("Car");
        }
        public override void Desc()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Brand: {Brand}");


        }
    }
}
