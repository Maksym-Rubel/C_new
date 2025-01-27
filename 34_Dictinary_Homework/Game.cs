using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _34_Dictinary_Homework
{
    internal class Game
    {
        private List<Player> players;
        private List<Karta> deck;

        public Game()
        {
            players = new List<Player>(); 
            deck = GenerateDeck();       
        }

        public void StartGame()
        {
            
            Console.WriteLine("Введіть ім'я першого гравця:");
            string player1Name = Console.ReadLine();
            Console.WriteLine("Введіть ім'я другого гравця:");
            string player2Name = Console.ReadLine();

            players.Add(new Player(player1Name));
            players.Add(new Player(player2Name));

       
            if (deck == null || deck.Count == 0)
            {
                Console.WriteLine("Колода порожня");
                deck = GenerateDeck();
            }

         
            ShuffleDeck();
            DealCards();

            Console.WriteLine("Починаємо гру!");
            Play();
        }


        private void ShuffleDeck()
        {
            Random random = new Random();
            deck = deck.OrderBy(x => random.Next()).ToList();
        }
        private List<Karta> GenerateDeck()
        {
            List<Karta> deck = new List<Karta>();
            string[] suits = { "Чирва", "Бубна", "Трефа", "Піка" };
            string[] ranks = { "6", "7", "8", "9", "10", "Валет", "Дама", "Король", "Туз" };

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    deck.Add(new Karta(suit, rank));
                }
            }

            return deck;
        }
        private void DealCards()
        {
            int playerIndex = 0;

            foreach (var card in deck)
            {
                players[playerIndex].AddCard(card);
                playerIndex = (playerIndex + 1) % players.Count;
            }
        }


        private void Play()
        {
            int roundCount = 0;
            int maxRounds = 100;

            while (players.All(player => player.HasCards()) && roundCount < maxRounds && deck.Count > 0)
            {
                roundCount++;
                Console.WriteLine($"Раунд {roundCount}");

                List<Karta> table = new List<Karta>();

                for (int i = 0; i < players.Count; i++)
                {
                    if (!players[i].HasCards()) continue; 

                    var card = players[i].PlayCard();
                    Console.WriteLine($"{players[i].Name} виклав {card}");
                    table.Add(card);
                }

                var winner = DetermineRoundWinner(table);
                if (winner != null)
                {
                    Console.WriteLine($"Раунд виграв {winner.Name}!");
                    winner.AddCardsToDeck(table);
                }
                else
                {
                    Console.WriteLine("Карти залишаються на столі.");
                }
            }

          
            var gameWinner = players.OrderByDescending(player => player.GetCardCount()).FirstOrDefault();
            if (gameWinner != null)
            {
                Console.WriteLine($"Гру виграв {gameWinner.Name} з {gameWinner.GetCardCount()} картами!");
            }
            else
            {
                Console.WriteLine("Ніхто не виграв.");
            }
        }

        private Player DetermineRoundWinner(List<Karta> table)
        {
            if (table == null || table.Count == 0) return null; 

            int maxRank = table.Max(card => card.RankValue);
            var winningCards = table.Where(card => card.RankValue == maxRank).ToList();

            if (winningCards.Count == 0) return null; 

            int winnerIndex = table.IndexOf(winningCards.First());
            if (winnerIndex < 0 || winnerIndex >= players.Count) return null;

            return players[winnerIndex];
        }
    }
}
