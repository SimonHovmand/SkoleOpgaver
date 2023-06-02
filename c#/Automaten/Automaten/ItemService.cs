namespace Automaten
{
    internal class ItemService
    {
        public List<Item> items = new List<Item>(); //Making a list to store the items

        public ItemService() //Constructor making the items
        {
            items.Add(new Chip(1, 23, "KimsChips", 6, "Bacon", "Medium"));
            items.Add(new Chip(2, 29, "KimsChips", 7, "Bacon", "Large"));
            items.Add(new Chip(3, 15, "KimsChips", 8, "Barbaque", "Medium"));
            items.Add(new Chip(4, 29, "KimsChips", 13, "Barbaque", "Large"));
            items.Add(new Drink(5, 18, "FaxeKondi", 16, "Normal", "0.5L"));
            items.Add(new Drink(6, 18, "FaxeKondi", 23, "Light", "0.5L"));
            items.Add(new Drink(7,18, "FaxeKondi", 35, "Ananas", "0.5L"));
        }

        public void RemoveAmount(int choise) //Method to remove a item (the amount of items) when 1 is bought
        {
            foreach (Item item in items) //Running a foreach for every stored data in the list
            {
                if (choise == item.id) //If the choise is equal to the item id 
                {
                    item.amount -= 1; //Removing 1 from the amount from the item list
                }
            }
        }
    }
}
