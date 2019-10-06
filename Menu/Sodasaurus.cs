using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Size of drink
        /// </summary>
        private Size size { get; set; }

        private SodasaurusFlavor flavor = SodasaurusFlavor.Cola;

        /// <summary>
        /// Flavor of drink
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }

        /// <summary>
        /// Constructor, Sets price and calories and ingredients
        /// </summary>
        public Sodasaurus()
        {
            this.Price = 1.5;
            this.Calories = 112;
            this.Ingredients = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            this.Ice = true;
        }

        /// <summary>
        /// Gets current size, or changes size and sets new price/calories based on what size
        /// </summary>
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
                        this.Price = 1.50;
                        this.Calories = 112;
                        break;
                    case Size.Medium:
                        this.Price = 2.00;
                        this.Calories = 156;
                        break;
                    case Size.Large:
                        this.Price = 2.50;
                        this.Calories = 208;
                        break;
                }
            }
        }
    }
}
