using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HackathonPrep.Application;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()); // minimun setup
            //cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            // cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            // cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(AuthorizationBehaviour<,>));
            // cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));
        });
        // services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());




        //services.AddMediatR(Assembly.GetExecutingAssembly());

        ////services.AddNewtonsoftJson.Include(p => p.CityId).Include(p => p.CountryId).AsNoTracking();

        //services.AddAutoMapper(Assembly.GetExecutingAssembly());

        ////services.AddFluentValidationAutoValidation();

        //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());


        // Behaviours 
        //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
        //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationExceptionBehaviour<,>));

        return services;
    }
}