using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackMVC
{
    internal class Hand
    {
        private List<Card> Cards { get; set; }

        public int Count { get; }

        public Hand()
        {
            Cards = new List<Card>();
        }

        public void addCard(Card card)
        {
            Cards.Add(card);
        }

        public Card removeCard()
        {
            int count = Cards.Count();
            Card card = Cards[count - 1];
            Cards.RemoveAt(count - 1);
            return card;

        }

        // add method that returns how big the hand is (loop count)
        public int countCard()
        {
            return Cards.Count();
        }


        public int HandValue()
        {
            int sum = 0;
            int numOfAces = 0;
            int numofJokers = 0;

            foreach (Card card in Cards)
            {
                sum += (int)card.Rank;
                if (card.Rank == Rank.Ace)
                {
                    numOfAces++;
                }
                if(card.Rank == Rank.Joker)
                {
                    numofJokers++;
                }
            }
            while (numofJokers > 0)
            {
                if(sum > 21)
                {
                    sum -= 10;
                    numofJokers--;
                }
                else
                {
                    break;
                }
            }

            // Aces are 11 unless that causes the hand to bust, if so they are 1.
            while (numOfAces > 0)
            {
                if (sum > 21)
                {
                    sum -= 10;
                    numOfAces--;
                }
                else
                {
                    break;
                }
            }
            return sum;
        }

        public void PrintHand()
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine(card.ToString());
            }
            Console.WriteLine("Value: " + HandValue().ToString());
            Console.WriteLine("");
        }
        public string returnHand()
        {
            string hand = "";
            foreach (Card card in Cards)
            {
                hand += card.ToString() + "\n\r";
            }

            return hand;

        }
        public bool AceHole()
        {
            if (Cards[0].Rank.Equals(Rank.Ace))
            {
                return true;
            }else
            {
                return false;
            }
        }
        public bool CheckSplit()
        {
            if (Cards[0].Rank.Equals(Cards[1].Rank))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
