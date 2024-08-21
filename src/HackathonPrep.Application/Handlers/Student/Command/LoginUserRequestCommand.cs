using HackathonPrep.Application.DTOs;
using MediatR;

namespace HackathonPrep.Application.Handlers.Student.Command;

public class LoginUserCommand : IRequest<TokenDto>
{
    public string Username { get; set; }
    public string Password { get; set; }
}