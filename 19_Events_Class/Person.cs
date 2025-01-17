using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _19_Events_Class
{
    public class PropertyEvent : EventArgs
    {
        public string PropertyName { get; set; }


    }


    public delegate void PropertyEventHandler(object sender, PropertyEvent e);



    interface IPropertyChanged
    {
        event PropertyEventHandler PropertyChanged;
    }





    internal class Person : IPropertyChanged
    {
        public string name;
        public string lastName;
        public string born;
        public event PropertyEventHandler PropertyChanged;
        public string Name
        {
            get => name;
            set
            {
                if(name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    OnPropertyChanged(nameof(LastName));
                }
            }
        }
        public string Born
        {
            get => born;
            set
            {
                if (born != value)
                {
                    born = value;
                    OnPropertyChanged(nameof(Born));
                }
            }
        }
     
        public void OnPropertyChanged(string propertyName)
        {
            PropertyEvent args = new PropertyEvent()
            {
                PropertyName = propertyName,
            };
            PropertyChanged?.Invoke(this, args);
        }
        public void Subsribe(object sender, PropertyEvent e)
        {
            Console.WriteLine($"Property {e.PropertyName} has been changed.");
        }
    }
}
