using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    public interface IController
    {
        int InsertMoney();
        void ShowCurrentAmount(int amount);
        void ShowItems();
        int SelectItem();
        void ShowSelectedItem (int choise);
        string BuyItem();
        void RemoveItem(string remove, int choise);
    }
}
