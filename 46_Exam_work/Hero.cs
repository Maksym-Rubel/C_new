using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_Exam_work
{
    internal class Hero : Unit
    {
        public string Name {  get; set; }

        public Dictionary<string, int> Iventory { get; set; }

        public Hero(string name)
           : base(100, 10, 10)
        {
            Name = name;

            Iventory = new Dictionary<string, int>
        {
            { "wood", 0 },
            { "gold", 0 },
            { "diamonds", 0 }
           


        };
           
        }

        public override void Print()
        {
            Console.WriteLine($"------ You ------");

            Console.WriteLine($"Health {Health}");
            Console.WriteLine($"Strength {Strength}");
            Console.WriteLine($"Agility {Agility}");
            Console.WriteLine($"------ Resurses ------");

            Console.WriteLine($"Wood {Iventory["wood"]}");
            Console.WriteLine($"Gold {Iventory["gold"]}");
            Console.WriteLine($"Diamonds {Iventory["diamonds"]}");


        }



    }
}
