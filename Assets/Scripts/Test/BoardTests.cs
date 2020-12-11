using NUnit.Framework;

namespace Test
{
    public class BoardTests
    {
        [Test]
        public void WhenCreateBoardWithHighAndHeight_ThenCreateAMapWithTheCorrectRowsAndColumns()
        {
            //Arrange
            var width = 5;
            var height = 2;

            //Act
            var board = new Board(width, height);

            //Assert
            Assert.AreEqual(width, board.NumberOfColumns, 
                $"Number of columns {board.NumberOfColumns} is different than width {width}");
            Assert.AreEqual(height, board.NumberOfRows, 
                $"Number of rows {board.NumberOfRows} is different than height {height}");
        }
    }
}