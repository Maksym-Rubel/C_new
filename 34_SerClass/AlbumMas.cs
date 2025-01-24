using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_SerClass
{
    internal class AlbumMas
    {
        public List<Album> Albums { get; set; }

        public AlbumMas(List<Album> albums)
        {
            Albums = albums;
        }
        public AlbumMas()
            :this(new List<Album>())
        {
          
        }
        public void SerializeAlbum1(string path, AlbumMas al)
        {
            string json = JsonConvert.SerializeObject(al);
            File.WriteAllText(path, json);


        }
        public AlbumMas DeSerializeAlbum(string path)
        {
            AlbumMas res = JsonConvert.DeserializeObject<AlbumMas>(File.ReadAllText(path))!;

            return res;
        }

        public void AddnewAlb(AlbumMas albumMas,Album album)
        {
           albumMas.Albums.Add(album);
        }
        


        public void Print()
        {
            Console.WriteLine("----------************----------- Masive Album -----------****************-------------");
            foreach(Album album in Albums)
            {
                Console.WriteLine();
                album.Print();
            }
            Console.WriteLine("---------------------------------------------");

        }
    }
 
}
