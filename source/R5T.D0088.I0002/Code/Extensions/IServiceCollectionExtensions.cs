using System;

using Microsoft.Extensions.DependencyInjection;


namespace R5T.D0088.I0002
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddHostStartup<THostStartup>(this IServiceCollection services,
#pragma warning disable IDE0060 // Remove unused parameter
            IDependencyServiceActionAggregation dependencyServiceActions)
#pragma warning restore IDE0060 // Remove unused parameter
            where THostStartup : HostStartupBase
        {
            services.AddSingleton<THostStartup>()
                // Run all service actions in dependency service actions.
                ;

            return services;
        }
    }
}
