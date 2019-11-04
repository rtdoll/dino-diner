/* Sodasaurus.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Sodasaurus class, is a Drink
    /// </summary>
    public class Sodasaurus : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
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
                NotifyOfPropertyChange("Flavor");
            }
        }

        /// <summary>
        /// Property changed event handler
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        //Helper function for notifying of property changes
        public override void NotifyOfPropertyChange(string propertyName)
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
                List<string> ingredients = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
                return ingredients;
            }
        }

        /// <summary>
        /// Changes flavor of soda
        /// </summary>
        /// <param name="flavor">new flavor</param>
        public void NewFlavor(SodasaurusFlavor flavor)
        {
            this.flavor = flavor;
            NotifyOfPropertyChange("Description");
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
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Calories");
            }
        }

        /// <summary>
        /// Holds ice from order
        /// </summary>
        public override void HoldIce()
        {
            this.Ice = false;
            NotifyOfPropertyChange("Ice");
        }

        /// <summary>
        /// Adds Ice to order
        /// </summary>
        public override void AddIce()
        {
            this.Ice = true;
            NotifyOfPropertyChange("Ice");
        }

        /// <summary>
        /// returns the name of item
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sodasaurus";
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
                if (!Ice)
                    special.Add("Hold Ice");
                return special.ToArray();
            }
        }
    }
}
