using Automaten;
using System.Reflection;

public class Program
{
    static void Main(string[] args)
    {
        IController ctrl = new Controller(new MoneyService(), new GUIService(), new ItemService());

        int a = ctrl.InsertMoney();

        ctrl.ShowCurrentAmount(a);

        ctrl.ShowItems();

        int choise = ctrl.SelectItem();

        ctrl.ShowSelectedItem(choise);

        string remove = ctrl.BuyItem();

        ctrl.RemoveItem(remove, choise);

        ctrl.ShowItems();


    }
}




//Rigebillede

//Meteoder(GUI DAL BLL)(Med angivelser[Public, private osv]) -Med ordentlige navne


//                      ==DAL==
//Varer
//Ændring af varer          AdjustItem          Private
//RemoveItem                RemoveItem          Private
//EarnedMoney               AddEarnedMoney      Private

//                      ==GUI==
//Vis penge                 ShowAmount          Public
//Vis tilgængelige varer 	ShowItems	        Public
//Vis annulering            ShowCancelMessage   Public
//Vis valgte varer          ShowSelectedItem    Public
//Giv købte ting            ReleaseItems        Public

//                      ==BLL==
//Penge i maskinen 	        InsertMoney	        Private

//Valg af varer	            AddToBasket	        Private
//Valgte varer	            SelectedItem	    Private
