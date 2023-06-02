namespace Automaten
{
    public interface IController
    {
        void Start(); //Sets Start to void
        int InsertCard(); //Sets InsertCard to int
        void ShowItems(); //Sets ShowItems to void
        int SelectItem(); //Sets SelcetItem to int
        void ShowSelectedItem (int choise); //Sets ShowSelectedItem to void, with the refrence to int choise
        string BuyItem(); //Sets BuyItem to string
        void RemoveItem(string remove, int choise); //Sets RemoveItem to void, with the refrence to string remove and int choise
        void Confirmation(int choise, int money); //Sets Confirmation to void, with the refrence to string choise and int money
    }
}
