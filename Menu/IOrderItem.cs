/* IOrderItem.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Details of an item ordered by a customer
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Gets the price of the item ordered
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets the description of the item ordered
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets the special instructions for an item ordered
        /// </summary>
        string[] Special { get; }
    }
}
