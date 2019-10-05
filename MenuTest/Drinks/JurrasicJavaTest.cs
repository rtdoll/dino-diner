using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        //The correct default price, calories, ice, size, and SpaceForCream properties.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<double>(0.59, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal(Size.Small, java.Size);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultRoomForCream()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.RoomForCream);
        }
        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(0.59, java.Price);
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(0.99, java.Price);
            Assert.Equal<uint>(4, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
            Assert.Equal<uint>(8, java.Calories);
        }
        //That invoking AddIce() results in the Ice property being true
        [Fact]
        public void ShouldHaveIce()
        {
            JurrasicJava java = new JurrasicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }
        //That invoking LeaveSpaceForCream() results in the SpaceForCream property being true.
        [Fact]
        public void ShouldHaveRoomForCream()
        {
            JurrasicJava java = new JurrasicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }
        //The correct ingredients are given.
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
        }
    }
}
