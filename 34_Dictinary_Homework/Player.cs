using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _34_Dictinary_Homework
{
    internal class Player
    {
        public string Name { get; private set; }
        private Queue<Karta> hand;

        public Player(string name)
        {
            Name = name;
            hand = new Queue<Karta>();
        }

        public void AddCard(Karta card)
        {
            hand.Enqueue(card);
        }

        public Karta PlayCard()
        {
            return hand.Dequeue();
        }

        public void AddCardsToDeck(IEnumerable<Karta> cards)
        {
            foreach (var card in cards)
            {
                hand.Enqueue(card);
            }
           
        }

        public bool HasCards()
        {
            return hand.Count > 0;
        }
        public int GetCardCount()
        {
            return hand.Count;
        }


    }
}
