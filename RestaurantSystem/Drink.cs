using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Menu
{
    public class Drink : MenuItem
    {
        public int VolumeMl { get; }
        public bool Alcoholic { get; }

        public Drink(string name, int volumeMl, bool alcoholic, decimal price)
            : base(name, price, Category.Напій)
        {
            VolumeMl = volumeMl;
            Alcoholic = alcoholic;
        }

        public override string ToString()
        {
            string alcohol = Alcoholic ? "з алкоголем" : "без алкоголю";
            return $"{Name} ({VolumeMl} мл, {alcohol}) - {Price} грн";
        }
    }
}
