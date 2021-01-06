using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Mahulet_Andreea_Lab12.Data;
namespace Mahulet_Andreea_Lab12
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {

            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
        }
    }

     
}
