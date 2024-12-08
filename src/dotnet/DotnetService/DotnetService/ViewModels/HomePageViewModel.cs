using CommunityToolkit.Mvvm.ComponentModel;
using DotnetService.ServiceLoaders;

namespace DotnetService.ViewModels;

[ApplicationSingletonViewModel]
public partial class HomePageViewModel : ViewModelBase
{
    [ObservableProperty] private string _pageTitle = "Home";
}