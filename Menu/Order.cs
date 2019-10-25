/* Order.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to keep track of items ordered
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// backing variable for tax rate
        /// </summary>
        private double salesTaxRate = 0;

        /// <summary>
        /// Collection of items added to order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; protected set; }

        /// <summary>
        /// Event handler for changing properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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
            set
            {
                if (value >= 0)
                    salesTaxRate = value;
                else
                    salesTaxRate = 0;
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

        public Order()
        {
            Items = new ObservableCollection<IOrderItem>();
            Items.CollectionChanged += OnCollectionChanged;
        }

        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}
