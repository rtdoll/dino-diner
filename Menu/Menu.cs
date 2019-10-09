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
                menu.Add(new CretaceousCombo(new Brontowurst(), new Fryceritops(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new Brontowurst(), new Fryceritops(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new Brontowurst(), new Fryceritops(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new Brontowurst(), new Fryceritops(), new Water()));
                menu.Add(new CretaceousCombo(new Brontowurst(), new MeteorMacAndCheese(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new Brontowurst(), new MeteorMacAndCheese(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new Brontowurst(), new MeteorMacAndCheese(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new Brontowurst(), new MeteorMacAndCheese(), new Water()));
                menu.Add(new CretaceousCombo(new Brontowurst(), new MezzorellaSticks(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new Brontowurst(), new MezzorellaSticks(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new Brontowurst(), new MezzorellaSticks(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new Brontowurst(), new MezzorellaSticks(), new Water()));
                menu.Add(new CretaceousCombo(new Brontowurst(), new Triceritots(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new Brontowurst(), new Triceritots(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new Brontowurst(), new Triceritots(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new Brontowurst(), new Triceritots(), new Water()));
                menu.Add(new CretaceousCombo(new DinoNuggets(), new Fryceritops(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new DinoNuggets(), new Fryceritops(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new DinoNuggets(), new Fryceritops(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new DinoNuggets(), new Fryceritops(), new Water()));
                menu.Add(new CretaceousCombo(new DinoNuggets(), new MeteorMacAndCheese(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new DinoNuggets(), new MeteorMacAndCheese(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new DinoNuggets(), new MeteorMacAndCheese(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new DinoNuggets(), new MeteorMacAndCheese(), new Water()));
                menu.Add(new CretaceousCombo(new DinoNuggets(), new MezzorellaSticks(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new DinoNuggets(), new MezzorellaSticks(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new DinoNuggets(), new MezzorellaSticks(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new DinoNuggets(), new MezzorellaSticks(), new Water()));
                menu.Add(new CretaceousCombo(new DinoNuggets(), new Triceritots(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new DinoNuggets(), new Triceritots(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new DinoNuggets(), new Triceritots(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new DinoNuggets(), new Triceritots(), new Water()));
                menu.Add(new CretaceousCombo(new PrehistoricPBJ(), new Fryceritops(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new PrehistoricPBJ(), new Fryceritops(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new PrehistoricPBJ(), new Fryceritops(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new PrehistoricPBJ(), new Fryceritops(), new Water()));
                menu.Add(new CretaceousCombo(new PrehistoricPBJ(), new MeteorMacAndCheese(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new PrehistoricPBJ(), new MeteorMacAndCheese(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new PrehistoricPBJ(), new MeteorMacAndCheese(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new PrehistoricPBJ(), new MeteorMacAndCheese(), new Water()));
                menu.Add(new CretaceousCombo(new PrehistoricPBJ(), new MezzorellaSticks(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new PrehistoricPBJ(), new MezzorellaSticks(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new PrehistoricPBJ(), new MezzorellaSticks(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new PrehistoricPBJ(), new MezzorellaSticks(), new Water()));
                menu.Add(new CretaceousCombo(new PrehistoricPBJ(), new Triceritots(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new PrehistoricPBJ(), new Triceritots(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new PrehistoricPBJ(), new Triceritots(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new PrehistoricPBJ(), new Triceritots(), new Water()));
                menu.Add(new CretaceousCombo(new PterodactylWings(), new Fryceritops(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new PterodactylWings(), new Fryceritops(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new PterodactylWings(), new Fryceritops(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new PterodactylWings(), new Fryceritops(), new Water()));
                menu.Add(new CretaceousCombo(new PterodactylWings(), new MeteorMacAndCheese(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new PterodactylWings(), new MeteorMacAndCheese(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new PterodactylWings(), new MeteorMacAndCheese(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new PterodactylWings(), new MeteorMacAndCheese(), new Water()));
                menu.Add(new CretaceousCombo(new PterodactylWings(), new MezzorellaSticks(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new PterodactylWings(), new MezzorellaSticks(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new PterodactylWings(), new MezzorellaSticks(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new PterodactylWings(), new MezzorellaSticks(), new Water()));
                menu.Add(new CretaceousCombo(new PterodactylWings(), new Triceritots(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new PterodactylWings(), new Triceritots(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new PterodactylWings(), new Triceritots(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new PterodactylWings(), new Triceritots(), new Water()));
                menu.Add(new CretaceousCombo(new SteakosaurusBurger(), new Fryceritops(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new SteakosaurusBurger(), new Fryceritops(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new SteakosaurusBurger(), new Fryceritops(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new SteakosaurusBurger(), new Fryceritops(), new Water()));
                menu.Add(new CretaceousCombo(new SteakosaurusBurger(), new MeteorMacAndCheese(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new SteakosaurusBurger(), new MeteorMacAndCheese(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new SteakosaurusBurger(), new MeteorMacAndCheese(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new SteakosaurusBurger(), new MeteorMacAndCheese(), new Water()));
                menu.Add(new CretaceousCombo(new SteakosaurusBurger(), new MezzorellaSticks(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new SteakosaurusBurger(), new MezzorellaSticks(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new SteakosaurusBurger(), new MezzorellaSticks(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new SteakosaurusBurger(), new MezzorellaSticks(), new Water()));
                menu.Add(new CretaceousCombo(new SteakosaurusBurger(), new Triceritots(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new SteakosaurusBurger(), new Triceritots(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new SteakosaurusBurger(), new Triceritots(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new SteakosaurusBurger(), new Triceritots(), new Water()));
                menu.Add(new CretaceousCombo(new TRexKingBurger(), new Fryceritops(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new TRexKingBurger(), new Fryceritops(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new TRexKingBurger(), new Fryceritops(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new TRexKingBurger(), new Fryceritops(), new Water()));
                menu.Add(new CretaceousCombo(new TRexKingBurger(), new MeteorMacAndCheese(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new TRexKingBurger(), new MeteorMacAndCheese(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new TRexKingBurger(), new MeteorMacAndCheese(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new TRexKingBurger(), new MeteorMacAndCheese(), new Water()));
                menu.Add(new CretaceousCombo(new TRexKingBurger(), new MezzorellaSticks(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new TRexKingBurger(), new MezzorellaSticks(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new TRexKingBurger(), new MezzorellaSticks(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new TRexKingBurger(), new MezzorellaSticks(), new Water()));
                menu.Add(new CretaceousCombo(new TRexKingBurger(), new Triceritots(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new TRexKingBurger(), new Triceritots(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new TRexKingBurger(), new Triceritots(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new TRexKingBurger(), new Triceritots(), new Water()));
                menu.Add(new CretaceousCombo(new VelociWrap(), new Fryceritops(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new VelociWrap(), new Fryceritops(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new VelociWrap(), new Fryceritops(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new VelociWrap(), new Fryceritops(), new Water()));
                menu.Add(new CretaceousCombo(new VelociWrap(), new MeteorMacAndCheese(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new VelociWrap(), new MeteorMacAndCheese(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new VelociWrap(), new MeteorMacAndCheese(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new VelociWrap(), new MeteorMacAndCheese(), new Water()));
                menu.Add(new CretaceousCombo(new VelociWrap(), new MezzorellaSticks(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new VelociWrap(), new MezzorellaSticks(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new VelociWrap(), new MezzorellaSticks(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new VelociWrap(), new MezzorellaSticks(), new Water()));
                menu.Add(new CretaceousCombo(new VelociWrap(), new Triceritots(), new JurassicJava()));
                menu.Add(new CretaceousCombo(new VelociWrap(), new Triceritots(), new Sodasaurus()));
                menu.Add(new CretaceousCombo(new VelociWrap(), new Triceritots(), new Tyrannotea()));
                menu.Add(new CretaceousCombo(new VelociWrap(), new Triceritots(), new Water()));
                return menu;
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
