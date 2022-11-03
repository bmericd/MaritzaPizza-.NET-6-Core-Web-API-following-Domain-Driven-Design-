using MaritzaPizza.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace MaritzaPizza.Application;

public static class DependencyInjection{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}