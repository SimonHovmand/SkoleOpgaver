namespace Automaten
{

    internal class GUIService : IGUIService
    {
        public void Start() //Start method
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=============================");
            Console.WriteLine("");
            Console.WriteLine("          AUTOMATEN");
            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public int InsertCard() //Method to insertcard number
        {
            int cardnumber = 0;
            Console.WriteLine("Indtast dit kort nr."); 

            Console.ForegroundColor = ConsoleColor.Red;
            String Result = Console.ReadLine(); //Reads the console line and stores it in a string viable (result)
            Console.ForegroundColor = ConsoleColor.White;


            while (!Int32.TryParse(Result, out cardnumber)) //Checks if the entered data is only numbers
            {
                Console.WriteLine("Der skete en fejl, indtast dit kort nr."); //If there is anything than numbers they have to correct that

                Console.ForegroundColor = ConsoleColor.Red;
                Result = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

            return cardnumber; //Returns the entered cardnumber to later use
        }

        public void ShowItems (List<Item> a) //Method to show the items in the list, with a refrence to the Item list
        {
            foreach (Item item in a) //Running a foreach for every stored data in the list
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"ID: {item.id} - Navn: {item.name} - Pris: {item.price} - Smag: {item.flavor} - Størrelse: {item.size} - Antal: {item.amount}"); //Printing the values of the item in the list
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public int SelectItem() //Method for the user to select a item
        {
            Console.WriteLine("Indtast ID'et på den varer du ønsker.");

            int choise = 0;

            Console.ForegroundColor = ConsoleColor.Red;
            String Line = Console.ReadLine(); //Storing the user input in the Line viable
            Console.ForegroundColor = ConsoleColor.White;

            while (!Int32.TryParse(Line, out choise)) //Checks if the entered data is only numbers
            {
                Console.WriteLine("Der skete en fejl, indtast ID'et på den varer du ønsker."); //If there is anything than numbers they have to correct that

                Console.ForegroundColor = ConsoleColor.Red;
                Line = Console.ReadLine(); //Storing the user input in Line viable
                Console.ForegroundColor = ConsoleColor.White;
            }

            return choise; //Returns the entered choise to later use
        }

        public void ShowSelectedItem(int choise, List<Item> a) //Method to show the user what they have choosen, with a refrence to the choise viable and the Item list
        {
            int counter= 1;

            foreach (Item item in a) //Running a foreach for every stored data in the list
            {
                if (counter < a.Count) //Checks if the item exist
                {
                    if (choise == item.id) //If the choise is equal to the item id 
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Du har valgt {item.name} {item.flavor} {item.size} til {item.price}dk.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        counter++; //Adds 1 to the counter
                    }
                } else {
                    Console.WriteLine("Varen findes ikke!");
                    break;
                }
            }
        }

        public string BuyItem() //Method to buy the item or cancel
        {
            Console.WriteLine("Ønsker du at købe denne varer? Y/N.");
            Console.ForegroundColor = ConsoleColor.Red;
            return Console.ReadLine().ToUpper(); //Returns the value to be used to check if the user wants to buy in Controller.cs - RemoveItem
        }

        public void Confirmation(int choise, int cardnumber, List<Item> a) //Method to confirm the buy
        {
            int counter = 1;

            foreach (Item item in a) //Running a foreach for every stored data in the list
            {
                if (counter < a.Count)  //Checks if the item exist
                {
                    if (choise == item.id) //If the choise is equal to the item id 
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Du har købt {item.name} {item.flavor} {item.size} for {item.price}dk."); //Confirming the bought item
                        Console.WriteLine($"Der er blevet trukket {item.price}dk fra kreditkort nr {cardnumber}."); //Print how much money has been withdrawn and from what cardnumber
                    } else {
                        counter++; //Adds 1 to the counter
                    }
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Varen findes ikke!");
                }
            }
        }
    }
}