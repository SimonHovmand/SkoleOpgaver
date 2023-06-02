namespace Automaten
{
    internal class Controller : IController
    {
        private readonly IGUIService _guiservice;
        private readonly ItemService _itemService;

        public Controller(IGUIService gui, ItemService item)
        {
            _guiservice = gui;
            _itemService = item;
        }

        public void Start() 
        {
            this._guiservice.Start();
        }

        public int InsertCard()
        {
            return this._guiservice.InsertCard();
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du hare fortrudt dit køb");
                    Console.WriteLine("Dine kreditkort oplysninger er blevet slettet");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Der skete en fejl");
                    Console.WriteLine("Dine kreditkort oplysninger er blevet slettet");
                    break;
            }
        }

        public void Confirmation(int choise, int money)
        {
            this._guiservice.Confirmation(choise, money, _itemService.items);
        }
    }
}
