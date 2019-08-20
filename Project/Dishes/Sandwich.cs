using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Dishes
{
    public class Sandwich : Dish
    {
        public Sandwich(int quantity, string name, string toppings, string size) : base(quantity, name, toppings, size)
        {
        }
        public Sandwich():base() { }
        public override void OrderDish()
        {
            throw new NotImplementedException();
        }
    }
}
