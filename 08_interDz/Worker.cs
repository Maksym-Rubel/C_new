using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_interDz
{
    public abstract class Worker
    {

        public string Name { get; set; }
        public int Age { get; set; }

        public Worker(string name,int age)
        {
            Name = name;
            Age = age;
        }
        public abstract void Print();

    }
}
