using HackathonPrep.Application.DTOs;
using HackathonPrep.Domain.Identity;

namespace HackathonPrep.Application.Common.Interfaces;

public interface ITokenHandler
{
    Task<TokenDto> CreateAccessToken(int second, AppUser appUser);

}