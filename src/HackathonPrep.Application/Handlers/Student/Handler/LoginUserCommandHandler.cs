using HackathonPrep.Application.Common.Interfaces;
using HackathonPrep.Application.DTOs;
using HackathonPrep.Application.Handlers.Student.Command;
using HackathonPrep.Domain.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace HackathonPrep.Application.Handlers.Student.Handler;

public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, TokenDto>
{
    private readonly ITokenHandler _tokenHandler;
    private readonly UserManager<AppUser> _userManager;
    private readonly IApplicationDbContext _dbContext;

    public LoginUserCommandHandler(ITokenHandler tokenHandler, UserManager<Domain.Identity.AppUser> userManager, IApplicationDbContext dbContext)
    {
        _tokenHandler = tokenHandler;
        _userManager = userManager;
        _dbContext = dbContext;
    }

    public async Task<TokenDto> Handle(LoginUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByNameAsync(request.Username);


        if (user == null) throw new Exception("User not found");
        var result = await _userManager.CheckPasswordAsync(user, request.Password);

        if (!result) throw new Exception("Authentication error");
        var accessToken = await _tokenHandler.CreateAccessToken(1200, user);

        return accessToken;
    }
}
