using System;
using System.Collections.Generic;

namespace TresEmLinhaTests
{
    public class Game : IGame
    {
        char J;
        public char[] Board { get; set; }

        public int NumberOfMoves { get; private set; }

        public int Player { get; private set; }

        public bool CanPlay()
        {
            // TODO: to be implmented
            return true;
        }

        public bool HasWon()
        {
            if (Board[0] == J && Board[1] == J && Board[2] == J)
            {
                Jogada();
                return true;
            }
            if (Board[0] == J && Board[3] == J && Board[6] == J)
            {
                Jogada();
                return true;
            }
            if (Board[0] == J && Board[4] == J && Board[8] == J)
            {
                Jogada();
                return true;
            }
            if (Board[1] == J && Board[4] == J && Board[7] == J)
            {
                Jogada();
                return true;
            }
            if (Board[2] == J && Board[5] == J && Board[8] == J)
            {
                Jogada();
                return true;
            }
            if (Board[2] == J && Board[4] == J && Board[6] == J)
            {
                Jogada();
                return true;
            }
            if (Board[3] == J && Board[4] == J && Board[5] == J)
            {
                Jogada();
                return true;
            }
            if (Board[6] == J && Board[7] == J && Board[8] == J)
            {
                Jogada();
                return true;
            }
            return false;
        }

        private void Jogada()
        {
            if (J == 'X')
            {
                Console.WriteLine("PLAYER 1 WON!");
            }
            else if (J == 'O')
            {
                Console.WriteLine("PLAYER 2 WON!");
            }
        }

        public void Init()
        {
            Board = new char[9];
            for (int i = 0; i < Board.Length; i++)
            {
                Board[i] = ' ';
            }

            Player = 1;
            NumberOfMoves = 0;
            
        }

        public bool IsEnded()
        {
            return false;
        }

        public void Play(int position)
        {
            // TODO
            if (Player == 1)
            {
                this.J = 'X';
                if (Board[position] == ' ')
                {
                    this.Board[position] = J;
                    Player = 2;
                }
            }
            else
            {
                this.J = 'O';
                if (Board[position] == ' ')
                {
                    this.Board[position] = J;
                    Player = 1;
                }
            }

            HasWon();
        }

        public override string ToString()
        {
            var stringRepresentation = string.Empty;
            for (int i = 0; i < Board.Length; i++)
            {
                if (i > 0 && i % 3 == 0) {
                    stringRepresentation += "|\n";
                }

                stringRepresentation += $"|{Board[i]}";
            }

            stringRepresentation += "|\n";

            return stringRepresentation; 
        }
    }
}