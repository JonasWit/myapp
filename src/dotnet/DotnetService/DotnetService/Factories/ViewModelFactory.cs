using System;
using DotnetService.ViewModels;

namespace DotnetService.Factories;

public class ViewModelFactory(Func<string, ViewModelBase> locator)
{
    private readonly Func<string, ViewModelBase> _locator = locator;

    public ViewModelBase GetViewModel(string viewModelName)
    {
        return _locator.Invoke(viewModelName);
    }
}