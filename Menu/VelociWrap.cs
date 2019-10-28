/* VelociWrap.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Velociwrap class, is a Entree
    /// </summary>
    public class VelociWrap : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Adds dressing to ingredients list
        /// </summary>
        private bool dressing = true;

        /// <summary>
        /// Adds lettuce to ingredients list
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Adds cheese to ingredients list
        /// </summary>
        private bool cheese = true;

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
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor, sets price and calories
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Removes dressing from ingredients list
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Removes lettuce from ingredients list
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Removes cheese from ingredients list
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// returns the name of item
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }

        /// <summary>
        /// gets the description
        /// </summary>
        /// <returns>string</returns>
        public string Description
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
                if (!dressing)
                    special.Add("Hold Dressing");
                if (!lettuce)
                    special.Add("Hold Lettuce");
                if (!cheese)
                    special.Add("Hold Cheese");
                return special.ToArray();
            }
        }
    }
}
