﻿/* Water.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Water class, is a Drink
    /// </summary>
    public class Water : Drink, IMenuItem
    {
        /// <summary>
        /// Size of drink
        /// </summary>
        private Size size { get; set; }

        /// <summary>
        /// Lemon for the water
        /// </summary>
        public bool Lemon = false;

        /// <summary>
        /// Gets Ingredients based on bools
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor, Sets price and calories
        /// </summary>
        public Water()
        {
            this.Price = .10;
            this.Calories = 0;
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
                        this.Price = .10;
                        this.Calories = 0;
                        break;
                    case Size.Medium:
                        this.Price = .10;
                        this.Calories = 0;
                        break;
                    case Size.Large:
                        this.Price = .10;
                        this.Calories = 0;
                        break;
                }
            }
        }

        /// <summary>
        /// Adds Lemon to order 
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }

        public void HoldIce()
        {
            this.Ice = false;
        }

        /// <summary>
        /// returns the name of item
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return this.Size.ToString() + " Water";
        }
    }
}
