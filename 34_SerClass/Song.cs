using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_SerClass
{
    internal class Song
    {
        public string Name { get; set; }
        public string Time { get; set; }

        public string Genre { get; set; }


        public Song(string name, string time, string genre) { 
            
            Name = name;
            Time = time;
            Genre = genre;
        
        }

        public Song() 
           : this("NoName","3,14","rock")
        { }
    }
}
