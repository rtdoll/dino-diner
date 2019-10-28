using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        //The correct default price, calories, ice, size, and lemon properties.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal<double>(0.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water water = new Water();
            Assert.Equal(Size.Small, water.Size);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Water water = new Water();
            Assert.False(water.Lemon);
        }
        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<double>(0.10, water.Price);
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(0.10, water.Price);
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(0.10, water.Price);
            Assert.Equal<uint>(0, water.Calories);
        }
        //That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void ShouldNotHaveIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }
        //That invoking AddLemon() sets results in the Lemon property being true.
        [Fact]
        public void ShouldHaveLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }
        //The correct ingredients are given.
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            Water water = new Water();
            Assert.Contains<string>("Water", water.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Contains<string>("Water", water.Ingredients);
            Assert.Contains<string>("Lemon", water.Ingredients);
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            Water water = new Water();
            Assert.Empty(water.Special);
        }

        [Fact]
        public void SpecialShouldHoldIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.Collection<string>(water.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Collection<string>(water.Special,
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldHoldIceAndAddLemon()
        {
            Water water = new Water();
            water.HoldIce();
            water.AddLemon();
            Assert.Collection<string>(water.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                },
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                }
                );
        }

        [Fact]
        public void DescriptionShouldGiveName()
        {
            Water water = new Water();
            Assert.Contains("Water", water.Description);
        }

        [Fact]
        public void HoldCheeseShouldNotifyOfSPecialPropertyChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () =>
            {
                water.HoldIce();
            }
            );
        }

        [Fact]
        public void AddLemonShouldNotifyOfSPecialPropertyChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () =>
            {
                water.AddLemon();
            }
            );
        }

        [Fact]
        public void TestOrder()
        {
            Water water = new Water();
            Order newOrder = new Order();
            newOrder.Add(water);
            Assert.Equal<double>(0.10, newOrder.SubtotalCost);
            Assert.Equal<double>(0.10, newOrder.TotalCost);
            Assert.Equal<double>(0, newOrder.SalesTaxRate);
            Assert.Equal<double>(0, newOrder.SalesTaxCost);
        }
    }
}
