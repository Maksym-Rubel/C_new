using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Events
{
    internal class Interviwer
    {
        public string Name { get; set; }
        //public void Dosomething(string desc)
        //{
        //    Console.WriteLine($"Interviwer {Name} notified about {desc}");
        //}
        public void Dosomething(object sender, MyArgs args)
        {
            Console.WriteLine($"Interviwer {Name} notified about {args.Description} Date :: {args.Date} from Company {args.CompanyName} ");
        }
    }
}
