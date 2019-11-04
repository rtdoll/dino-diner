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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        /// <summary>
        /// private backing variable for VelciWrap
        /// </summary>
        private VelociWrap rap;

        /// <summary>
        /// Initialize page
        /// </summary>
        /// <param name="wurst"></param>
        public CustomizeVelociWrap(VelociWrap rap)
        {
            InitializeComponent();
            this.rap = rap;
        }

        /// <summary>
        /// hold dressing from order
        /// </summary>
        private void HoldDressing(object sender, RoutedEventArgs args)
        {
            rap.HoldDressing();
        }

        /// <summary>
        /// hold Lettuce from order
        /// </summary>
        private void HoldLettuce(object sender, RoutedEventArgs args)
        {
            rap.HoldLettuce();
        }

        /// <summary>
        /// hold cheese from order
        /// </summary>
        private void HoldCheese(object sender, RoutedEventArgs args)
        {
            rap.HoldCheese();
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
