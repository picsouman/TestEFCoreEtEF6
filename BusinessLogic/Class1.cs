using Microsoft.Extensions.DependencyInjection;
using System;

namespace BusinessLogic
{
    public static class ExtensionServiceCollection
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection services)
        {
            services.AddScoped<UserBusinessLogic>();
            services.AddScoped<GroupBusinessLogic>();
            return services;
        }
    }
}
