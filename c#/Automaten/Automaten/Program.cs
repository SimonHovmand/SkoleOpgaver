namespace Automaten
{
    public class Program
    {
        static void Main(string[] args)
        {
            IController ctrl = new Controller(new GUIService(), new ItemService());

            while (true)
            {
                ctrl.Start(); //Kalder Start

                int cardnumber = ctrl.InsertCard(); //Kalder InsertMoney

                ctrl.ShowItems(); //Kalder ShowItems

                int choise = ctrl.SelectItem(); //Kalder SelectItem

                ctrl.ShowSelectedItem(choise); //Kalder ShowSelectedItem

                string remove = ctrl.BuyItem(); //Kalder BuyItem

                ctrl.RemoveItem(remove, choise); //Kalder RemoveItem

                ctrl.Confirmation(choise, cardnumber); //Kalder Confirmation
            }
        }
    }
}











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
