/* JurassicJavaTest.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        //The correct default price, calories, ice, size, and SpaceForCream properties.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(0.59, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal(Size.Small, java.Size);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.RoomForCream);
        }
        //The correct price and calories ajavaer changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(0.59, java.Price);
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(0.99, java.Price);
            Assert.Equal<uint>(4, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
            Assert.Equal<uint>(8, java.Calories);
        }
        //That invoking AddIce() results in the Ice property being true
        [Fact]
        public void ShouldHaveIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }
        //That invoking LeaveSpaceForCream() results in the SpaceForCream property being true.
        [Fact]
        public void ShouldHaveRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }
        //The correct ingredients are given.
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava java = new JurassicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            JurassicJava java = new JurassicJava();
            Assert.Empty(java.Special);
        }

        [Fact]
        public void SpecialShouldLeaveRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.Collection<string>(java.Special,
                item =>
                {
                    Assert.Equal("Leave Room For Cream", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldHaveDecaf()
        {
            JurassicJava java = new JurassicJava();
            java.DecafCoffee();
            Assert.Collection<string>(java.Special,
                item =>
                {
                    Assert.Equal("Decaf Coffee", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldAddIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.Collection<string>(java.Special,
                item =>
                {
                    Assert.Equal("Add Ice", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldLeaveRoomForCreamAndShouldHaveDecaf()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            java.DecafCoffee();
            Assert.Collection<string>(java.Special,
                item =>
                {
                    Assert.Equal("Leave Room For Cream", item);
                },
                item =>
                {
                    Assert.Equal("Decaf Coffee", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldLeaveRoomForCreamAndAddIce()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            java.AddIce();
            Assert.Collection<string>(java.Special,
                item =>
                {
                    Assert.Equal("Leave Room For Cream", item);
                },
                item =>
                {
                    Assert.Equal("Add Ice", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldShouldHaveDecafAndAddIce()
        {
            JurassicJava java = new JurassicJava();
            java.DecafCoffee();
            java.AddIce();
            Assert.Collection<string>(java.Special,
                item =>
                {
                    Assert.Equal("Decaf Coffee", item);
                },
                item =>
                {
                    Assert.Equal("Add Ice", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldLeaveRoomForCreamAndShouldHaveDecafAndAddIce()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            java.DecafCoffee();
            java.AddIce();
            Assert.Collection<string>(java.Special,
                item =>
                {
                    Assert.Equal("Leave Room For Cream", item);
                },
                item =>
                {
                    Assert.Equal("Decaf Coffee", item);
                },
                item =>
                {
                    Assert.Equal("Add Ice", item);
                }
                );
        }

        [Fact]
        public void DescriptionShouldGiveName()
        {
            JurassicJava java = new JurassicJava();
            Assert.Contains("Jurassic Java", java.Description);
        }

        [Fact]
        public void ChangeSizeSmallShouldNotifyOfSPecialPropertyChange()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.PropertyChanged(java, "Size", () =>
            {
                java.Size = Size.Small;
            }
            );
            Assert.PropertyChanged(java, "Price", () =>
            {
                java.Size = Size.Small;
            }
            );
            Assert.PropertyChanged(java, "Calories", () =>
            {
                java.Size = Size.Small;
            }
            );
        }

        [Fact]
        public void ChangeSizeMediumShouldNotifyOfSPecialPropertyChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Size", () =>
            {
                java.Size = Size.Medium;
            }
            );
            Assert.PropertyChanged(java, "Price", () =>
            {
                java.Size = Size.Medium;
            }
            );
            Assert.PropertyChanged(java, "Calories", () =>
            {
                java.Size = Size.Medium;
            }
            );
        }

        [Fact]
        public void ChangeSizeLargeShouldNotifyOfSPecialPropertyChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Size", () =>
            {
                java.Size = Size.Large;
            }
            );
            Assert.PropertyChanged(java, "Price", () =>
            {
                java.Size = Size.Large;
            }
            );
            Assert.PropertyChanged(java, "Calories", () =>
            {
                java.Size = Size.Large;
            }
            );
        }

        [Fact]
        public void LeaveRoomForCreamShouldNotifySpecialPropertyChang()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.LeaveRoomForCream();
            }
            );
        }

        [Fact]
        public void AddIceShouldNotifySpecialPropertyChang()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.AddIce();
            }
            );
        }

        [Fact]
        public void DecafCoffeeShouldNotifySpecialPropertyChang()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.DecafCoffee();
            }
            );
        }
    }
}
