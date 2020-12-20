using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ColorScrollTests
    {
        [Test]
        public void WhenInitializeTheColors_ThenTheListOfColorsHasTheCorrectLength()
        {
            var colorScroll = new ColorScroll();
            List<string> colors = new List<string>() { "red", "red", "red", "red", "red", "red", "red", "red", "red", "red" };

            colorScroll.InitializeColors(colors);

            Assert.AreEqual(colors.Count, colorScroll.ColorLength,
                $"Color initialization was expecting {colors.Count} colors but got {colorScroll.ColorLength}");
        }


        [Test]
        public void WhenInitializeTheColors_ThenTheListOfColorsIsNotEqualToTheOriginal()
        {
            var colorScroll = new ColorScroll();
            List<string> colors = new List<string>() { "red", "green", "blue", "yellow", "orange", "pink", "black", "white", "purple" };

            colorScroll.InitializeColors(colors);

            Assert.AreNotEqual(colors, colorScroll.Colors,
                $"Color initialization does not randomize the color list");
        }
    }
}
