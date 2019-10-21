/* JurassicJava.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Jurassic Java class, is a Drink
    /// </summary>
    public class JurassicJava : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Size of drink
        /// </summary>
        private Size size { get; set; }

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
        /// Gets Ingredients based on bools
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Coffee" };
                return ingredients;
            }
        }

        /// <summary>
        /// Option to leave room for cream 
        /// </summary>
        public bool RoomForCream = false;

        /// <summary>
        /// Option for Decaf or Regular
        /// </summary>
        public bool Decaf = false;

        /// <summary>
        /// Constructor, Sets price and calories and ice
        /// </summary>
        public JurassicJava()
        {
            this.Price = .59;
            this.Calories = 2;
            this.Ice = false;
        }

        /// <summary>
        /// Gets current size, or changes size and sets new price/calories based on what size
        /// </summary>
        public override Size Size
        {
            get
            {
                return this.size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = .59;
                        this.Calories = 2;
                        break;
                    case Size.Medium:
                        this.Price = 0.99;
                        this.Calories = 4;
                        break;
                    case Size.Large:
                        this.Price = 1.49;
                        this.Calories = 8;
                        break;
                }
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Calories");
            }
        }

        /// <summary>
        /// set RoomForCream to true
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Adds Ice to order
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Set decaf to true
        /// </summary>
        public void DecafCoffee()
        {
            this.Decaf = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// returns the name of item
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            if(Decaf)
                return $"{Size} Decaf Jurassic Java";
            else
                return $"{Size} Jurassic Java";
        }

        /// <summary>
        /// What comes with the Drink
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
        public override string[] Special
        {
            get
            {
                List<string> ingredients = new List<string>();
                if (RoomForCream)
                    ingredients.Add("Leave Room For Cream");
                if (Decaf)
                    ingredients.Add("Decaf Coffee");
                if (Ice)
                    ingredients.Add("Add Ice");
                return ingredients.ToArray();
            }
        }
    }
}
