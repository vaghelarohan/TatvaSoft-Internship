namespace StudentApi.DTOs;

public class RegisterStudentDto
{
    public required string FullName { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
}
