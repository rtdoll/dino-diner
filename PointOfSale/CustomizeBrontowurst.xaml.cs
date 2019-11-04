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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        /// <summary>
        /// private backing variable for wurst
        /// </summary>
        private Brontowurst wurst;

        /// <summary>
        /// Initialize page
        /// </summary>
        /// <param name="wurst"></param>
        public CustomizeBrontowurst(Brontowurst wurst)
        {
            InitializeComponent();
            this.wurst = wurst;
        }

        /// <summary>
        /// hold bun from wurst
        /// </summary>
        private void HoldBun()
        {
            wurst.HoldBun();
        }

        /// <summary>
        /// hold peppers from wurst
        /// </summary>
        private void HoldPeppers()
        {
            wurst.HoldPeppers();
        }

        /// <summary>
        /// Hold onion from wurst
        /// </summary>
        private void HoldOnions()
        {
            wurst.HoldPeppers();
        }

        /// <summary>
        /// return to previous page
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
