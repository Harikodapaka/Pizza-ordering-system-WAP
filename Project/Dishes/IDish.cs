using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Dishes
{
    public interface IDish
    {
        int Quantity { get; set; }
        string Name { get; set; }
        string Toppings { get; set; }
        string Size { get; set; }
        void OrderDish();
    }
}
