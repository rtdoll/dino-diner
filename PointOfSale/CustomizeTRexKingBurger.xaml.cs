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
        private void HoldBun()
        {
            trex.HoldBun();
        }

        /// <summary>
        /// hold ketchup from order
        /// </summary>
        private void HoldKetchup()
        {
            trex.HoldKetchup();
        }

        /// <summary>
        /// hold mustard from order
        /// </summary>
        private void HoldMustard()
        {
            trex.HoldMustard();
        }

        /// <summary>
        /// hold pickle from order
        /// </summary>
        private void HoldPickle()
        {
            trex.HoldPickle();
        }

        /// <summary>
        /// Hold Lettuce from order
        /// </summary>
        private void HoldLettuce()
        {
            trex.HoldLettuce();
        }

        /// <summary>
        /// Hold mayo from order
        /// </summary>
        private void HoldMay()
        {
            trex.HoldMayo();
        }

        /// <summary>
        /// hold onion from order
        /// </summary>
        private void HoldOnion()
        {
            trex.HoldOnion();
        }

        /// <summary>
        /// hold tomato from order
        /// </summary>
        private void HoldTomato()
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
