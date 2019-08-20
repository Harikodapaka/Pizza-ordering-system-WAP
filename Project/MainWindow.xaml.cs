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

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Pageload(Page pageToLoad)
        {
            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            MainFrame.Content = pageToLoad;
        }
        private void PlaceNewOrder_Click(object sender, RoutedEventArgs e)
        {
            PlaceOrder showorder = new PlaceOrder();
            Pageload(showorder);
        }

        private void OrderNewList_Click(object sender, RoutedEventArgs e)
        {
            OrderList orderlist = new OrderList();
            Pageload(orderlist);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GlobalClass.mainWindow = this;
        }
    }
    public static class GlobalClass
    {
        public static MainWindow mainWindow;
    }
}
