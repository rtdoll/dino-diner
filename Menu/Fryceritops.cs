﻿/* Fryceritops.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Fryceritops class, is a side
    /// </summary>
    public class Fryceritops : Side, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Size of side
        /// </summary>
        private Size size { get; set;  }

        /// <summary>
        /// Property changed event handler
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        //Helper function for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets Ingredients based on bools
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor, sets price, calories, and ingredients
        /// </summary>
        public Fryceritops()
        {
            this.Price = 0.99;
            this.Calories = 222;
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
                        this.Calories = 222;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 365;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 480;
                        break;
                }
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Calories");
            }
        }

        /// <summary>
        /// returns the name of item
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"{Size} Fryceritops";
        }


        /// <summary>
        /// Gets description of order item
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Get any special instructions for order item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }
    }
}
