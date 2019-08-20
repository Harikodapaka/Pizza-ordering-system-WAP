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
using Project.List;
using Project.Dishes;
using Project.Payment;
using System.IO;
using System.Xml.Serialization;

namespace Project
{
    /// <summary>
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : Page
    {
        OrdersList ordersList = OrdersList.Instance();
        public OrderList()
        {
            InitializeComponent();
            List<Dish> d = new List<Dish>();
            d.Add(new Pizza(5,"Pizza Name", "Pizza Topings", "Small"));
            d.Add(new Burger(3, "Burger Name", "Pizza Topings", "Medium"));
            ordersList.Orders.Add(new Order(new Customer("Hari","9090909090","fucking adress"), d, new PaymentInformation("Debit", "123", "12/12"), DateTime.Now, "120.90", DateTime.Now,12));
            fooditemsgrid.ItemsSource = ordersList.Orders;   
        }
        private void Btn_WriteToXML_Click(object sender, RoutedEventArgs e)
        {
            TextWriter tw = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(OrdersList), "Project.List");
                tw = new StreamWriter("Orders.xml");
                serializer.Serialize(tw, ordersList);
                ordersList.Orders.Clear();
                MessageBox.Show("XML saved!! You can read from file...");
                tw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (tw != null)
                {
                    tw.Close();
                }
            }
        }

        private void Btn_ReadToXML_Click(object sender, RoutedEventArgs e)
        {
            StreamReader reader = null;
            try
            {
                string path = "Orders.xml";
                XmlSerializer serializer = new XmlSerializer(typeof(OrdersList), "Project.List");
                reader = new StreamReader(path);
                ordersList = (OrdersList)serializer.Deserialize(reader);
                if (fooditemsgrid.ItemsSource != ordersList.Orders)
                {
                    fooditemsgrid.ItemsSource = ordersList.Orders;
                }
                MessageBox.Show("XML Readed!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        private void Btn_Search_Click(object sender, RoutedEventArgs e)
        {
            string name = TB_Name.Text;
            int orderNumber;
            string sym = (Cb_AndOr.SelectionBoxItem.ToString() == "And") ? "&&" : "||";
            if (name.Length > 0 && int.TryParse(TB_OrderNumber.Text, out orderNumber))
            {
                if( sym == "&&")
                {
                    var query = from O in ordersList.Orders
                                where O.OrderNumber == orderNumber && O.Customerr.Name == name
                                orderby O.OrderNumber ascending
                                select O;
                    fooditemsgrid.ItemsSource = query;
                }
                else
                {
                    var query = from O in ordersList.Orders
                                where O.OrderNumber == orderNumber || O.Customerr.Name == name
                                orderby O.OrderNumber ascending
                                select O;
                    fooditemsgrid.ItemsSource = query;
                }

            }
            else
            {
                MessageBox.Show("Enter Valid Inputs!!");
            }
        }

        private void Btn_EditClick(object sender, RoutedEventArgs e)
        {
            Order order = (fooditemsgrid.SelectedItem as Order);
            PlaceOrder p = new PlaceOrder(order);
            GlobalClass.mainWindow.Pageload(p);
        }

        private void Btn_DeleteClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult boxResult = MessageBox.Show("You want to delete order!", "Are you sure?", MessageBoxButton.YesNo);
            if(boxResult == MessageBoxResult.Yes)
            {
                Order order = (fooditemsgrid.SelectedItem as Order);
                ordersList.Orders.Remove(order);
            }
        }
    }
}
