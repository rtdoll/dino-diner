/* TRexKingBurger.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// TRexKingBurger class, is a Entree
    /// </summary>
    public class TRexKingBurger : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Adds whole wheat bun to ingredients list
        /// </summary>
        private bool wholeWheatBun = true;

        /// <summary>
        /// Adds lettuce to ingredients list
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Adds tomato to ingredients list
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// Adds onion to ingredients list
        /// </summary>
        private bool onion = true;

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
        /// Adds mayo to ingredients list
        /// </summary>
        private bool mayo = true;

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
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor, sets price and calories
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
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
        /// Removes lettuce from ingredients list
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Removes tomato from ingredients list
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Removes onion from ingredients list
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
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
        /// Removes mayo from ingredients list
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// returns the name of item
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
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
                if (!lettuce)
                    special.Add("Hold Lettuce");
                if (!tomato)
                    special.Add("Hold Tomato");
                if (!onion)
                    special.Add("Hold Onion");
                if (!pickle)
                    special.Add("Hold Pickle");
                if (!ketchup)
                    special.Add("Hold Ketchup");
                if (!mustard)
                    special.Add("Hold Mustard");
                if (!mayo)
                    special.Add("Hold Mayonnaise");
                return special.ToArray();
            }
        }
    }
}
