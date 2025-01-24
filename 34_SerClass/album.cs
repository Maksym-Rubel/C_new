using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _34_SerClass
{
    internal class Album
    {

        public string Name { get; set; }
        public string Author { get; set; }

        public int Year { get; set; }

        public string Times { get; set; }

        public string Stuidia { get; set; }

        public List<Song> Songs { get; set; }


        public Album(string name, string author, int year, string times, string studia, List<Song> songs)
        {
            
            Name = name;
            Author = author;
            Year = year;
            Times = times;
            Stuidia = studia;
            Songs = songs;
        }

        public Album()
            :this("NoName","NoName",0000,"00:00","NoStudia",new List<Song>())
        {
            
        }


        public void Print()
        {
            Console.WriteLine($"Album name  :: {Name}");
            Console.WriteLine($"Author name :: {Author}");
            Console.WriteLine($"Year        :: {Year}");
            Console.WriteLine($"Times       :: {Times}");
            Console.WriteLine($"Stuidia     :: {Stuidia}");
            Console.WriteLine($"-------------- All songs ---------------");
            foreach(Song song in Songs)
            {
                Console.WriteLine($"Song name :: {song.Name,-10} Song Time :: {song.Time,-10} Song Genre {song.Genre}");
            }
          

        }

        public Album EnterAll()
        {
            Console.Write("Enter name album  --> ");
            string name = Console.ReadLine()!;
            Console.Write("Enter name author  --> ");
            string author = Console.ReadLine()!;
            Console.Write("Enter album year  --> ");
            int year = int.Parse(Console.ReadLine()!);
            Console.Write("Enter Times  --> ");
            string times = Console.ReadLine()!;
            Console.Write("Enter Stuidia  --> ");
            string stuidia = Console.ReadLine()!;
            Console.Write("Enter song name --> ");
            string names = Console.ReadLine()!;
            Console.Write("Enter song time --> ");
            string time = Console.ReadLine()!;
            Console.Write("Enter song genre --> ");
            string genre = Console.ReadLine()!;
            List<Song> songs = new List<Song>
            { 
                new Song(names, time, genre),
            };

            return new Album(name, author, year, times, stuidia, songs);

        }

        public void SerializeAlbum(string path, Album al)
        {
            string json = JsonConvert.SerializeObject(al);
            File.WriteAllText(path, json);
        

        }
        public Album DeSerializeAlbum(string path)
        {
            Album res = JsonConvert.DeserializeObject<Album>(File.ReadAllText(path))!;

            return res;
        }


    }
}
