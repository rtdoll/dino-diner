using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// Adds amount of nuggets to ingredients list
        /// </summary>
        private uint nuggetCount = 6;

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
        }
    }
}
