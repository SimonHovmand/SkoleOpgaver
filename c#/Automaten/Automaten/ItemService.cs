using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    internal class ItemService
    {
        public List<Item> items = new List<Item>();

        public ItemService()
        {
            items.Add(new Chip(1, 23, "KimsChips", 6, "Bacon", "Medium"));
            items.Add(new Chip(2, 29, "KimsChips", 7, "Bacon", "Large"));
            items.Add(new Chip(3, 15, "KimsChips", 8, "Barbaque", "Medium"));
            items.Add(new Chip(4, 29, "KimsChips", 13, "Barbaque", "Large"));
            items.Add(new Drink(5, 18, "FaxeKondi", 16, "Normal", "0.5L"));
            items.Add(new Drink(6, 18, "FaxeKondi", 23, "Light", "0.5L"));
            items.Add(new Drink(7,18, "FaxeKondi", 35, "Ananas", "0.5L"));
        }

        public void RemoveAmount(int choise)
        {
            foreach (Item item in items)
            {
                if (item.id == choise)
                {
                    item.amount -= 1;
                }
            }
        }

    }
}
