using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_exeption
{
    
    internal class Acount
    {
        private string email;
        private string password;

        private bool IsValid(string value)
        {
            foreach (char i in value)
            {
                if (!char.IsLetterOrDigit(i) && i != '_' && i != '@' && i != '.')
                    return false;
            }
            return true;
        }
        private bool PassIsValid(string value)
        {
            foreach (char i in value)
            {
                if (char.IsDigit(i))
                    return true;
            }
            return false;
        }
        public string Email
        {
            get => email;
            set
            {
                if (value.Length < 4 || value.Length > 50)
                {
                    throw new ArgumentException("Invalid email length");
                }
                    
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("Invalis symbol @");
                }
                   
                if(!IsValid(value))
                {
                    throw new ArgumentException("Invalis symboles only _ and @");
                }
                   
                email = value;
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (value.Length <= 6)
                {
                    throw new ArgumentException("Password must be > 6");
                }
                if(!PassIsValid(value))
                {
                    throw new ArgumentException("Password must have 1 number");
                }


                password = value;
            }
        }
        public Acount(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
