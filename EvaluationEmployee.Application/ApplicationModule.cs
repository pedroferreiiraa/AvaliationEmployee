
using _5W2H.Application.Commands.UserCommands.InsertUser;
using Microsoft.Extensions.DependencyInjection;

namespace _5W2H.Application;

public static class ApplicationModule
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services
            .AddHandlers();
        
        return services;
    }

    private static IServiceCollection AddHandlers(this IServiceCollection services)
    {
        services.AddMediatR(config =>
            config.RegisterServicesFromAssemblyContaining<InsertUserCommand>()
        );

        return services;
    }
}