using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CellTests
    {
        [Test]
        public void WhenCreatingACellWithAColor_ThenTheCellHasTheCorrectColor()
        {
            var expectedColor = Color.cyan;

            var cell = new Cell(expectedColor);

            Assert.AreEqual(expectedColor, cell.CellColor, $"Color of the created cell ({cell.CellColor}) is not correct ({expectedColor})");
        }
    }
}
