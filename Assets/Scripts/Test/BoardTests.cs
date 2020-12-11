using NUnit.Framework;

namespace Test
{
    public class BoardTests
    {
        [TestCase (5,2)]
        [TestCase (3,3)]
        public void WhenCreateBoardWithHighAndHeight_ThenCreateAMapWithTheCorrectRowsAndColumns(int width, int height)
        {
            var board = new Board(width, height);

            Assert.AreEqual(width, board.NumberOfColumns, 
                $"Number of columns {board.NumberOfColumns} is different than width {width}");
            Assert.AreEqual(height, board.NumberOfRows, 
                $"Number of rows {board.NumberOfRows} is different than height {height}");
        }
    }
}