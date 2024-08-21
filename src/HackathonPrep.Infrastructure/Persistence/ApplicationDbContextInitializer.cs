using HackathonPrep.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HackathonPrep.Infrastructure.Persistence;

public class ApplicationDbContextInitializer
{
    private readonly ApplicationDbContext _context;
    private readonly RoleManager<AppRole> _roleManager;
    private readonly UserManager<AppUser> _userManager;
    private readonly ILogger<ApplicationDbContextInitializer> _logger;

    public ApplicationDbContextInitializer(ApplicationDbContext context, RoleManager<AppRole> roleManager, UserManager<AppUser> userManager, ILogger<ApplicationDbContextInitializer> logger)
    {
        _context = context;
        _roleManager = roleManager;
        _userManager = userManager;
        _logger = logger;
    }
    public async Task InitializeAsync()
    {
        try
        {
            if (_context.Database.IsSqlServer())
            {
                await _context.Database.MigrateAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while initializing the database.");
            throw;
        }
    }
    public async Task SeedAsync()
    {
        try
        {
            await TrySeedAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occured while seeding the database");
            throw;
        }
    }
    public async Task TrySeedAsync()
    {
        //string role = "admin";
        //await _roleManager.CreateAsync(new AppRole() { Name = role });

        //var administrator = new AppUser
        //{
        //    UserName = "codeAdmin",
        //    Email = "mutalibshg@code.edu.az",
        //    FullName = "proxiesAdmin",
        //    NormalizedUserName = "proxiesAdmin",
        //    NormalizedEmail = "MUTALIBSHG@CODE.EDU.AZ",
        //    EmailConfirmed = false,
        //    PhoneNumberConfirmed = false,
        //    SecurityStamp = Guid.NewGuid().ToString("D")
        //};

        //await _userManager.CreateAsync(administrator, "PaSSword1!");
        //await _userManager.AddToRoleAsync(administrator, "admin");

        // await _context.SaveChangesAsync();
    }
}

