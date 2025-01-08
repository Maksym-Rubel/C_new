using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_interDz
{
    public abstract class Device
    {
        public string Name { get; set; }
        public string Brand { get; set; }

        public Device(string name = "NoName", string brand = "NoBrand")
        {
            Brand = brand;
            Name = name;
        }

        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();

    }
}
