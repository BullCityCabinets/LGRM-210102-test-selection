using System.ComponentModel;

namespace LGRM
{
    public class Inventory : INotifyPropertyChanged
    {
        public string Name1 { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}


