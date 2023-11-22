using OefeningPublishers.ViewModels;

namespace OefeningPublishers.Views;

public partial class EmployeesPage : ContentPage
{
    public EmployeesPage(EmployeesViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}