
using Ejemplo_Build.PageModels;

namespace Ejemplo_Build.Pages;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageModel model)
    {
        InitializeComponent();
        BindingContext = model;
    }

}
