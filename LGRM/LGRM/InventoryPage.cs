using Xamarin.Forms;

namespace LGRM
{
    public class InventoryPage : ContentPage
    {
        public InventoryPage() 
        {
            BindingContext = new InventoryVM(); 

            var MainStack = new StackLayout();
            Content = MainStack;

            var cvGroceries = new CollectionView()
            {
                SelectionMode = SelectionMode.Multiple,                

            };
            cvGroceries.SetBinding(CollectionView.ItemsSourceProperty, "MyInventory");
            cvGroceries.SetBinding(CollectionView.SelectedItemsProperty, "MySelectedItems", BindingMode.TwoWay);
            cvGroceries.SetBinding(CollectionView.SelectionChangedCommandProperty, "MySelectionChangedCommand");


            cvGroceries.ItemTemplate = new DataTemplate(() =>
            {                
                var dtGrid = new Grid { }; // HorizontalOptions = LayoutOptions.FillAndExpand };

                var slNamesEtc = new StackLayout() { Padding = new Thickness(3, 0, 0, 0), Spacing = -1 };
                Grid.SetRowSpan(slNamesEtc, 3);

                var name1Label = new Label { FontAttributes = FontAttributes.Bold, LineBreakMode = LineBreakMode.MiddleTruncation };  
                name1Label.SetBinding(Label.TextProperty, "Name1");

                slNamesEtc.Children.Add(name1Label);
                dtGrid.Children.Add(slNamesEtc, 1, 0);

                return dtGrid;

            }); // ... end DataTemplate

            MainStack.Children.Add(cvGroceries);


        }

        

    }
}

