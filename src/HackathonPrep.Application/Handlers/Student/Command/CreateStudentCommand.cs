using MediatR;

namespace HackathonPrep.Application.Handlers.Student.Command;

public class CreateStudentCommand : IRequest<bool>
{
    public string DeviceId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

}
