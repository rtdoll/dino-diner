/* DinoNuggets.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Dino Nuggets class, is a Entree
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Adds amount of nuggets to ingredients list
        /// </summary>
        private uint nuggetCount = 6;

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
                List<string> ingredients = new List<string>();
                for(int i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor, sets price and calories
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * nuggetCount;
        }

        /// <summary>
        /// Adds one nugget, increases calories and price
        /// </summary>
        public void AddNugget()
        {
            nuggetCount++;
            this.Calories += 59;
            this.Price += 0.25;
            NotifyOfPropertyChange("Price");
            NotifyOfPropertyChange("Calories");
        }

        /// <summary>
        /// returns the name of item
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }

        /// <summary>
        /// What comes with order
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets special instructions for item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> ingredients = new List<string>();
                return ingredients.ToArray();
            }
        }
    }
}
