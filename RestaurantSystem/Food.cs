using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Menu
{
    public class Food : MenuItem
    {
        public Food(string name, decimal price, Category category)
            : base(name, price, category) { }
    }
}
