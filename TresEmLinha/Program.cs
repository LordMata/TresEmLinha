using System;
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
                if (int.TryParse(ch, out index) && index >= 0 && index <=8 )
                {
                    game.Play(index);
                }
            }
            while (game.CanPlay());
        }
    }
}
