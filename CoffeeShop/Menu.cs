using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Menu
    {
        private List<Drink> _drinks;

        public List<Drink> Drinks
        {
            get { return _drinks; }
        }

        public Menu()
        {
            _drinks = new List<Drink>();
        }

        public void AddDrink(Drink drink)
        {
            _drinks.Add(drink);
        }

        public int DecafCount()
        {
            int count = 0;
            foreach (var drink in _drinks)
            {
                if (drink.IsDecaf)
                {
                    count++;
                }
            }
            return count;
        }
        public int AveragePrice()
        {
            if (_drinks.Count == 0)
            {
                return 0;
            }

            double sum = 0;
            foreach (var drink in _drinks)
            {
                sum += drink.FinalPrice();
            }

            return (int)(sum / _drinks.Count);
        }
    }
}


