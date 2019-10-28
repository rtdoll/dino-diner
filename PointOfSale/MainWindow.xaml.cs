/* MainWindow.xaml.cs
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OrderControl.NavigationService = OrderInterface.NavigationService;
            Order order = (Order)DataContext;
            order.Add(new Fryceritops());
            Tyrannotea tea = new Tyrannotea();
            order.Add(tea);
            tea.AddLemon();

        }

        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            SetFrameDataContext();
        }

        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            SetFrameDataContext();
        }

        private void SetFrameDataContext()
        {
            if (OrderInterface.Content is FrameworkElement element)
            {
                element.DataContext = OrderInterface.DataContext;
            }
        }

        private void OnDone(object sender, NavigationEventArgs args)
        {
            if (OrderInterface.NavigationService.CanGoBack)
                OrderInterface.NavigationService.GoBack();
            else
                OrderInterface.NavigationService.Navigate(new MenuCategorySelection());
        }

    }
}
