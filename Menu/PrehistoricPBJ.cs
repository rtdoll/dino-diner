﻿/* PrehistoricPBJ.cs
 * Author: Ryan Doll
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Prehistoric PBJ class, is a Entree
    /// </summary>
    public class PrehistoricPBJ : Entree, IMenuItem
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
        /// Removes peanut butter from ingredients list
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// removes jelly from ingredients list
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }

        /// <summary>
        /// returns the name of item
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
