using Ephratria.Authentication.Api;
using Ephratria.Authentication.Application;
using Ephratria.Authentication.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddPresentation()
        .AddApplication()
        .AddInfrastructure(builder.Configuration);
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}


