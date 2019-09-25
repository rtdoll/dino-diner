﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// Size of drink
        /// </summary>
        private Size size { get; set; }

        /// <summary>
        /// Option to leave room for cream 
        /// </summary>
        public bool RoomForCream = false;

        private bool Decaf = false;

        /// <summary>
        /// Constructor, Sets price and calories and ice
        /// </summary>
        public JurrasicJava()
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
                        this.Price = 1.49;
                        this.Calories = 4;
                        break;
                    case Size.Large:
                        this.Price = 2.00;
                        this.Calories = 8;
                        break;
                }
            }
        }

        /// <summary>
        /// set RoomForCream to true
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
        }

        /// <summary>
        /// Adds Ice to order
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
        }

        /// <summary>
        /// Set decaf to true
        /// </summary>
        public void DecafCoffee()
        {
            this.Decaf = true;
        }
    }
}
