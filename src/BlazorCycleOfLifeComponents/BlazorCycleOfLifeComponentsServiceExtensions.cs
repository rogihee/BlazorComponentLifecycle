// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

public static class BlazorCycleOfLifeComponentsServiceExtensions
{
    public static IServiceCollection AddBlazorCycleOfLifeServices(this IServiceCollection services)
    {
        services.AddSingleton<LifeCycleService>();
        return services;
    }
}
