using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project.List
{
    [Serializable]
    [XmlRoot("OrdersList")]
    public class OrdersList
    {
        [XmlArray("Orders")]
        [XmlArrayItem("Order", typeof(Project.Order))]
        private static OrdersList _instance;
        private ObservableCollection<Order> orders = new ObservableCollection<Order>();

        // Constructor is 'protected'
        protected OrdersList()
        {
        }

        public ObservableCollection<Order> Orders { get => orders; set => orders = value; }
        //Returning instance of OrderList
        public static OrdersList Instance()
        {
            if (_instance == null)
            {
                _instance = new OrdersList();
            }

            return _instance;
        }

        public void Add(Order c)
        {
            Orders.Add(c);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public int Count()
        {
            return Orders.Count;
        }

        public void Clear()
        {
            Orders.Clear();
        }
    }
}
