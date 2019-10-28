/* EntreeSelection.xaml.cs
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        public Entree Entree { get; set; }
        public EntreeSelection()
        {
            InitializeComponent();
        }

        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            Entree = entree;
        }

        protected void AddBrontowurst(object sender, RoutedEventArgs args)
        {
            SelectEntree(new Brontowurst());
        }

        protected void AddDinoNuggets(object sender, RoutedEventArgs args)
        {
            SelectEntree(new DinoNuggets());
        }

        protected void AddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
            }
        }

        protected void AddPterodactylWings(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PterodactylWings());
        }

        protected void AddSteakosaurus(object sender, RoutedEventArgs args)
        {
            SelectEntree(new SteakosaurusBurger());
        }

        protected void AddTrexKing(object sender, RoutedEventArgs args)
        {
            SelectEntree(new TRexKingBurger());
        }

        protected void AddVelociWrap(object sender, RoutedEventArgs args)
        {
            SelectEntree(new VelociWrap());
        }

        protected void SelectEntree(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.Add(entree);
                if(NavigationService.CanGoBack)
                    NavigationService.GoBack();
                else
                    NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
