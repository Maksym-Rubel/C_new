using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Events
{
    //delegate void PosiotionDelefate(string description);

    class MyArgs : EventArgs
    {
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public DateTime Date {  get; set; }
    }
    internal class Company
    {
        public string Name { get; set; }
        public event EventHandler<EventArgs> NewPosition;
        //public event PosiotionDelefate NewPosition;

        //public void AddPosition(string description)
        //{
        //    NewPosition.Invoke(description);
        //}
        public void AddPosition(string description)
        {
            MyArgs args = new MyArgs();
            {
                Description = description;
                CompanyName = Name;
                Date = DateTime.Now;
            };
            NewPosition?.Invoke(this, args);
        }
    }
}
