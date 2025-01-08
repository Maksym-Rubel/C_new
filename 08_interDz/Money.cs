using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _08_interDz
{
    public class Money
    {
        public int Cila {  get; set; }
        public int Cent { get; set; }

        public void SetMoney(int num1, int num2)
        {
            if(num2 >= 100)
            {
                Cila = num1 + num2 / 100;
                Cent = num2 % 100;
            }
            else
            {
                Cila = num1;
                Cent = num2;
            }
        }
        
        public Money(int num1, int num2)
        {
            SetMoney(num1, num2);
        }

        public void Print()
        {
            Console.WriteLine($"{Cila}.{Cent}");
        }
    }
}
