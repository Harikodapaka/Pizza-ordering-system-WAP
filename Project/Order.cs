using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Project.Dishes;
using Project.Payment;

namespace Project
{
    [Serializable]
    [XmlRoot(Namespace = "Project")]
    [XmlInclude(typeof(Customer))]
    [XmlInclude(typeof(Dish))]
    [XmlInclude(typeof(PaymentInformation))]

    public class Order : IComparable<Order>
    {
        private Customer customerr;
        private List<Dish> dishes;
        private PaymentInformation paymentInfo;
        private DateTime orderDateTime;
        private string totalPrice;
        private DateTime estimatedTime;
        private int orderNumber;

        public Customer Customerr { get => customerr; set => customerr = value; }
        public List<Dish> Dishes { get => dishes; set => dishes = value; }
        public DateTime OrderDateTime { get => orderDateTime; set => orderDateTime = value; }
        public string TotalPrice { get => totalPrice; set => totalPrice = value; }
        public DateTime EstimatedTime { get => estimatedTime; set => estimatedTime = value; }
        public int OrderNumber { get => orderNumber; set => orderNumber = value; }
        public PaymentInformation PaymentInfo { get => paymentInfo; set => paymentInfo = value; }

        public Order() { }

        public Order(Customer customerr, List<Dish> dishes, PaymentInformation paymentInfo, DateTime orderDateTime, string totalPrice, DateTime estimatedTime, int orderNumber)
        {
            this.Customerr = customerr;
            this.Dishes = dishes;
            this.PaymentInfo = paymentInfo;
            this.OrderDateTime = orderDateTime;
            this.TotalPrice = totalPrice;
            this.EstimatedTime = estimatedTime;
            this.OrderNumber = orderNumber;
        }

        public int PizzasCount
        {
            get {
                if (Dishes != null && Dishes.Count > 0)
                {
                    Dish dish = Dishes.Find(x => x.GetType() == typeof(Pizza));
                    if (dish != null) { return dish.Quantity; } else { return 0; }
                }
                else { return 0; }
            }
        }
        public int BurgersCount
        {
            get
            {
                if (Dishes != null && Dishes.Count > 0)
                {
                    Dish dish = Dishes.Find(x => x.GetType() == typeof(Burger));
                    if (dish != null) { return dish.Quantity; } else { return 0; }
                }
                else { return 0; }
            }
        }
        public int SandwitchesCount
        {
            get
            {
                if (Dishes != null && Dishes.Count > 0)
                {
                    Dish dish = Dishes.Find(x => x.GetType() == typeof(Sandwich));
                    if (dish != null) { return dish.Quantity; } else { return 0; }
                }
                else { return 0; }
            }
        }

        public int CompareTo(Order obj)
        {
            if (obj == null) return 1;

            if (obj is Order remainingOrders)
                return EstimatedTime.CompareTo(remainingOrders.EstimatedTime);
            else
                throw new ArgumentException("Something went wrong with order");
        }
    }
}
