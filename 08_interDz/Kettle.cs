using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_interDz
{
    internal class Kettle : Device
    {

        public Kettle(string name = "NoName", string brand = "NoBrand") 
            : base(name, brand) 
        {
            
        }

        public override void Sound()
        {
            Console.WriteLine("Kettle sound");
        }
        public override void Show()
        {   
            Console.WriteLine("Kettle");
        }
        public override void Desc()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Brand: {Brand}");


        }
    }
}
