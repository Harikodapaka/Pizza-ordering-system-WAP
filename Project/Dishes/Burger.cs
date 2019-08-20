using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Dishes
{
    public class Burger : Dish
    {
        public Burger(int quantity, string name, string toppings, string size) : base(quantity, name, toppings, size)
        {
        }
        public Burger() : base() { }
        public override void OrderDish()
        {
            throw new NotImplementedException();
        }
    }
}
