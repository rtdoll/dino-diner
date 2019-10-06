﻿/* IMenuItem.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// IMenuItem Interface, Requires Price, Calories, and Ingredients for every menu item
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Gets the price
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets the calories
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        List<string> Ingredients { get; }
    }
}
