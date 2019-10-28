/* ComboSelection.xaml.cs
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public Entree Entree { get; set; }

        public Side Side { get; set; }

        public Drink Drink { get; set; }
        public ComboSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Create new CustomizeCombo page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomizeCombo(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
        
    }
}
