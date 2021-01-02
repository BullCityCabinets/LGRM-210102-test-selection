using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace LGRM
{
    public partial class App : Application
    {
        public static ObservableCollection<Inventory> InventoryRepo { get; set; }

    public App()
        {
            InitializeComponent();


            InventoryRepo = new ObservableCollection<Inventory>() 
            {
                new Inventory(){ Name1 = "Item1" },
                new Inventory(){ Name1 = "Item2" },
                new Inventory(){ Name1 = "Item3" },
                new Inventory(){ Name1 = "Item4" },
                new Inventory(){ Name1 = "Item5" }
            };

            MainPage = new NavigationPage(new InventoryPage());

        }

    }
}
