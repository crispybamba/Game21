using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Game21.Card;

namespace Game21
{
    internal class Deck
    {
        private List<Card> cards;


        public Deck()
        {
            cards = InitDeck();
        }
 

        private static List<Card> InitDeck()
        {
            List<Card> cards = new List<Card>();
            for (int i = 0; i < 14; i++)
                foreach (Shape j in Enum.GetValues(typeof(Shape)))
                {
                    if (i <= 10)
                    {
                    Card card = new Card(j, i);
                    cards.Add(card);
                }
                    else
                    {
                        Card card = new Card(j, 10);
                        cards.Add(card);
                    }
                }
            return cards;
        }
        public void Shuffle()
        {
            for (int i = 0; i < cards.Count * 2; i++)
            {
                Random rnd = new Random();
                int idx1 = rnd.Next(0, cards.Count);
                int idx2 = rnd.Next(0, cards.Count);
                Card temp = cards[idx1];
                cards[idx1] = cards[idx2];
                cards[idx2] = temp;
            }
        }
        public int Count() { return cards.Count; }
        public bool IsEmpty() { return cards.Count == 0; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < cards.Count; i++)
            {
                sb.Append(cards[i].ToString());
                sb.Append(". ");
            }
            return sb.ToString();
        }
        private void Remove(int num)
        {
            for (int i = 0; i < num; i++)
                cards.RemoveAt(cards.Count - i);
        }
        public Card Deal()
        {
            return cards[cards.Count - 1];
        }//to make it.....
        //פעולה של לחלק קלפים...

    }

}
