using HackathonPrep.Application.Handlers.Applicant.Command;
using HackathonPrep.Application.Handlers.Student.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HackathonPrep.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class StudentController : ControllerBase
{
    private readonly IMediator _mediatr;

    public StudentController(IMediator mediatr)
    {
        _mediatr = mediatr;
    }
    [HttpPost]
    public IActionResult DeviceRegister(CreateStudentCommand createStudentCommand)
    {
        var result = _mediatr.Send(createStudentCommand);
        return Ok(result);
    }
    [HttpPost]
    public IActionResult JoinCourse(UpdateStudentCommand updateStudentCommand)
    {
        var result = _mediatr.Send(updateStudentCommand);
        return Ok(result);
    }
    [HttpPost]
    public IActionResult ApplyCourse(CreateApplicantCommand createApplicantCommand)
    {
        var result = _mediatr.Send(createApplicantCommand);
        return Ok(result);
    }

}
