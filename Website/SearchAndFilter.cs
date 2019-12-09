using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinoDiner.Menu;

namespace Website
{
    public class SearchAndFilter
    {
        static Menu Menu = new Menu();

        public static List<IMenuItem> AllItems
        {
            get
            {
                return Menu.AvailableMenuItems;
            }
        }

        public SearchAndFilter()
        {

        }

        public List<IMenuItem> filterSearch(List<IMenuItem> items, string search)
        {
            if (items.Count == 0)
                return Menu.AvailableMenuItems;
            List<IMenuItem> filteredMenu = new List<IMenuItem>();
            foreach(IMenuItem item in items)
            {
                if (item.Description != null && item.Description.Contains(search, StringComparison.OrdinalIgnoreCase))
                    filteredMenu.Add(item);
            }
            return filteredMenu;
        }

        public List<IMenuItem> filterCategories(List<string> categories)
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

        public List<IMenuItem> filterByPrice(List<IMenuItem> items, float? min, float? max)
        {
            List<IMenuItem> filtered = new List<IMenuItem>();
            foreach(IMenuItem item in items)
            {
                if (!(item.Price < min || item.Price > max))
                    filtered.Add(item);
            }
            return filtered;
        }

        public List<IMenuItem> filterIngredients(List<IMenuItem> items, List<string> filtIng)
        {
            if (filtIng.Count == 0)
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
