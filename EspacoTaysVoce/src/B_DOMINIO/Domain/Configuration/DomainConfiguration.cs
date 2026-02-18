using System;
using Microsoft.Extensions.DependencyInjection;
using Domain.Interfaces.Services;

namespace Domain.Configuration;

public static class DomainConfiguration
{
    public static IServiceCollection AddDomainHierarchy(this IServiceCollection services)
    {
        // services.AddScoped<IProduto,>();

        return services;
    }
}
