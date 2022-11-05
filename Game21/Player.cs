using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game21
{
    internal class Player
    {
        private string name;
        private int points;
        private bool active;
        private List<Card> cards;

        public Player(string name)
        {
            this.name = name;
            points = 0;
            active = true;
            cards = new List<Card>();
        }

        public string GetName() => name;

        public int GetPoints() => points;

        public void GetCard (Card card)
        {
            cards.Add(card);

            
            points+= card.GetValue();
        }
        
        public void Quit() => active = false;
        public void AddPoints (int amount) => points+=amount;
        public bool aceInHand()
        {
            for(int i = 0; i < cards.Count; i++)
                if (cards[i].IsAce())
                    return true;
            return false;
        }
        public bool Lost() 
        {
            if (points > 21 && !aceInHand() )
                return true;
            else if (points > 21 && aceInHand())
            {
                for(int i = 0; i < cards.Count; i++)
                    if (cards[i].IsAce())
                        cards[i].SetValue(1)
                points = points - 10;
            }
                
        }
        public bool IsActive() => active;
        public override string ToString()
        {
            
            return "The player - " + name + "\nhave " + points + "points";
        }
        

    }
}
