using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _08_interclass
{
    internal class Сrocodile : Animal
    {
        public Сrocodile(string name = "Noname", int age = 1, int weight = 1)
           : base(name, age, weight)
        {
        }
        public override void Print()
        {
            Console.WriteLine($"Сrocodile: Name :: {Name} Age :: {Age} Weight :: {Weight}");
        }
        public override void Sleep(int hours)
        {
            Console.WriteLine($"Сrocodile: sleep {hours} hours");
        }
        public override void Eat(string food)
        {
            Console.WriteLine($"Сrocodile eat {food}");
        }
        public void Hunt()
        {
            Console.WriteLine($"Сrocodile: Hunt");
        }
    }
}
