using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TuroChamp;

namespace Tests
{
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        public void BasicBoardTests()
        {
            Board board = new Board();

            Square square = board.Squares[0];
            Assert.AreEqual(Color.Black, square.Color);
            Assert.AreEqual(Rank.One, square.Rank);
            Assert.AreEqual(File.A, square.File);
            Assert.IsNotNull(square.Piece);
        }
    }
}
