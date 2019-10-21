﻿/* Order.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to keep track of items ordered
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Collection of items added to order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// Get the subtotal of order
        /// </summary>
        public double SubtotalCost 
        { 
            get
            {
                double subtotal = 0;
                foreach (IOrderItem o in Items)
                {
                    subtotal += o.Price;
                }
                if (subtotal > 0)
                    return subtotal;
                else
                    return 0;
            }
        }

        /// <summary>
        /// gets and sets the Salex tax
        /// </summary>
        public double SalesTaxRate { get; protected set; }

        /// <summary>
        /// Gets the sales tax cost
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SubtotalCost * SalesTaxRate;
            }
        }

        /// <summary>
        /// gets the total cost of order
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SalesTaxCost + SubtotalCost;
            }
        }
    }
}
