using HackathonPrep.Application.Handlers.Applicant.Command;
using HackathonPrep.Application.Handlers.Applicant.Queries;
using HackathonPrep.Application.Handlers.Student.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HackathonPrep.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class AdminController : ControllerBase
{
    private readonly IMediator _mediatr;

    public AdminController(IMediator mediatr)
    {
        _mediatr = mediatr;
    }
    [HttpGet]
    public IActionResult GetApplicants()
    {
        var result = _mediatr.Send(new GetAllApplicantsQuery());
        return Ok(result);
    }
    [HttpPost]
    public IActionResult MakeAppointment(UpdateApplicantCommand updateApplicantCommand)
    {
        var result = _mediatr.Send(updateApplicantCommand);
        return Ok(result);
    }
    [HttpPost]
    public async Task<IActionResult> Login(LoginUserCommand loginUserCommandRequest)
    {

        var token = await _mediatr.Send(loginUserCommandRequest);

        return Ok(token);

    }
}
