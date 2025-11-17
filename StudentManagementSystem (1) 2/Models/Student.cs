
namespace StudentManagement.Models;

public sealed class Student
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Course { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
