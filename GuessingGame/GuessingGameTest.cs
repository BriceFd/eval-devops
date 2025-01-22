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
            _guessinggame = new GuessingGame(50);
        }
        [TestMethod]
        [DataRow(50)]
        public void GuessinGame_WithValidValue_ReturnsTrue(int guess)
        {
            // Act
            var result = _guessinggame.MakeGuess(guess);

            // Assert
            Assert.AreEqual("Correct!", result); 
            Assert.IsTrue(_guessinggame.IsGameWon);
        }
        [TestMethod]
        [DataRow(30)]
        public void GuessinGame_WithInvalidValue_ReturnsHint(int guess)
        {
            // Act
            var result = _guessinggame.MakeGuess(guess);

            // Assert
            Assert.AreEqual("Plus grand", result);
            Assert.IsFalse(_guessinggame.IsGameWon);
        }
        [TestMethod]
        [DataRow(0)] 
        [DataRow(101)] 
        public void GuessinGame_OutOfRange_ThrowsException(int guess)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => 
            { 
            var result =  _guessinggame.MakeGuess(guess);
            });
        }

        }

}
