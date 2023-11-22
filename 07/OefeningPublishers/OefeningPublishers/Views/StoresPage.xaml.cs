using OefeningPublishers.ViewModels;

namespace OefeningPublishers.Views;

public partial class StoresPage : ContentPage
{
    public StoresPage(StoresViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}