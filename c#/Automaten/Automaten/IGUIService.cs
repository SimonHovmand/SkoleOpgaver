using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    public interface IGUIService
    {
        int InsertMoney();
        void ShowCurrentAmount(int amount);
        void ShowItems(List<Item> a);
        int SelectItem();
        void ShowSelectedItem(int choise, List<Item> a);
        string BuyItem();
    }
}
