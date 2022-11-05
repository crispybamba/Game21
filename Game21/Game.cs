using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Game21
{
    internal class Game
    {
        private Player player1;
        private Player player2;
        private Deck gameDeck;
        private int currentPlayer;

        public Game(string name1, string name2)
        {
            player1 = new Player(name1);
            player2 = new Player(name2);
            gameDeck = new Deck();
            currentPlayer = 1;
        }


        
        public Player GetCurrentPlayer()
        {
            if (currentPlayer == 1)
                return player1;
            return player2
        }

        public void GiveCurrentPlayerCard()
        {
            if (currentPlayer == 1)
            {
                player1.GetCard(gameDeck.Deal())
                currentPlayer++;
            }
            player2.GetCard(gameDeck.Deal())
            currentPlayer--;
        }

        public bool IsGameOver()
        {
            if (player1.GetPoints() == 21 || player2.GetPoints() == 21 )
                return true;
            if (!player1.IsActive() || !player1.IsActive())
                return true;
        }

        public Player GetWinner()
        {
            if (player1.GetPoints() == 21)
                return player1;
            if (player2.GetPoints() == 21)
                return player2;


            if (IsGameOver() && player1.IsActive())
                return player1;
            if (IsGameOver() && player2.IsActive())
                return player2;
        }


        public void StartGame()
        {
            player1.GetCard(gameDeck.Deal())
            player1.GetCard(gameDeck.Deal())

            player2.GetCard(gameDeck.Deal())
            player2.GetCard(gameDeck.Deal())
        }

        public override string ToString()
        {
            return "the game is played between" + player1.GetName() + "and" + player2.GetName();
        }



    }
}
