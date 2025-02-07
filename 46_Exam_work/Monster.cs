using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_Exam_work
{
    internal class Monster : Unit
    {
      

  

        public Monster(int health,int strength, int agility )
            :base(health, strength, agility) { }
  
        public override void Print()
        {
            Console.WriteLine($"------ Monster ------");

            Console.WriteLine($"Health {Health}");
            Console.WriteLine($"Strength {Strength}");
            Console.WriteLine($"Agility {Agility}");
        }
    }
}
