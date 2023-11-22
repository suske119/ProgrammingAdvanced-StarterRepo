using VoorbeeldOrders.ViewModels;

namespace VoorbeeldOrders.Views;

public partial class WerknemersPage : ContentPage
{
    public WerknemersPage(WerknemersViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}