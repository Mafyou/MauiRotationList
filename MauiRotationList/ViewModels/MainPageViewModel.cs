using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiRotationList.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    private List<string> _itemsList = [];
    public MainPageViewModel()
    {
        _itemsList.AddRange(Enumerable.Repeat("Test", 20));
    }
}