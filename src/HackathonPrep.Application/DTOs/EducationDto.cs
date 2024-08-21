namespace HackathonPrep.Application.DTOs;

public class EducationDto
{
    public int Id { get; set; }
    public string? UniversityName { get; set; } = null!;//type -> Enum
    public string? Speciality { get; set; } = null!;//type -> Enum
    public string? CurrentGradeLevel { get; set; } = null!;//type -> Enum
    public double GPA { get; set; }

    public InterestDto User { get; set; }
    public string UserId { get; set; }
}
