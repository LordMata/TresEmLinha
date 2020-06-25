using System;
using System.Collections.Generic;

namespace TresEmLinhaTests
{
    public interface IGame
    {
        char[] Board { get; }
        int NumberOfMoves { get; }
        int Player { get; }

        void Init();

        bool HasWon();

        bool IsEnded();

        void Play(int position);
        bool CanPlay();
    }
}