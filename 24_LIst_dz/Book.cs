using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_LIst_dz
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Book(string title, string author, string genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
        }
        public override string ToString()
        {
            return $"TItle: {Title,-10} Author: {Author,-10} Genre: {Genre,-10} Year: {Year,-10}";
        }
    }
}
