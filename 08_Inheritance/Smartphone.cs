using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance
{
    internal class Smartphone : Device
    {
        public bool HasBattery { get; set; } = true;
        public Smartphone(string brand = "Nobrand", int year = 2000, bool battery = true)
            : base(brand, year)
        {
            HasBattery = battery;
        }
        public override void Print()
        {
            Console.WriteLine($"{this.GetType().Name,-10} Brand :: {brand,-10} Year :: {Year,-10} Weight :: {Weight,-10} Price :: {Price,-10} Battery :: {HasBattery,-10}");


        }
        public void Call()
        {
            Console.WriteLine($"\n\t\t Method Call work");

        }
    }
}
