using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interface
{
    internal class StreamerDuck:Duck, iFly
    {
        public void Fly()
        {
            Console.WriteLine("Streamer duck can not fly");
        }
    }
}
