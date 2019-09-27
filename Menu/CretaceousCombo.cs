using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu
{
    public class CretaceousCombo
    {
        public Entree Entree { get; set; }
        public Drink Drink { get; set; }
        public Side Side { get; set; }

        private Size size = Size.Small;

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
            }
        }

        public double Price
        {
            get
            {
                return this.Drink.Price + this.Side.Price + this.Entree.Price - 0.25;
            }
        }

        public uint Calories
        {
            get
            {
                return this.Drink.Calories + this.Side.Calories + this.Entree.Calories;
            }
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(this.Drink.Ingredients);
                ingredients.AddRange(this.Entree.Ingredients);
                ingredients.AddRange(this.Side.Ingredients);
                return ingredients;
            }
        }

        private CretaceousCombo() {  }

        public CretaceousCombo(Entree entree, Side side, Drink drink)
        {
            this.Entree = entree;
            this.Side = side;
            this.Drink = drink;
        }
    }
}
