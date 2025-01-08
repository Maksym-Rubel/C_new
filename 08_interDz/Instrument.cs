using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_interDz
{
    public abstract class Instrument
    {

        public string Name { get; set; }

        public Instrument(string name)
        {
            Name = name;
        }

        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();
        public abstract void History();

    }
}
