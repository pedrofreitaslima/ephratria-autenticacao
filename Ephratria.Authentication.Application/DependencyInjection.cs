using System.Reflection;
using Ephratria.Authentication.Application.Behaviors;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Ephratria.Authentication.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(typeof(DependencyInjection).Assembly);
    
        services.AddScoped(
            typeof(IPipelineBehavior<,>), 
            typeof(ValidateBehavior<,>));
    
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        return services;
    }
}