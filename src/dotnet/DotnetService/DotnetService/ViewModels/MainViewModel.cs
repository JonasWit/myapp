using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DotnetService.DomainData;
using DotnetService.Factories;
using DotnetService.ServiceLoaders;

namespace DotnetService.ViewModels;

[ApplicationSingletonViewModel]
public partial class MainViewModel : ViewModelBase
{
    private readonly ViewModelFactory _viewModelFactory;
    [ObservableProperty] private ViewModelBase _currentPage;

    public MainViewModel(ViewModelFactory viewModelFactory)
    {
        _viewModelFactory = viewModelFactory;
        CurrentPage = new HomePageViewModel();
    }

    [RelayCommand]
    private void SwitchToHome()
    {
        CurrentPage = _viewModelFactory.GetViewModel(AvaloniaConstants.PagesViewModels.HomePageViewModel);
    }

    [RelayCommand]
    private void SwitchToSettings()
    {
        CurrentPage = _viewModelFactory.GetViewModel(AvaloniaConstants.PagesViewModels.SettingsPageViewModel);
    }
}