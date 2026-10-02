using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Customer
    {
        private string _name;
        private int _points;
        private bool _isStudent;

        public string Name {get { return _name; }set { _name = value; } }

        public int Points { get { return _points; } set { _points = value; } }

        public bool IsStudent { get { return _isStudent; } set { _isStudent = value; } }
        public Customer(string name, bool isStudent) 
        {
            _name = name;
            _isStudent = isStudent; _points = 0; 
        }

        public void AddPoints(int amount)
        {
            if (_isStudent)
            {
                _points += amount * 2; 
            }
            else
            {
                _points += amount;
            }
        }
        public bool HasDiscount()
        {
            return _points >= 10;
        }
    }
}
