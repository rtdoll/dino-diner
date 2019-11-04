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
    /// Interaction logic for CustomizeSteakosaurus.xaml
    /// </summary>
    public partial class CustomizeSteakosaurus : Page
    {
        /// <summary>
        /// private backing variable for wurst
        /// </summary>
        private SteakosaurusBurger sb;

        /// <summary>
        /// Initialize page
        /// </summary>
        /// <param name="wurst"></param>
        public CustomizeSteakosaurus(SteakosaurusBurger sb)
        {
            InitializeComponent();
            this.sb = sb;
        }

        /// <summary>
        /// hold bun from wurst
        /// </summary>
        private void HoldBun(object sender, RoutedEventArgs args)
        {
            sb.HoldBun();
        }

        /// <summary>
        /// hold ketchup from order
        /// </summary>
        private void HoldKetchup(object sender, RoutedEventArgs args)
        {
            sb.HoldKetchup();
        }

        /// <summary>
        /// hold mustard from order
        /// </summary>
        private void HoldMustard(object sender, RoutedEventArgs args)
        {
            sb.HoldMustard();
        }

        /// <summary>
        /// hold pickle from order
        /// </summary>
        private void HoldPickle(object sender, RoutedEventArgs args)
        {
            sb.HoldPickle();
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
