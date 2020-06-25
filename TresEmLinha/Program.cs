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
                Console.WriteLine($"Player{game.Player}: ");
                var ch = Console.ReadLine();
                int index;
                if (int.TryParse(ch, out index) && index >= 1 && index <=9 )
                {
                    game.Play(index);
                }
                Console.ReadLine();
            }
            while (game.CanPlay());
        }
    }
}
