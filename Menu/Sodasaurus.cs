/* Sodasaurus.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Sodasaurus class, is a Drink
    /// </summary>
    public class Sodasaurus : Drink, IMenuItem
    {
        /// <summary>
        /// Size of drink
        /// </summary>
        private Size size { get; set; }

        /// <summary>
        /// keeps track of flavor of drink
        /// </summary>
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
        /// Gets Ingredients based on bools
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor, Sets price and calories and ingredients
        /// </summary>
        public Sodasaurus()
        {
            this.Price = 1.5;
            this.Calories = 112;
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

        /// <summary>
        /// returns the name of item
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return this.Size.ToString() + " " + this.Flavor.ToString() + " Sodasaurus";
        }
    }
}
