namespace HackathonPrep.Application.DTOs;

public class ApplicantDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Status { get; set; }

    public InterestDto? User { get; set; }
    public string? UserId { get; set; }
    public DateTime? AppointmentDate { get; set; }
}
