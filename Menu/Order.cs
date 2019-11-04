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


        private List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// Collection of items added to order
        /// </summary>
        public IOrderItem[] Items {
            get
            {
                return items.ToArray();
            }
        }

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
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyAllPropertiesChanged();
        }
        /// <summary>
        /// Adds a new item to order and notifies of changes
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            NotifyAllPropertiesChanged();
        }

        /// <summary>
        /// Remove an item from the order list
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                NotifyAllPropertiesChanged();
            }
            return removed;
            
        }

        /// <summary>
        /// Notify of all properties changed
        /// </summary>
        private void NotifyAllPropertiesChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

    }
}
