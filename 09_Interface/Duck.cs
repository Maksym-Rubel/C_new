using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interface
{
    internal class Duck : iFly, iMove, iSwim
    {
        public int Weight { get; set; }
        int iFly.Speed => 5;
        int iMove.Speed => 3;
        public void Fly()
        {
            Console.WriteLine($"Duck can fly with {((iFly)this).Speed}");
        }

        public void Move()
        {
            Console.WriteLine($"Duck with weight {Weight} can walk with {((iMove)this).Speed}");
        }
        public void Swim()
        {
            Console.WriteLine($"Duck can swim");
        }
    }
}
