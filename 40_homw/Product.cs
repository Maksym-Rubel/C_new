using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_homw
{
    internal class Product
    {
        public enum CategoryFood { Vegetables = 1, Fruit, Sweet, Salty }
        public string Name { get; set; }
 

        public CategoryFood Category { get; set; }

        public ushort Year { get; set; }

        public float Price { get; set; }

        public override string ToString()
        {
            return $"{Name,-20}{Year,-6}{Category.ToString(),-10}{Price,-6}";
        }

    }
}
