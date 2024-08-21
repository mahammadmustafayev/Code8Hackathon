using HackathonPrep.Application.Common.Interfaces;
using HackathonPrep.Domain.Identity;
using HackathonPrep.Infrastructure.Persistence;
using HackathonPrep.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HackathonPrep.Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<ApplicationDbContext>(
            options => options.UseSqlServer(configuration.GetConnectionString("hacakthonDb"),
            builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
        services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());
        services.AddScoped<ApplicationDbContextInitializer>();



        services.AddIdentity<AppUser, AppRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>();

        services.AddScoped<ITokenHandler, TokenHandler>();

        //services.AddIdentityCore<ApplicationUser>()
        //    .AddRoles<AppRole>()
        //    .AddEntityFrameworkStores<ApplicationDbContext>();

        //services.AddScoped<RoleManager<AppRole>>();

        services.AddScoped<IEmailService, EmailService>();
        //services.AddScoped<ICurrentUserService, CurrentUserService>();
        services.AddTransient<IDateTime, DateTimeService>();


        return services;
    }
}
