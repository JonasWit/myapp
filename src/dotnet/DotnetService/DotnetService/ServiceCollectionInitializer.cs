using DotnetService.Factories;
using DotnetService.ServiceLoaders;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetService;

public static class ServiceCollectionInitializer
{
    public static ServiceProvider Create()
    {
        var collection = new ServiceCollection();
        collection.AddViewModels();
        collection.RegisterViewModelLocator();
        collection.AddSingleton<ViewModelFactory>();

        return collection.BuildServiceProvider();     
    }
}