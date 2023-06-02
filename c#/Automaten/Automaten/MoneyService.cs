using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    public class MoneyService : IMoneyService
    {
        private int currentAmount = 0;

        public int CurrentAmount(int money)
        {
            currentAmount += money;
            return currentAmount;
        }
    }
}
