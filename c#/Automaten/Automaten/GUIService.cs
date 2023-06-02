using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{

    internal class GUIService : IGUIService
    {
        public GUIService() { }

        public int InsertMoney()
        {
            int money = 0;
            Console.WriteLine("Intast dit penge beløb.");

            String Result = Console.ReadLine();

            while (!Int32.TryParse(Result, out money))
            {
                Console.WriteLine("Intast dit penge beløb.");
                Result = Console.ReadLine();
            }
            return money;
        }

        public void ShowCurrentAmount(int amount)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Current Amount {amount}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void ShowItems (List<Item> a)
        {
            foreach (Item item in a)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"ID {item.id}: Name {item.name}: Price {item.price}: Flavor {item.flavor}: Size {item.size} : {item.amount}");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        public int SelectItem()
        {
            Console.WriteLine("Intast ID'et på den varer du ønsker.");

            int choise = 0;

            String Line = Console.ReadLine();

            while (!Int32.TryParse(Line, out choise))
            {
                Console.WriteLine("Intast ID'et på den varer du ønsker.");
                Line = Console.ReadLine();
            }

            return choise;
        }

        public void ShowSelectedItem(int choise, List<Item> a)
        {
            foreach (Item item in a)
            {
                if (choise == item.id)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Name {item.name}: Price {item.price}: Flavor {item.flavor}: Size {item.size}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }

        public string BuyItem()
        {
            Console.WriteLine("Ønsker du at købe denne varer? Y/N");

            return Console.ReadLine().ToUpper();
        }
    }
}