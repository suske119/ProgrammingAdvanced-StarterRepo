using VoorbeeldOrders.ViewModels;

namespace VoorbeeldOrders.Views;

public partial class OrdersPage : ContentPage
{
    public OrdersPage(OrdersViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}