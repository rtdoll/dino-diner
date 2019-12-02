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

        public Brontowurst bw = new Brontowurst();
        public DinoNuggets dn = new DinoNuggets();
        public PrehistoricPBJ pbj = new PrehistoricPBJ();
        public PterodactylWings pw = new PterodactylWings();
        public SteakosaurusBurger sb = new SteakosaurusBurger();
        public TRexKingBurger trex = new TRexKingBurger();
        public VelociWrap vw = new VelociWrap();

        public Fryceritops ft = new Fryceritops();
        public MeteorMacAndCheese mmc = new MeteorMacAndCheese();
        public MezzorellaSticks ms = new MezzorellaSticks();
        public Triceritots tt = new Triceritots();

        public JurassicJava jj = new JurassicJava();
        public Sodasaurus soda = new Sodasaurus();
        public Tyrannotea tea = new Tyrannotea();
        public Water water = new Water();

        public void OnGet()
        {
            
        }

        public void OnPost(string search, List<string> CategoryCheckbox, float minimumPrice, float maximumPrice)
        {

        }
    }
}