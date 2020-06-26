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
            throw new NotImplementedException();
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