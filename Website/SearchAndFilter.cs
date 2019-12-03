using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinoDiner.Menu;

namespace Website
{
    public class SearchAndFilter
    {
        Menu Menu = new Menu();

        public SearchAndFilter()
        {

        }

        public List<IMenuItem> filterSearch(List<IMenuItem> items, string search)
        {
            List<IMenuItem> filteredMenu = new List<IMenuItem>();
            foreach(IMenuItem item in items)
            {
                if (item.ToString() == search)
                    filteredMenu.Add(item);
            }
            return filteredMenu;
        }

        public List<IMenuItem> filterCategories(List<string> categories)
        {
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
            List<IMenuItem> filtered = new List<IMenuItem>();
            foreach(IMenuItem item in items)
            {
                List<string> ingredients = item.Ingredients;
                foreach(string ing in filtIng)
                {
                    if (ingredients.Contains(ing))
                        filtered.Add(item);
                }
            }
            return filtered;
        }
    }
}
