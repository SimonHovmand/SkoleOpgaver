using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    public class Item
    {

        public int id;
        public int price;
        public string name;
        public int amount { get; set; }
        public string flavor;
        public string size;

        public Item(int id, int price, string name, int amount, string flavor, string size)
        {
            this.id = id;
            this.price = price;
            this.name = name;
            this.amount = amount;
            this.flavor = flavor;
            this.size = size;
        }
    }

    public class Chip : Item
    {
        public Chip(int id, int price, string name, int amount, string flavor, string size):base(id,price,name,amount,flavor,size) { }
    }

    public class Drink : Item
    {
        public Drink(int id, int price, string name, int amount, string flavor, string size) : base(id, price, name, amount, flavor, size) { }
    }
}
