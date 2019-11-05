/* Entree.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Entree abstract class, keeps track of Price, Calories, and Ingredients
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }
        
        /// <summary>
        /// Gets or sets the Ingredients
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// Gets special requests
        /// </summary>
        public virtual string[] Special { get; }

        /// <summary>
        /// Gets desciprtion of order item
        /// </summary>
        public virtual string Description { get; }

        public abstract event PropertyChangedEventHandler PropertyChanged;
    }
}
