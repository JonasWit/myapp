using System;
using DotnetService.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetService.ServiceLoaders;

public static class ViewModelLocator
{
    public static IServiceCollection RegisterViewModelLocator(this IServiceCollection @this)
    {
        @this.AddSingleton<Func<string, ViewModelBase>>(sp => name =>
            {
                return name switch
                {
                    nameof(MainViewModel) => sp.GetRequiredService<MainViewModel>(),
                    nameof(HomePageViewModel) => sp.GetRequiredService<HomePageViewModel>(),
                    nameof(SettingsPageViewModel) => sp.GetRequiredService<SettingsPageViewModel>(),
                    _ => throw new Exception($"ViewModel {name} is not registered")
                };
            }
        );
        return @this;
    }
}