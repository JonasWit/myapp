using System.Linq;
using System.Reflection;
using DotnetService.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetService.ServiceLoaders;

public static class RegisterViewModels
{
    public static IServiceCollection AddViewModels(this IServiceCollection @this)
    {
        var models = typeof(ViewModelBase);
        var appDefinedTypes = models.Assembly.DefinedTypes.ToArray();

        var singletonViewModels = appDefinedTypes
            .Where(x => x.GetTypeInfo().GetCustomAttribute<ApplicationSingletonViewModel>() != null)
            .Select(p => p.AsType());

        foreach (var service in singletonViewModels) @this.AddSingleton(service);

        var transientViewModels = appDefinedTypes
            .Where(x => x.GetTypeInfo().GetCustomAttribute<ApplicationTransientViewModel>() != null)
            .Select(p => p.AsType());

        foreach (var service in transientViewModels) @this.AddTransient(service);

        return @this;
    }
}