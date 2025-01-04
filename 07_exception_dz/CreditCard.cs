using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_exception_dz
{
    internal class CreditCard
    {
        string name;
        string number;
        string expirationDate;
        string cvv;


        public string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("You not enter name");
                name = value;
            }
        }
        public string Number
        {
            get => number;
            set
            {
                if(value.Length != 16)
                    throw new ArgumentException("This not card numer");
                number = value;
            }
        }
        public string CVV
        {
            get => cvv;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 3)
                    throw new ArgumentException("must be 3 digit");
                cvv = value;
            }
        }
        public string ExpirationDate
        {
            get => expirationDate;
            set
            {
                var parts = value.Split('/');
                int month;
                int year;
                int.TryParse(parts[0], out month);
                int.TryParse(parts[1], out year);

                if (month >= 1 & month <= 12)
                    expirationDate = value;
                else
                {
                    throw new ArgumentException("Date must be (mm/yy) ");
                }

            }
        }



        public CreditCard(string name, string number, string expirationDate, string cvv)
        {
            Name = name;
            Number = number;
            ExpirationDate = expirationDate;
            CVV = cvv;
        }
        public override string ToString()
        {
            return $"CreditCard Name = {name}, Number = {number}, ExpirationDate = {expirationDate} , CVV = {cvv}";
        }

    }
}
