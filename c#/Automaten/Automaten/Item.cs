namespace Automaten
{
    public class Item //Item class
    {
        public int id; //Making the int id viable
        public int price; //Making the int price viable
        public string name; //Making the string name viable
        public int amount { get; set; } //Makinzg the int amount vibale, with a get; set; to regulate the amount when a item is bought
        public string flavor; //Making the string flavor viable
        public string size; //Making the string size viable

        public Item(int id, int price, string name, int amount, string flavor, string size) //Constructor for making a Item
        {
            this.id = id; //Sets this.it to id
            this.price = price; //Sets this.price to price
            this.name = name; //Sets this.name to name
            this.amount = amount; //Sets this.amount to amount
            this.flavor = flavor; //Sets this.flavor to flavor
            this.size = size; //Sets this.size to size
        }
    }

    public class Chip : Item //Chip class with inheritance from Item
    {
        public Chip(int id, int price, string name, int amount, string flavor, string size):base(id,price,name,amount,flavor,size) { }  //Constructor for making a Chip
    }

    public class Drink : Item //Drink class with inheritance from Item
    {
        public Drink(int id, int price, string name, int amount, string flavor, string size) : base(id, price, name, amount, flavor, size) { }  //Constructor for making a Drink
    }
}
