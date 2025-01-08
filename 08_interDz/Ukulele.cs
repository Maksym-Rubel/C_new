using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_interDz
{
    internal class Ukulele : Instrument
    {

        public Ukulele(string name) : base(name) { }


        public override void Sound()
        {
            Console.WriteLine("Ukulele sound");
        }

        public override void Show()
        {
            Console.WriteLine($"Name : {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"The ukulele is a small, guitar-like instrument with four nylon strings.");
        }
        public override void History()
        {
            Console.WriteLine($"The ukulele originated in Hawaii in the 19th century");
        }

    }
}
