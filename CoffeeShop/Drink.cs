using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Drink
    {
        private string _name;
        private int _price;
        private bool _isLarge;
        private bool _isDecaf;
        public string Name { get { return Name; } set { Name = value; } }
        public int Price { get { return Price; } set { Price = value; } }
        public bool IsLarge { get { return IsLarge; } set { IsLarge = value; } }
        public bool IsDecaf { get { return IsDecaf; } set { IsDecaf = value; } }

        public Drink(string name,int price,bool islarge,bool isdecaf)
        {
            _name = name;
            _price = price;
            _isLarge = islarge;
            _isDecaf = isdecaf;
        }
        public double FinalPrice()
        {
            if(_isLarge == IsLarge)
            {
                 double aaa = _price * 0.7;
            }
            return Math.Round(_price * 0.7,0); 
        }
        public string Describe()
        {
            bool size = IsLarge;
            bool decaf = IsDecaf;

            return $"{Name}, {size}, {decaf}: {FinalPrice} Ft";
        }

    }

}
}
