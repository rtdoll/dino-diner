/* FlavorSelection.xaml.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        /// <summary>
        /// Gets and Sets drink, should always be sodasaurus
        /// </summary>
        public Drink Drink { get; set; }

        /// <summary>
        /// new flavor selection window with selected drink
        /// </summary>
        /// <param name="Drink"></param>
        public FlavorSelection(Drink Drink)
        {
            InitializeComponent();
            this.Drink = Drink;
        }

        /// <summary>
        /// Changes Flavor to Cola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectCola(object sender, RoutedEventArgs args)
        {
            if(Drink is Sodasaurus Soda)
            {
                Soda.NewFlavor(SodasaurusFlavor.Cola);
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Changes Flavor to Orange
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectOrange(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus Soda)
            {
                Soda.NewFlavor(SodasaurusFlavor.Orange);
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Changes Flavor to Vanilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectVanilla(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus Soda)
            {
                Soda.NewFlavor(SodasaurusFlavor.Vanilla);
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Changes Flavor to Chocolate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectChocolate(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus Soda)
            {
                Soda.NewFlavor(SodasaurusFlavor.Chocolate);
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Changes Flavor to RootBeer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectRootBeer(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus Soda)
            {
                Soda.NewFlavor(SodasaurusFlavor.RootBeer);
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Changes Flavor to Cherry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectCherry(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus Soda)
            {
                Soda.NewFlavor(SodasaurusFlavor.Cherry);
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Changes Flavor to Lime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectLime(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus Soda)
            {
                Soda.NewFlavor(SodasaurusFlavor.Lime);
            }
            NavigationService.GoBack();
        }
    }
}
