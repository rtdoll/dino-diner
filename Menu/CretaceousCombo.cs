/* CretaceousCombo.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Creates a Combo of Menu item using Entree Drink and Side
    /// </summary>
    public class CretaceousCombo : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Entree item for combo
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// Drink item for combo
        /// </summary>
        public Drink Drink { get; set; }

        /// <summary>
        /// Side item for combo
        /// </summary>
        public Side Side { get; set; }

        /// <summary>
        /// keep track of size of combo
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Change size of combo
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                this.size = value;
                this.Drink.Size = value;
                this.Side.Size = value;
                NotifyOfPropertyChange("Size");
            }
        }

        /// <summary>
        /// price of combo - .25 discount
        /// </summary>
        public double Price
        {
            get
            {
                return this.Drink.Price + this.Side.Price + this.Entree.Price - 0.25;
            }
        }

        /// <summary>
        /// Combined calories of combo items
        /// </summary>
        public uint Calories
        {
            get
            {
                return this.Drink.Calories + this.Side.Calories + this.Entree.Calories;
            }
        }

        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        //Helper function for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// combined ingredients of combo items
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(this.Entree.Ingredients);
                ingredients.AddRange(this.Side.Ingredients);
                ingredients.AddRange(this.Drink.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// entree only constructor
        /// </summary>
        /// <param name="entree">Chosen entree</param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
        }

        /// <summary>
        /// Constructor for entree drink and side combo
        /// </summary>
        /// <param name="entree">Chosen Entree</param>
        /// <param name="side">Chosen Side</param>
        /// <param name="drink">Chosen Drink</param>
        public CretaceousCombo(Entree entree, Side side, Drink drink)
        {
            this.Entree = entree;
            this.Side = side;
            this.Drink = drink;
        }

        /// <summary>
        /// return name of combo
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"{Entree} Combo";
        }

        /// <summary>
        /// What comes with the Combo
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets special instructions for item
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Special);
                ingredients.Add(Side.ToString());
                ingredients.AddRange(Side.Special);
                ingredients.Add(Drink.ToString());
                ingredients.AddRange(Drink.Special);
                return ingredients.ToArray();
            }
        }
    }
}
