using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Size of drink
        /// </summary>
        private Size size { get; set; }

        /// <summary>
        /// If tea is sweet
        /// </summary>
        public bool Sweet = false;

        /// <summary>
        /// Lemon for the water
        /// </summary>
        public bool Lemon = false;

        /// <summary>
        /// Gets ingredients based on bool
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if (Sweet) ingredients.Add("Cane Sugar");
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        public Tyrannotea()
        {
            this.Price = 0.99;
            this.Calories = 8;
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
                        this.Price = .99;
                        this.Calories = 8;
                        if (Sweet) this.Calories *= 2;
                        break;
                    case Size.Medium:
                        this.Price = 1.49;
                        this.Calories = 16;
                        if (Sweet) this.Calories *= 2;
                        break;
                    case Size.Large:
                        this.Price = 1.99;
                        this.Calories = 32;
                        if (Sweet) this.Calories *= 2;
                        break;
                }
            }
        }

        /// <summary>
        /// Adds Sweetener to tea
        /// </summary>
        public void AddSweetener()
        {
            this.Sweet = true;
        }

        /// <summary>
        /// Removes Sweetener to tea
        /// </summary>
        public void RemoveSweetener()
        {
            this.Sweet = false;
        }

        /// <summary>
        /// Adds Lemon to tea
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }
    }
}
