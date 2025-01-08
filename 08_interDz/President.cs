using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_interDz
{
    internal class President : Worker
    {
        public President(string name,int age) : base(name,age){ }


        public override void Print()
        {
            Console.WriteLine($"Posada : President");
            Console.WriteLine($"Name   : {Name}");
            Console.WriteLine($"Age    : {Age}");
        }
    }
}
