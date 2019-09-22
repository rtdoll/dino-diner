using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger : Entree
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
        }

        /// <summary>
        /// Removes lettuce from ingredients list
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Removes tomato from ingredients list
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }

        /// <summary>
        /// Removes onion from ingredients list
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }

        /// <summary>
        /// Removes pickle from ingredients list
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Removes ketchup from ingredients list
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Removes mustard from ingredients list
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }

        /// <summary>
        /// Removes mayo from ingredients list
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }
    }
}
