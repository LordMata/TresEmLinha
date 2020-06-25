// using Microsoft.VisualStudio.TestTools.UnitTesting;

using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;

namespace TresEmLinhaTests
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void InitializerTests() {
            // Arrange
            const int expectedSize = 9;
            const char expectedInitChar = ' ';
            IGame game = new Game();

            // Action
            game.Init();

            // Assert
            Console.WriteLine(game.Board.Length);
            Assert.That(expectedSize, Is.EqualTo(game.Board.Length));

            for (int i = 0; i < game.Board.Length; i++) {
                Assert.That(expectedInitChar, Is.EqualTo(game.Board[i]));
            }
        }

        [Test]
        public void ToStringWhenInitialBoardIsCreatedTests() {
            string expected = "| | | |\n| | | |\n| | | |\n";
            IGame game = new Game();


            game.Init();
            var stringRepresentation = game.ToString();


            Assert.That(stringRepresentation, Is.EqualTo(expected));
        }
    }
}
