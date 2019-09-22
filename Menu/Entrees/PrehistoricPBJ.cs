﻿using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// Boolean to determine if peanut butter goes on sandwich
        /// </summary>
        private bool peanutButter = true;

        /// <summary>
        /// Boolean to determine if jelly goes on sandwich
        /// </summary>
        private bool jelly = true;

        /// <summary>
        /// Gets Ingredients based on bools
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for PrehistoricPBJ
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Sets peanutButter to false if customer does not want peanut butter
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// Sets jelly to false if customer does not want jelly
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
