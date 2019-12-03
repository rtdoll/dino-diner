using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu Menu { get; } = new Menu();

        public List<IMenuItem> AvailableMenuItems = new List<IMenuItem>();

        [BindProperty]
        public string Search { get; set; }

        [BindProperty]
        public List<string> OrderCategory { get; set; } = new List<string>();

        [BindProperty]
        public float? MinimumPrice { get; set; }        

        [BindProperty]
        public float? MaximumPrice { get; set; }

        [BindProperty]
        public List<string> ExcludeIngredients { get; set; } = new List<string>();

        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            AvailableMenuItems = Menu.AvailableMenuItems;
            SearchAndFilter filter = new SearchAndFilter();
            if (OrderCategory.Count > 0)
                AvailableMenuItems = filter.filterCategories(OrderCategory);

            if (Search != null)
                AvailableMenuItems = filter.filterSearch(AvailableMenuItems, Search);

            AvailableMenuItems = filter.filterByPrice(AvailableMenuItems, MinimumPrice, MaximumPrice);

            AvailableMenuItems = filter.filterIngredients(AvailableMenuItems, ExcludeIngredients);
        }
    }
}