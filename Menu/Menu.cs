/* Menu.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Combines all entree, side, and drink items
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Gets available Menu Items
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> menu = new List<IMenuItem>();
                menu.Add(new CretaceousCombo(new Brontowurst()));
                menu.Add(new CretaceousCombo(new DinoNuggets()));
                menu.Add(new CretaceousCombo(new PrehistoricPBJ()));
                menu.Add(new CretaceousCombo(new PterodactylWings()));
                menu.Add(new CretaceousCombo(new SteakosaurusBurger()));
                menu.Add(new CretaceousCombo(new TRexKingBurger()));
                menu.Add(new CretaceousCombo(new VelociWrap()));
                menu.Add(new Brontowurst());
                menu.Add(new DinoNuggets());
                menu.Add(new Fryceritops());
                menu.Add(new JurassicJava());
                menu.Add(new MeteorMacAndCheese());
                menu.Add(new MezzorellaSticks());
                menu.Add(new PrehistoricPBJ());
                menu.Add(new PterodactylWings());
                menu.Add(new Sodasaurus());
                menu.Add(new SteakosaurusBurger());
                menu.Add(new TRexKingBurger());
                menu.Add(new Triceritots());
                menu.Add(new Tyrannotea());
                menu.Add(new VelociWrap());
                menu.Add(new Water());
                return menu;
            }
        }

        /// <summary>
        /// Gets available Entrees
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> menu = new List<IMenuItem>();
                menu.Add(new Brontowurst());
                menu.Add(new DinoNuggets());
                menu.Add(new PrehistoricPBJ());
                menu.Add(new PterodactylWings());
                menu.Add(new SteakosaurusBurger());
                menu.Add(new TRexKingBurger());
                menu.Add(new VelociWrap());
                return menu;
            }
        }

        /// <summary>
        /// Gets available Sides
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> menu = new List<IMenuItem>();
                menu.Add(new Fryceritops());
                menu.Add(new MeteorMacAndCheese());
                menu.Add(new MezzorellaSticks());
                menu.Add(new Triceritots());
                return menu;
            }
        }

        /// <summary>
        /// Gets available Drinks
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> menu = new List<IMenuItem>();
                menu.Add(new JurassicJava());
                menu.Add(new Sodasaurus());
                menu.Add(new Tyrannotea());
                menu.Add(new Water());
                return menu;
            }
        }

        /// <summary>
        /// Gets available Combos
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> menu = new List<IMenuItem>();
                menu.Add(new CretaceousCombo(new Brontowurst()));
                menu.Add(new CretaceousCombo(new DinoNuggets()));
                menu.Add(new CretaceousCombo(new PrehistoricPBJ()));
                menu.Add(new CretaceousCombo(new PterodactylWings()));
                menu.Add(new CretaceousCombo(new SteakosaurusBurger()));
                menu.Add(new CretaceousCombo(new TRexKingBurger()));
                menu.Add(new CretaceousCombo(new VelociWrap()));
                return menu;
            }
        }

        /// <summary>
        /// All possible ingredients from every menu item, no duplicates
        /// </summary>
        public List<string> PossibleIngredients
        {
            get
            {
                List<string> ing = new List<string>();
                foreach(IMenuItem item in AvailableMenuItems)
                {
                    foreach(string s in item.Ingredients)
                    {
                        if(!ing.Contains(s))
                            ing.Add(s);
                    }
                }
                return ing;
            }
        }

        /// <summary>
        /// return string of available menu items
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            string s = "";
            foreach(IMenuItem m in AvailableMenuItems)
            {
                s +=  m.ToString() +"\n";
            }
            return s;
        }
    }
}
