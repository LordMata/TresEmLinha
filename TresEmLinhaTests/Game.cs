using System;
using System.Collections.Generic;

namespace TresEmLinhaTests
{
    public class Game : IGame
    {
        public char J { get; set; }
        const int MaxMoves = 9;
        public char[] Board { get; set; }

        public int NumberOfMoves { get; private set; }

        public int Player { get; private set; }

        public bool CanPlay()
        {
            // TODO: to be implmented
            //if (!IsEnded())
            //{
            //    return true;
            //}
            //return false;
            return !IsEnded();
        }

        public bool HasWon()
        {
            if (Board[0] == J && Board[1] == J && Board[2] == J)
            {
                //Jogada();
                return true;
            }
            if (Board[0] == J && Board[3] == J && Board[6] == J)
            {
                //Jogada();
                return true;
            }
            if (Board[0] == J && Board[4] == J && Board[8] == J)
            {
                //Jogada();
                return true;
            }
            if (Board[1] == J && Board[4] == J && Board[7] == J)
            {
                //Jogada();
                return true;
            }
            if (Board[2] == J && Board[5] == J && Board[8] == J)
            {
                //Jogada();
                return true;
            }
            if (Board[2] == J && Board[4] == J && Board[6] == J)
            {
                //Jogada();
                return true;
            }
            if (Board[3] == J && Board[4] == J && Board[5] == J)
            {
                //Jogada();
                return true;
            }
            if (Board[6] == J && Board[7] == J && Board[8] == J)
            {
                //Jogada();
                return true;
            }

            return false;
        }

        /*private void Jogada()
        {
            if (J == 'X')
            {
                Console.WriteLine("PLAYER 1 WON!");
            }
            else if (J == 'O')
            {
                Console.WriteLine("PLAYER 2 WON!");
            }

        }*/

        public void Init()
        {
            Board = new char[MaxMoves];
            for (int i = 0; i < Board.Length; i++)
            {
                Board[i] = ' ';
            }

            Player = 1;
            NumberOfMoves = 0;
            
        }

        public bool IsEnded()
        {
            //return NumberOfMoves == 9 && HasWon() ? true : false;
            return NumberOfMoves == MaxMoves || HasWon();
        }

        public void Play(int position)
        {
            var index = position - 1;
            // TODO
            if (Player == 1)
            {
                J = 'X';
                if (Board[index] == ' ')
                {
                    Moves(index);
                }
            }
            else
            {
                J = 'O';
                if (Board[index] == ' ')
                {
                    Moves(index);
                }
            }

            HasWon();
        }

        private void Moves(int index)
        {
            this.Board[index] = J;
            NumberOfMoves = NumberOfMoves + 1;
            Player = Player == 1 ? 2 : 1;
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