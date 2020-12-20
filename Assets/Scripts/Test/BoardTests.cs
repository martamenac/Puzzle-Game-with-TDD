using System;
using NUnit.Framework;

namespace Test
{
    public class BoardTests
    {
        [TestCase (3,3)]
        public void WhenCreateBoardWithWidthAndHeight_ThenCreateAMapWithTheCorrectRowsAndColumns(int width, int height)
        {
            var board = new Board(width, height);

            Assert.AreEqual(width, board.NumberOfColumns, 
                $"Number of columns {board.NumberOfColumns} is different than width {width}");
            Assert.AreEqual(height, board.NumberOfRows, 
                $"Number of rows {board.NumberOfRows} is different than height {height}");
        }

        [TestCase(0,1)]
        [TestCase(1,0)]
        [TestCase(0,0)]
        public void WhenCreateBoardWithWidthOrHeightZero_ThenThrowAnException(int width, int height)
        {
            Assert.Catch<Exception>(() =>
            {
                var board = new Board(width, height);
            }, $"The board does not throw an exception when created with {width} width and {height} height");
        }

        [Test]
        public void WhenBoardFilled_AllCellsHaveSquares()
        {
            var board = new Board(5, 5);

            board.FillBoard();

            Assert.AreEqual(25, board.RemainingSquares, 
                $"Number of squares {board.RemainingSquares} is different than number of cells {board.NumberOfColumns * board.NumberOfRows}");
        }
    }
}