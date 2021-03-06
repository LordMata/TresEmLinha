﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TresEmLinhaTests;

namespace TresEmLinha
{
    class Program
    {
        static void Main(string[] args)
        {
            IGame game = new Game();
            game.Init();
            do
            {   

                Console.WriteLine(game.ToString());
                Console.WriteLine();
                Console.WriteLine($"Jogada {game.NumberOfMoves + 1} para jogador {game.Player}:");
                var ch = Console.ReadLine();
                int index;
                if (int.TryParse(ch, out index) && index >= 1 && index <=9 )
                {

                    game.Play(index);
                }
            }
            while (game.CanPlay());

            Console.WriteLine(game.ToString());

            if (game.HasWon())
            {
                if (game.J == 'X')
                {
                    Console.WriteLine("PLAYER 1 WON!");
                }
                else if (game.J == 'O')
                {
                    Console.WriteLine("PLAYER 2 WON!");
                }
                var player = game.Player == 1 ? 2 : 1;
                Console.WriteLine($"Player {player} won!!!");
            }
            Console.WriteLine("Jogo terminado!");
            Console.Read();
        }
    }
}
