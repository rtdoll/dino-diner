/* Tyrannotea.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Tyrannotea class, is a Drink
    /// </summary>
    public class Tyrannotea : Drink, IMenuItem
    {
        /// <summary>
        /// Size of drink
        /// </summary>
        private Size size { get; set; }

        /// <summary>
        /// If tea is sweet
        /// </summary>
        public bool Sweet = false;

        /// <summary>
        /// Lemon for the water
        /// </summary>
        public bool Lemon = false;

        /// <summary>
        /// Gets ingredients based on bool
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if (Sweet) ingredients.Add("Cane Sugar");
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        public Tyrannotea()
        {
            this.Price = 0.99;
            this.Calories = 8;
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
                        this.Price = 0.99;
                        this.Calories = 8;
                        break;
                    case Size.Medium:
                        this.Price = 1.49;
                        this.Calories = 16;
                        break;
                    case Size.Large:
                        this.Price = 1.99;
                        this.Calories = 32;
                        break;
                }
            }
        }

        /// <summary>
        /// Adds Sweetener to tea
        /// </summary>
        public void AddSweetener()
        {
            this.Sweet = true;
            this.Calories *= 2;
        }

        /// <summary>
        /// Removes Sweetener to tea
        /// </summary>
        public void RemoveSweetener()
        {
            this.Sweet = false;
            this.Calories /= 2;
        }

        /// <summary>
        /// Adds Lemon to tea
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }

        /// <summary>
        /// returns the name of item
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            if (Sweet)
                return this.Size.ToString() + " Sweet Tyrannotea";
            else
                return this.Size.ToString() + " Tyrannotea";
        }
    }
}
