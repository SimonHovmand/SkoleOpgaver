using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();

            items.Add(new Item("Coca", 23, "D1", 3));
            items.Add(new Item("Fanta", 21, "D2", 4));
            items.Add(new Item("Pepsi", 23, "D3", 2));
            items.Add(new Item("MarsBar", 24, "D4", 15));
            items.Add(new Item("Twix", 57, "D5", 18));

            bool validItem = false;

            while (true)
            {
                Console.WriteLine("Velkommen til Simon's Automat");
                Console.WriteLine("Ønsker du at købe noget: Y/N");
                string choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "Y":
                        Console.WriteLine("Antal - Varer - Pris - Plads");
                        foreach (Item item in items)
                        {
                            Console.WriteLine(item.Number + " - " + item.Name + " - " + item.Price + " DKK - " + item.Place);
                        }
                        Console.WriteLine("Indtast pladsen på den varer du ønsker at købe.");
                        string buy = Console.ReadLine().ToUpper();

                        foreach (Item item in items)
                        {
                            if (buy == item.Place)
                            {
                                validItem = true;
                                break;
                            }
                            else
                            {
                                validItem = false;
                            }
                        }

                        if (validItem == true)
                        {
                            
                        }
                        else
                        {
                            Console.WriteLine("NEJ");
                        }

                        break;
                    case "N":
                        Calculate(items);
                        break;
                    case "ADMIN":
                        Console.WriteLine("ADMIN");
                        break;
                }
            }
        }

        static bool Calculate(List<Item> myListOfItems)
        {
            myListOfItems - 1;
            return false;
        }
    }
}
