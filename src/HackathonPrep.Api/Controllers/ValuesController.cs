using HackathonPrep.Domain.Identity;
using HackathonPrep.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HackathonPrep.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<AppUser> _userManager;

    public ValuesController(ApplicationDbContext context, UserManager<AppUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }
    [HttpPost]
    public async Task<IActionResult> CreateSeedAsync()
    {

        return NoContent();
    }
}
