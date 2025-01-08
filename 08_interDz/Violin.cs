using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_interDz
{
    internal class Violin : Instrument
    {
        public Violin(string name) : base(name) { }


        public override void Sound()
        {
            Console.WriteLine("Violin sound");
        }

        public override void Show()
        {
            Console.WriteLine($"Name : {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"The violin is a string instrument with four strings");
        }
        public override void History()
        {
            Console.WriteLine($"The violin originated in 16th-century Italy");
        }

    }
}
