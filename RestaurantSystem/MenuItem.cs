using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Menu
{
    public abstract class MenuItem
    {
        public string Name { get; }
        public decimal Price { get; }
        public Category Category { get; }

        protected MenuItem(string name, decimal price, Category category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Name} ({Category}) - {Price} грн";
        }
    }
}
