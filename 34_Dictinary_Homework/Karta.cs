using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Dictinary_Homework
{
    internal class Karta
    {
        public string Suit { get; private set; }
        public string Rank { get; private set; }
        public int RankValue { get; private set; }

        public Karta(string suit, string rank)
        {
            Suit = suit;
            Rank = rank;


            RankValue = rank switch
            {
                "6" => 6,
                "7" => 7,
                "8" => 8,
                "9" => 9,
                "10" => 10,
                "Валет" => 11,
                "Дама" => 12,
                "Король" => 13,
                "Туз" => 14,
                _ => throw new ArgumentException("Невідомий ранг карти")
            };
        }

        public override string ToString()
        {
            return $"{Rank} {Suit}";
        }
    }
}
