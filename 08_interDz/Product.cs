using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_interDz
{
    internal class Product
    { 
        public string Name { get; set; }
        public Money Price { get; set; }




        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }
        public void MinusPrice(int mnum1, int mnum2)
        {
            int totalCurrent = Price.Cila * 100 + Price.Cent;
            int totalMinus = mnum1 * 100 + mnum2;


            if (totalMinus > totalCurrent)
            {
                Console.WriteLine("Minus > ceny");
                Price.SetMoney(0, 0);
            }
            else
            {
                int totalNew = totalCurrent - totalMinus;
                Price.SetMoney(totalNew/100,totalNew%100);
            }
            
        }

        public void Print()
        {
            Console.WriteLine($"Product: {Name}");
            Console.Write("Price: ");
            Price.Print();
        }

    }
}
