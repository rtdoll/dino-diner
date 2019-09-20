using System;
using System.Collections.Generic;
using DinoDiner.Menu.Sides;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks : Side
    {
        private Size size { get; set; }
        public MezzorellaSticks()
        {
            this.Price = 0.99;
            this.Calories = 540;
            this.Ingredients = new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
        }
        public override Size Size
        {
            get
            {
                return this.size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = 540;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 610;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 720;
                        break;
                }
            }
        }
    }
}
