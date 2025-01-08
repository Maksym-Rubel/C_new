using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _08_interDz
{
    internal class Cello : Instrument
    {
        public Cello(string name) : base(name) { }


        public override void Sound()
        {
            Console.WriteLine("Cello sound");
        }

        public override void Show()
        {
            Console.WriteLine($"Name : {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"The cello is a large string instrument");
        }
        public override void History()
        {
            Console.WriteLine($"The cello evolved in the 16th century and is a key instrument in the symphony orchestra");
        }
    }
}
