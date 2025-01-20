using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Events_Car
{
    abstract class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Position { get; set; }
        public event Action<string> Finished;

        protected Random random = new Random();

        public Car(string name)
        {
            Name = name;
            Position = 0;
        }

        public void Drive()
        {
            Speed = random.Next(5, 15);
            Position += Speed;
            Console.WriteLine($"{Name} Speed : {Speed}, Position: {Position}");
           

            if (Position >= 100)
            {
                Finished?.Invoke(Name);
            }
        }
    }

}
