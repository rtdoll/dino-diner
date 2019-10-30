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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public Drink Drink { get; set; }


        public DrinkSelection()
        {
            InitializeComponent();
        }

        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            Drink = drink;
        }

        public void SelectJava(object sender, RoutedEventArgs args)
        {
            HideBoxes();
            EnableSizeButtons();
            Drink = new JurassicJava();
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
            EnableSizeButtons();
            Drink = new Sodasaurus();
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
            EnableSizeButtons();
            Drink = new Tyrannotea();
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
            EnableSizeButtons();
            Drink = new Water();
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
            if(Drink is Sodasaurus)
                NavigationService.Navigate(new FlavorSelection());
        }

        protected void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Drink != null)
            {
                this.Drink.Size = size;
                DisableSizeButtons();
                SelectDrink(Drink);
                if(NavigationService.CanGoBack)
                    NavigationService.GoBack();
                else
                    NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        protected void SelectDrink(Drink drink)
        {
            if(DataContext is Order order)
            {
                order.Add(drink);
            }   
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

        protected void OnAddIce(object sender, RoutedEventArgs args)
        {
            Drink.AddIce();
        }

        protected void OnAddLemon(object sender, RoutedEventArgs args)
        {

        }

        protected void OnAddFlavor(object sender, RoutedEventArgs args)
        {

        }

        protected void OnAddSweetener(object sender, RoutedEventArgs args)
        {

        }

        protected void OnDecaf(object sender, RoutedEventArgs args)
        {

        }

        protected void OnRoomForCream(object sender, RoutedEventArgs args)
        {

        }

        protected void OnFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
    }
}
