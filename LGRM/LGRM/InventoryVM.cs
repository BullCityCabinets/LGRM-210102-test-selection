using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace LGRM
{
    public class InventoryVM : INotifyPropertyChanged
    {
        //~~ Data Source...                
        public ObservableCollection<Inventory> MyInventory { get; set; }        

        ObservableCollection<object> _mySelectedItems { get; set; } //To capture View's binding input
        public ObservableCollection<object> MySelectedItems 
        {
            get => _mySelectedItems;
            set
            {
                if (_mySelectedItems != value)
                {
                    _mySelectedItems = value;
                }
            }
        }

        public ICommand MySelectionChangedCommand => new Command(OnMySelectionChangedCommand);




        public InventoryVM() 
        {         
            MyInventory = new ObservableCollection<Inventory>();
            foreach (var item in App.InventoryRepo) { MyInventory.Add(item); }

            MySelectedItems = new ObservableCollection<object>() { };
        
        }





        public int SelectionChangedCommandCount = 0;

        private void OnMySelectionChangedCommand()
        {
            SelectionChangedCommandCount++;
        }


        public ObservableCollection<Inventory> GetInventory() 
        {
            var inv = new ObservableCollection<Inventory>();

            foreach (var item in App.InventoryRepo) { MyInventory.Add(item); }

            return inv;

        }




        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }

}
