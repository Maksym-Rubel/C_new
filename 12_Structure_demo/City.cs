using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Structure_demo
{
    struct City
    {
        const int DefaultPopulation = 10_000;
        const int MaxPopulation = 100_000_000;
        private int population;
        public int Population
        {
            get => population;
            set => population = value <= MaxPopulation ? value : MaxPopulation;
        }

        public string Name { get; set; } = "NoName";

        public City(string name, int population = DefaultPopulation)
        {
            Name = name;

            Population = population;
        }

        public override string ToString()
        {
            return $"Name :: {Name,-10} Population :: {Population,-15}";
        }
    }

}
