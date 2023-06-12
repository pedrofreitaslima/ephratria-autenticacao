using Ephratria.Authentication.Api.Commons.Errors;
using Ephratria.Authentication.Api.Commons.Mappings;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Ephratria.Authentication.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, EphratriaProblemDetailsFactory>();
        services.AddMappings();
        return services;
    }
}