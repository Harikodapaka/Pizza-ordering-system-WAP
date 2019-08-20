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
using System.Windows.Shapes;
using Project.Dishes;

namespace Project
{
    /// <summary>
    /// Interaction logic for PlaceOrder.xaml
    /// </summary>
    public partial class PlaceOrder : Page
    {
        private Order ord = null;
        public PlaceOrder()
        {
            Ord = new Order();
            InitializeComponent();
        }
        public PlaceOrder(Order o)
        {
            InitializeComponent();
            Ord = o;
        }

        public Order Ord { get => ord; set => ord = value; }

        private void onSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SubmitClick(object sender, RoutedEventArgs e)
        {
        }

        private void Tb_Name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
