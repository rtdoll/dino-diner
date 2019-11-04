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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        /// <summary>
        /// private backing variable for wurst
        /// </summary>
        private TRexKingBurger trex;

        /// <summary>
        /// Initialize page
        /// </summary>
        /// <param name="wurst"></param>
        public CustomizeTRexKingBurger(TRexKingBurger trex)
        {
            InitializeComponent();
            this.trex = trex;
        }

        /// <summary>
        /// hold bun from order
        /// </summary>
        private void HoldBun(object sender, RoutedEventArgs args)
        {
            trex.HoldBun();
        }

        /// <summary>
        /// hold ketchup from order
        /// </summary>
        private void HoldKetchup(object sender, RoutedEventArgs args)
        {
            trex.HoldKetchup();
        }

        /// <summary>
        /// hold mustard from order
        /// </summary>
        private void HoldMustard(object sender, RoutedEventArgs args)
        {
            trex.HoldMustard();
        }

        /// <summary>
        /// hold pickle from order
        /// </summary>
        private void HoldPickle(object sender, RoutedEventArgs args)
        {
            trex.HoldPickle();
        }

        /// <summary>
        /// Hold Lettuce from order
        /// </summary>
        private void HoldLettuce(object sender, RoutedEventArgs args)
        {
            trex.HoldLettuce();
        }

        /// <summary>
        /// Hold mayo from order
        /// </summary>
        private void HoldMayo(object sender, RoutedEventArgs args)
        {
            trex.HoldMayo();
        }

        /// <summary>
        /// hold onion from order
        /// </summary>
        private void HoldOnion(object sender, RoutedEventArgs args)
        {
            trex.HoldOnion();
        }

        /// <summary>
        /// hold tomato from order
        /// </summary>
        private void HoldTomato(object sender, RoutedEventArgs args)
        {
            trex.HoldTomato();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
