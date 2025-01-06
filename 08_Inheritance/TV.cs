using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance
{
    internal class TV : Device
    {
        public int Diagonal { get; set; } = 42;
        public TV(string brand = "Nobrand", int year = 2000, int diagonal = 42)
            :base(brand, year)
        {
            Diagonal = diagonal;
        }
        public override void Print()
        {
            Console.WriteLine($"{this.GetType().Name,-10} Brand :: {brand,-10} Year :: {Year,-10} Weight :: {Weight,-10} Price :: {Price,-10} Diagonal :: {Diagonal,-10}");
        

        }
        public void NextChannel()
        {
            Console.WriteLine($"\n\t\t Method nextChannel work");

        }
    }
}
