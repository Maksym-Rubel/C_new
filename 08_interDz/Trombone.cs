using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_interDz
{
    internal class Trombone : Instrument
    {
        public Trombone(string name) : base(name) { }


        public override void Sound()
        {
            Console.WriteLine("Trombone sound");
        }

        public override void Show()
        {
            Console.WriteLine($"Name : {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"The trombone is a brass instrument");
        }
        public override void History()
        {
            Console.WriteLine($"The trombone emerged in the 15th century and has been used in orchestras");
        }

    }
}
