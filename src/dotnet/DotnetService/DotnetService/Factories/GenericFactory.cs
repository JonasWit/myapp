using System;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetService.Factories;

public class GenericFactory<T>(Func<T> factoryFunction) where T : class
{
    private readonly Func<T> _factoryFunction = factoryFunction;
    public T Instance => _factoryFunction.Invoke();
}

public static class GenericFactoryInstaller
{
    public static IServiceCollection AddGenericFactory<T>(this IServiceCollection @this) where T : class
    {
        @this.AddTransient<T>();
        @this.AddSingleton<Func<T>>(sp => sp.GetRequiredService<T>);
        @this.AddSingleton<GenericFactory<T>>();
        return @this;
    }
}