using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.UnitTests
{
    [TestClass]
    public class GuessingGameTest
    {
        private GuessingGame _guessinggame;
        [TestInitialize]
        public void Init()
        {
            _guessinggame = new GuessingGame();
        }
        [TestMethod]
        public void GuessinGame_WithValidValue_ReturnsTrue()
        {

            // Act
            var result = _guessinggame.MakeGuess(50);

            // Assert
            Assert.Equal("Correct!", result);
            Assert.True(game.IsGameWon);
        }
    }

}
