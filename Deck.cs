using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackMVC
{
    internal class Deck
    {
        public List<Card> deck;
        public Deck()
        {
            deck = new List<Card>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    Card card = new Card(rank, suit);
                    deck.Add(card);
                }
            }
        }

        public void Shuffle()
        {
            // Derived from: https://stackoverflow.com/questions/273313/randomize-a-listt
            Random random = new Random();
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card temp = deck[k];
                deck[k] = deck[n];
                deck[n] = temp;
            }
        }

        public Card DealCard()
        {
            Card card = deck[0];
            deck.RemoveAt(0);
            return card;
        }
    }
}
