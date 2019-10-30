/* SteakosaurusBurger.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// SteakosaurusBurger class, is a Entree
    /// </summary>
    public class SteakosaurusBurger : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Adds whole wheat bun to ingredients list
        /// </summary>
        private bool wholeWheatBun = true;

        /// <summary>
        /// Adds pickle to ingredients list
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// Adds ketchup to ingredients list
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// Adds mustard to ingredients list
        /// </summary>
        private bool mustard = true;

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
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor. Sets the price and calories
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Removes whole wheat bun from ingredients list
        /// </summary>
        public void HoldBun()
        {
            this.wholeWheatBun = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Removes pickle from ingredients list
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Removes ketchup from ingredients list
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Removes mustard from ingredients list
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// returns the name of item
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }

        /// <summary>
        /// gets the description
        /// </summary>
        /// <returns>string</returns>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Get any special insturctions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!wholeWheatBun)
                    special.Add("Hold Whole Wheat Bun");
                if (!pickle)
                    special.Add("Hold Pickle");
                if (!ketchup)
                    special.Add("Hold Ketchup");
                if (!mustard)
                    special.Add("Hold Mustard");
                return special.ToArray();
            }
        }
    }
}
