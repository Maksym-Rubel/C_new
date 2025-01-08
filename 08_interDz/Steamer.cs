using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _08_interDz
{
    internal class Steamer : Device
    {
        public Steamer(string name = "NoName", string brand = "NoBrand")
          : base(name, brand)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Steamer sound");
        }
        public override void Show()
        {
            Console.WriteLine("Steamer");
        }
        public override void Desc()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Brand: {Brand}");


        }
    }
}
