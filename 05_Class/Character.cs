using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Class
{
    internal class Character
    {
        private string name = "NoName";
        private uint hp = 100;

        public string Name {
            //get
            //{
            //    return name;
            //}
            get => name;
            set
            {
                //if (value.Length == 0)
                //{
                //    name = "Test";
                //}
                //else
                //{
                //    name = value;
                //}
                if(!String.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
            }
        }

        public uint Damage { get; set; }

        public Character(string name, uint hp ,uint damage)
        {
            Name = name;
            this.hp = hp;
            Damage = damage;
            
            
        }
        public Character(string name = "None")
            : this(name, 100, 5)
        { }
        public void Print()
        {
            Console.WriteLine($"Character name    :: {Name}");
            Console.WriteLine($"Character hp      :: {hp}");
            Console.WriteLine($"Character damage  :: {Damage}");

        }

        public uint KPD { get => Damage * hp; }

        public override string ToString()
        {
            return $"Name :: {Name,-10} HP :: {hp,-10} Damage :: {Damage,-10} KPD :: {KPD}";
        }
        public uint Hp { get; set; }
    }
}
