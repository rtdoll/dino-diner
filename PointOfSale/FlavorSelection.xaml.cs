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
        public SodasaurusFlavor Flavor { get; set; }
        public FlavorSelection()
        {
            InitializeComponent();
        }

        protected void SelectCola(object sender, RoutedEventArgs args)
        {
            Flavor = SodasaurusFlavor.Cola;
        }

        protected void SelectOrange(object sender, RoutedEventArgs args)
        {
            Flavor = SodasaurusFlavor.Orange;
        }
        protected void SelectVanilla(object sender, RoutedEventArgs args)
        {
            Flavor = SodasaurusFlavor.Vanilla;
        }
        protected void SelectChocolate(object sender, RoutedEventArgs args)
        {
            Flavor = SodasaurusFlavor.Chocolate;
        }
        protected void SelectRootBeer(object sender, RoutedEventArgs args)
        {
            Flavor = SodasaurusFlavor.RootBeer;
        }

        protected void SelectCherry(object sender, RoutedEventArgs args)
        {
            Flavor = SodasaurusFlavor.Cherry;
        }
        protected void SelectLime(object sender, RoutedEventArgs args)
        {
            Flavor = SodasaurusFlavor.Lime;
        }
    }
}
