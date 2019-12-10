using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinoDiner.Menu;

namespace Website
{
    public class SearchAndFilter
    {
        //Current menu
        static Menu Menu = new Menu();
        /// <summary>
        /// All items available from Menu
        /// </summary>
        public static IEnumerable<IMenuItem> AllItems
        {
            get
            {
                return Menu.AvailableMenuItems;
            }
        }

        public SearchAndFilter()
        {

        }
        /// <summary>
        /// filters menu by search term and current items
        /// </summary>
        /// <param name="items">current menu items</param>
        /// <param name="search">string search term</param>
        /// <returns></returns>
        public IEnumerable<IMenuItem> filterSearch(IEnumerable<IMenuItem> items, string search)
        {
            if (!items.Any())
                return Menu.AvailableMenuItems;
            List<IMenuItem> filteredMenu = new List<IMenuItem>();
            foreach(IMenuItem item in items)
            {
                if (item.Description != null && item.Description.Contains(search, StringComparison.OrdinalIgnoreCase))
                    filteredMenu.Add(item);
            }
            return filteredMenu;
        }

        /// <summary>
        /// filter menu by categories
        /// </summary>
        /// <param name="categories">categories selected</param>
        /// <returns></returns>
        public IEnumerable<IMenuItem> filterCategories(IEnumerable<string> categories)
        {
            if (!categories.Any())
                return Menu.AvailableMenuItems;

            List<IMenuItem> filtered = new List<IMenuItem>();
            
            if (categories.Contains("Combos"))
                filtered.AddRange(Menu.AvailableCombos);

            if (categories.Contains("Entrees"))
                filtered.AddRange(Menu.AvailableEntrees);

            if (categories.Contains("Drinks"))
                filtered.AddRange(Menu.AvailableDrinks);

            if (categories.Contains("Sides"))
                filtered.AddRange(Menu.AvailableSides);

            return filtered;
        }

        /// <summary>
        /// filter by price of current menu items
        /// </summary>
        /// <param name="items">current menu items</param>
        /// <param name="min">minimum price</param>
        /// <param name="max">maximum price</param>
        /// <returns></returns>
        public IEnumerable<IMenuItem> filterByPrice(IEnumerable<IMenuItem> items, float? min, float? max)
        {
            List<IMenuItem> filtered = new List<IMenuItem>();
            foreach(IMenuItem item in items)
            {
                if (!(item.Price < min || item.Price > max))
                    filtered.Add(item);
            }
            return filtered;
        }

        /// <summary>
        /// filters items out if ingredient is selected
        /// </summary>
        /// <param name="items">currently selected items</param>
        /// <param name="filtIng">ingredients not wanted</param>
        /// <returns></returns>
        public IEnumerable<IMenuItem> filterIngredients(IEnumerable<IMenuItem> items, List<string> filtIng)
        {
            if (!filtIng.Any())
                return items;

            List<IMenuItem> filtered = new List<IMenuItem>();
            foreach(IMenuItem item in items)
            {
                List<string> ingredients = item.Ingredients;
                foreach(string ing in filtIng)
                {
                    if (!ingredients.Contains(ing))
                        filtered.Add(item);
                }
            }
            return filtered;
        }
    }
}
