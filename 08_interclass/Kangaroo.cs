using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _08_interclass
{
    internal class Kangaroo : Animal
    {

        public Kangaroo(string name = "Noname", int age = 1, int weight = 1)
         : base(name, age, weight)
        {
        }
        public override void Print()
        {
            Console.WriteLine($"Kangaroo: Name :: {Name} Age :: {Age} Weight :: {Weight}");
        }
        public override void Sleep(int hours)
        {
            Console.WriteLine($"Kangaroo: sleep {hours} hours");
        }
        public void Run()
        {
            Console.WriteLine($"Kangaroo: Run");
        }
        public override void Eat(string food)
        {
            Console.WriteLine($"Kangaroo eat {food}");
        }
    }
}
