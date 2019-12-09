/* Drink.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Drink abstract class, keeps track of Price, Calories, Ice, Ingredients, and Size
    /// </summary>
    public abstract class Drink : IOrderItem
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
        /// Gets and sets if drink has Ice
        /// </summary>
        public bool Ice { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets special requests
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// Gets description of order item
        /// </summary>

        public abstract string Description { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Helper function to notify of property changes
        /// </summary>
        /// <param name="propertyName">property being changed</param>
        public abstract void NotifyOfPropertyChange(string propertyName);

        /// <summary>
        /// PropertyChanged event handler, notifies of properties that get changed
        /// </summary>
        public abstract event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Holds ice from drink
        /// </summary>
        public abstract void HoldIce();

        /// <summary>
        /// Adds ice to drink
        /// </summary>
        public abstract void AddIce();

        /// <summary>
        /// Category of item
        /// </summary>
        public string Category
        {
            get
            {
                return "Drink";
            }
        }

    }
}
