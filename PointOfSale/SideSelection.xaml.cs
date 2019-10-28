/* SideSelection.xaml.cs
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {

        public Side Side { get; set; }

        public SideSelection()
        {
            InitializeComponent();
        }

        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
        }

        protected void AddFryceritops(object sender, RoutedEventArgs args)
        {
            Side = new Fryceritops();
            EnableSizeButtons();
        }

        protected void AddTriceritots(object sender, RoutedEventArgs args)
        {
            Side = new Triceritots();
            EnableSizeButtons();
        }

        protected void AddMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            Side = new MezzorellaSticks();
            EnableSizeButtons();
        }

        protected void AddMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            Side = new MeteorMacAndCheese();
            EnableSizeButtons();
        }

        protected void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                order.Add(side);
            }
        }

        protected void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Side != null)
            {
                this.Side.Size = size;
                DisableSizeButtons();
                SelectSide(Side);
                if(NavigationService.CanGoBack)
                    NavigationService.GoBack();
                else
                    NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        protected void OnSelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        protected void OnSelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        protected void OnSelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        protected void EnableSizeButtons()
        {
            BtnSmall.IsEnabled = true;
            BtnMedium.IsEnabled = true;
            BtnLarge.IsEnabled = true;
        }

        protected void DisableSizeButtons()
        {
            BtnSmall.IsEnabled = false;
            BtnMedium.IsEnabled = false;
            BtnLarge.IsEnabled = false;
        }

    }
}
