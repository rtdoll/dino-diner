﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Side abstract class, keeps track of Price, Calories, Size, and Ingredients
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// Gets and setsthe price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Gets and setsthe price
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Size of side
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Gets Ingredients based on bools
        /// </summary>
        public virtual List<string> Ingredients { get; protected set; }

        /// <summary>
        /// Gets special requests
        /// </summary>
        public virtual string[] Special { get; }

        /// <summary>
        /// Gets Description of order item
        /// </summary>
        public virtual string Description { get; }

        public abstract event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Category of item
        /// </summary>
        public string Category
        {
            get
            {
                return "Side";
            }
        }
    }
}
