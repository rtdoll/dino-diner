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

        /// <summary>
        /// Create an instance of the drinkselection page
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Create an instance of drink selection page with a drink that has been selected
        /// </summary>
        /// <param name="drink">selected drink</param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            Drink = drink;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
                NavigationService.Navigate(new FlavorSelection(Drink));
        }

        /// <summary>
        /// Select Size of drink
        /// </summary>
        /// <param name="size">New size</param>
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

        /// <summary>
        /// Select drink for order
        /// </summary>
        /// <param name="Drink">New Drink</param>
        protected void SelectDrink(Drink Drink)
        {
            if(DataContext is Order order)
            {
                order.Add(Drink);
                this.Drink = Drink;
            }   
        }

        /// <summary>
        /// Enable size buttons
        /// </summary>
        protected void EnableSizeButtons()
        {
            BtnSmall.IsEnabled = true;
            BtnMedium.IsEnabled = true;
            BtnLarge.IsEnabled = true;
        }

        /// <summary>
        /// Disable size buttons
        /// </summary>
        protected void DisableSizeButtons()
        {
            BtnSmall.IsEnabled = false;
            BtnMedium.IsEnabled = false;
            BtnLarge.IsEnabled = false;
        }

        /// <summary>
        /// change size of drink to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        /// <summary>
        /// change size of drink to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// change size of drink to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        /// <summary>
        /// Add Ice to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnAddIce(object sender, RoutedEventArgs args)
        {
            Drink.AddIce();
        }

        /// <summary>
        /// Hold Ice from order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnHoldIce(object sender, RoutedEventArgs args)
        {
            Drink.HoldIce();
        }

        /// <summary>
        /// Add Lemon to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnAddLemon(object sender, RoutedEventArgs args)
        {
            if (Drink is Water water)
                water.AddLemon();
            if(Drink is Tyrannotea tea)
                tea.AddLemon();
        }
        
        /// <summary>
        /// Add sweetener to tea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnAddSweetener(object sender, RoutedEventArgs args)
        {
            if (Drink is Tyrannotea Tea)
                Tea.AddSweetener();
        }

        /// <summary>
        /// change java to decaf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnDecaf(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava java)
                java.DecafCoffee();
        }

        /// <summary>
        /// Leave room for cream on java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnRoomForCream(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava java)
                java.LeaveRoomForCream();
        }

        /// <summary>
        /// Navigates to new flavor selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection(Drink));
        }


    }
}
