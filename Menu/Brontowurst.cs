/* Brontowurst.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Brontowurst class, is a Entree
    /// </summary>
    public class Brontowurst : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Adds whole wheat bun to ingredients list
        /// </summary>
        private bool wholeWheatBun = true;

        /// <summary>
        /// Adds peppers to ingredients list
        /// </summary>
        private bool peppers = true;

        /// <summary>
        /// Adds onions to ingredients list
        /// </summary>
        private bool onions = true;

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
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor, Sets price and calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Removes whole wheat bun from order
        /// </summary>
        public void HoldBun()
        {
            this.wholeWheatBun = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Removes peppers from order
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Removes peppers from order
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// return name of entree
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Brontowurst";
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
                if (!wholeWheatBun)
                    ingredients.Add("Hold Whole Wheat Bun");
                if (!onions)
                    ingredients.Add("Hold Onion");
                if (!peppers)
                    ingredients.Add("Hold Peppers");
                return ingredients.ToArray();
            }
        }
    }
}
