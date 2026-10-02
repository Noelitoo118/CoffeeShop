using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Order
    {
        private string _buyer;
        private int _orderedDrink;
        private int _quantity;

        public string Buyer { get { return Buyer; }set { Buyer = value; } }
        public string OrderedDrink { get { return OrderedDrink; }set { OrderedDrink = value; } }
        public string Quantity { get { return Quantity; }set { Quantity = value; } }

        public Order(string buyer, int ordereddrink, int quantity)
        {
            _buyer = buyer;
            _orderedDrink = ordereddrink;
            _quantity = quantity;
        }
        public int HasDicount()
        {
            (int)Buyer * 0.9;
        }
        public int TotalPrice()
        {
            int price = _orderedDrink * _quantity;

            if (Buyer)
            {
                price = (int)(price * 0.9);
            }

            return price;
        }

        public int Pay()
        {
            int price = TotalPrice();

            return price;
        }

    }
}
