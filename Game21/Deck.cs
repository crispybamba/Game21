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
                    Card card = new Card(j, i);
                    cards.Add(card);
                }
            return cards;
        }
    }

}
