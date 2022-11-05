using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            return player2;
        }

        public void GiveCurrentPlayerCard()
        {
            if (currentPlayer == 1)
            {
                player1.GetCard(gameDeck.Deal());
                
            }
            player2.GetCard(gameDeck.Deal());
            
        }

        public bool IsGameOver()
        {
            if (player1.GetPoints() >= 21 || player2.GetPoints() >= 21 )
                return true;
            if (!player1.IsActive() || !player1.IsActive())
                return true;
            return false;
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
            return null;
        }


        public void StartGame()
        {
            player1.GetCard(gameDeck.Deal());
            player1.GetCard(gameDeck.Deal());

            player2.GetCard(gameDeck.Deal());
            player2.GetCard(gameDeck.Deal());
        }

        public override string ToString()
        {
            return "the game is played between" + player1.GetName() + "and" + player2.GetName();
        }

        public void play()
        {
            gameDeck.Shuffle();
            StartGame();
            while(!IsGameOver())
                for (currentPlayer = 1; currentPlayer < 3; currentPlayer++)
			    {
                    if (currentPlayer == 1)
                        Console.WriteLine("its now " + player1.GetName() + " turn");
                    if (currentPlayer == 2)
                        Console.WriteLine("its now " + player2.GetName() + " turn");

                    Console.WriteLine("if you want to take card write \"take\" else write every other thing");
                    if (Console.ReadLine() == "take")
                        GiveCurrentPlayerCard();
                    Console.Clear();
                    
                    Console.WriteLine("you have now in hand");
                    Console.WriteLine();
                    if (currentPlayer == 1)
                        Console.WriteLine(player1.ToString());
                    if(currentPlayer == 2)
                        Console.WriteLine(player2.ToString());





                    Console.WriteLine("if you want to de declare win write \"win\" else write every other thing");
                    if (Console.ReadLine() == "win")
                        if (GetWinner() == player1 && currentPlayer == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("youve won!!!!");
                        }
                            
                        else if (GetWinner() == player2 && currentPlayer == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("youve won!!!!");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("youve been caught cheating! you havnt won");
                        }
                            
			    }
            Console.WriteLine("game overrrrrr");
            Console.ReadLine();

        }



    }
}
