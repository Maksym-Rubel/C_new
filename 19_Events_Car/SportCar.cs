using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Events_Car
{
    internal class SportCar : Car
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public int Speed { get; set; }
        public int Distancecovered { get; set; }

  

        public SportCar(string name, string color, int speed)
        {
            Name = name;
            Color = color;
            Speed = speed;
            Distancecovered = 0;

        }


        public void ride()
        {
            Console.WriteLine("Car ride");
        }

        public void StartRace()
        {
            Console.WriteLine($"{Name} at the starting line");
        }

        public void UpdateProgress()
        {
            Distancecovered += Speed;
            Console.WriteLine($"{Name} discovered {Distancecovered} metres");
        }

        public void Print()
        { 
            Console.WriteLine($"{Name} discovered {Distancecovered} netres");
        }

       
    }
}
