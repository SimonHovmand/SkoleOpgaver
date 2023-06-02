namespace Automaten
{
    public interface IGUIService
    {
        void Start(); //Sets Start to void
        int InsertCard(); //Sets InsertCard to int
        void ShowItems(List<Item> a); //Sets ShowItems to void, with the refrence to the Item list
        int SelectItem(); //Sets SelcetItem to int
        void ShowSelectedItem(int choise, List<Item> a); //Sets ShowSelectedItem to void, with the refrence to int choise and the Item list
        string BuyItem(); //Sets BuyItem to string
        void Confirmation(int choise, int money, List<Item> a); //Sets Confirmation to void, with the refrence to string choise, int money and the Item list
    }
}
