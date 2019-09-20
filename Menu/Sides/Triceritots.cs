using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        private Size size { get; set; }
        public Triceritots()
        {
            this.Price = 0.99;
            this.Calories = 352;
            this.Ingredients = new List<string>() { "Potatoes", "Salt", "Vegetable Oil" };
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
                        this.Calories = 352;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 410;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 590;
                        break;
                }
            }
        }
    }
}
