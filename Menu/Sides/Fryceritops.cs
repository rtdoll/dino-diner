using DinoDiner.Menu.Sides;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Sides
{
    public class Fryceritops : Side
    {
        public Fryceritops()
        {
            this.Price = 0.99;
            this.Calories = 222;
            this.Ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
        }

        public override Size Size
        {
            get
            {
                return this.Size;
            }
            set
            {
                Size = value;
                switch (Size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 420;
                        break;
                }
            }
        }
    }
}
