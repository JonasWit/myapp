using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DotnetService.ServiceLoaders;

namespace DotnetService.ViewModels;

[ApplicationSingletonViewModel]
public partial class HomePageViewModel : ViewModelBase
{
    [ObservableProperty] private ObservableCollection<string> _comboboxItems;

    [ObservableProperty] private string _comboboxSelectedItem = "";
    [ObservableProperty] private string _pageTitle = "Home";

    public HomePageViewModel()
    {
        ComboboxItems = ["Home", "Not Home"];
    }

    [RelayCommand]
    private void ComboboxSelectionChanged()
    {
    }
}