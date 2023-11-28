using MauiRotationList.ViewModels;

namespace MauiRotationList;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }
}