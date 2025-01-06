using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_interclass
{
    public abstract class Animal
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public Animal(string name = "NoName", int age = 1, int weight = 1)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public abstract void Print();
        public abstract void Sleep(int hours);
        public abstract void Eat(string food);


    }
}
