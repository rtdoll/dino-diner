/* DrinkSelection.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
        }

        public void SelectJava(object sender, RoutedEventArgs args)
        {
            HideBoxes();
            JavaCream.Visibility = Visibility.Visible;
            JavaDecaf.Visibility = Visibility.Visible;
            JavaIce.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// Hide all boxes for drink options
        /// </summary>
        private void HideBoxes()
        {
            JavaCream.Visibility = Visibility.Hidden;
            JavaDecaf.Visibility = Visibility.Hidden;
            JavaIce.Visibility = Visibility.Hidden;
            SodaFlavor.Visibility = Visibility.Hidden;
            SodaIce.Visibility = Visibility.Hidden;
            TeaIce.Visibility = Visibility.Hidden;
            TeaLemon.Visibility = Visibility.Hidden;
            TeaSweet.Visibility = Visibility.Hidden;
            WaterLemon.Visibility = Visibility.Hidden;
            WaterIce.Visibility = Visibility.Hidden;
        }
        /// <summary>
        /// Make options visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectSoda(object sender, RoutedEventArgs args)
        {
            HideBoxes();
            SodaFlavor.Visibility = Visibility.Visible;
            SodaIce.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// Make options visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectTea(object sender, RoutedEventArgs args)
        {
            HideBoxes();
            TeaIce.Visibility = Visibility.Visible;
            TeaLemon.Visibility = Visibility.Visible;
            TeaSweet.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// Make options visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectWater(object sender, RoutedEventArgs args)
        {
            HideBoxes();
            WaterLemon.Visibility = Visibility.Visible;
            WaterIce.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// Create new FlavorSelection Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
    }
}
