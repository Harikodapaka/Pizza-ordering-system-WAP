using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project.Dishes
{
    [XmlRoot(Namespace = "Project.Dishes")]
    [XmlInclude(typeof(Burger))]
    [XmlInclude(typeof(Pizza))]
    [XmlInclude(typeof(Sandwich))]
    public abstract class Dish : IDish
    {
        private int quantity;
        private string name;
        private string toppings;
        private string size;

        public Dish(int quantity, string name, string toppings, string size)
        {
            this.quantity = quantity;
            this.name = name;
            this.toppings = toppings;
            this.size = size;
        }
        public Dish() { }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Name { get => name; set => name = value; }
        public string Toppings { get => toppings; set => toppings = value; }
        public string Size { get => size; set => size = value; }

        public abstract void OrderDish();
        
    }
}
