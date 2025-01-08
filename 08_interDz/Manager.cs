using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _08_interDz
{
    internal class Manager : Worker
    {
        public Manager(string name, int age) : base(name, age) { }


        public override void Print()
        {
            Console.WriteLine($"Posada : Manager");
            Console.WriteLine($"Name   : {Name}");
            Console.WriteLine($"Age    : {Age}");
        }
    }
}
