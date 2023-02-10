using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    public class Item
    {
        private string _name;
        private int _price;
        private string _place;
        private byte _number;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Place
        {
            get { return _place; }
            set { _place = value; }
        }

        public byte Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public Item(string name, int price, string place, byte number)
        {
            _name = name;
            _price = price;
            _place = place;
            _number = number;
        }
    }
}
