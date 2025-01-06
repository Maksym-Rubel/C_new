using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_interclass
{
    internal class Tiger : Animal
    {
        public Tiger(string name  = "Noname", int age = 1, int weight = 1) 
            : base(name, age, weight)
        {
        }
        public override void Print()
        {
            Console.WriteLine($"Tiger: Name :: {Name} Age :: {Age} Weight :: {Weight}");
        }
        public override void Sleep(int hours)
        {
            Console.WriteLine($"Tiger: sleep {hours} hours");
        }
        public override void Eat(string food)
        {
            Console.WriteLine($"Tiger eat {food}");
        }
        public void Hunt()
        {
            Console.WriteLine($"Tiger: Hunt");
        }
    }
}
