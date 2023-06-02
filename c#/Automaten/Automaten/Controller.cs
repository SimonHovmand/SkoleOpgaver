using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    internal class Controller : IController
    {
        private readonly IGUIService _guiservice;
        private readonly IMoneyService _moneyService;
        private readonly ItemService _itemService;

        public Controller(IMoneyService money, IGUIService gui, ItemService item)
        {
            _guiservice = gui;
            _moneyService = money;
            _itemService = item;
        }

        public void ShowCurrentAmount(int amount)
        {
            this._guiservice.ShowCurrentAmount(this._moneyService.CurrentAmount(amount));
        }

        public int InsertMoney()
        {
            return this._guiservice.InsertMoney();
        }

        public void ShowItems()
        {
            this._guiservice.ShowItems(_itemService.items);
        }

        public int SelectItem()
        {
            return this._guiservice.SelectItem();
        }

        public void ShowSelectedItem(int choise)
        {
            this._guiservice.ShowSelectedItem(choise, _itemService.items);
        }

        public string BuyItem()
        {
            return this._guiservice.BuyItem();
        }

        public void RemoveItem(string remove, int choise)
        {
            switch (remove)
            {
                case "Y":
                    _itemService.RemoveAmount(choise);
                    break;
                case "N":
                    Console.WriteLine("NO");
                    break;
                default:
                    Console.WriteLine("Fejl");
                    break;
            }
        }
    }
}
