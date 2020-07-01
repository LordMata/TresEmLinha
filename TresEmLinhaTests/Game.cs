using System;
using System.Collections.Generic;

namespace TresEmLinhaTests
{
    public class Game : IGame
    {
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
            if (Board[4] == 'X')
            {
                Console.WriteLine("player 1 won");
            }
            //Board[0] + Board[1] + Board[2];
            //Board[3] + Board[4] + Board[5];
            //Board[6] + Board[7] + Board[8];

            //Board[0] + Board[3] + Board[6];
            //Board[1] + Board[4] + Board[7];
            //Board[2] + Board[5] + Board[8];

            //Board[0] + Board[4] + Board[8];
            //Board[2] + Board[4] + Board[6]; 
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
            throw new NotImplementedException();
        }

        public void Play(int position)
        {
            // TODO
            if (Player == 1)
            {
                if (Board[position] == ' ')
                {
                    this.Board[position] = 'X';
                    Player = 2;
                    NumberOfMoves = NumberOfMoves + 1;
                }
            }
            else
            {
                if (Board[position] == ' ')
                {
                    this.Board[position] = 'O';
                    Player = 1;
                    NumberOfMoves = NumberOfMoves + 1;
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