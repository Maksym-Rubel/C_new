using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_Exam_work
{
    internal class Unit
    {
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }

        public Unit(int health, int strength, int agility)
         
        {
            Health = health;
            Strength = strength;
            Agility = agility;
        }
        public virtual void Print()
        {
            Console.WriteLine($"------ Unit ------");
            Console.WriteLine($"Health   : {Health}");
            Console.WriteLine($"Strength : {Strength}");
            Console.WriteLine($"Agility  : {Agility}");
        }
    }
}
