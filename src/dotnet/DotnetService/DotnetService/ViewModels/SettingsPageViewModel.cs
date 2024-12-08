using CommunityToolkit.Mvvm.ComponentModel;
using DotnetService.ServiceLoaders;

namespace DotnetService.ViewModels;

[ApplicationSingletonViewModel]
public partial class SettingsPageViewModel : ViewModelBase
{
    [ObservableProperty] private string _pageTitle = "Settings";
}