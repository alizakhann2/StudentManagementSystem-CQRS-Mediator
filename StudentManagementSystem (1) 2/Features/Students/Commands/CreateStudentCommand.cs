
using MediatR;
using StudentManagement.Models;

namespace StudentManagement.Features.Students.Commands;

public sealed record CreateStudentCommand(string Name, int Age, string Course, string Email) : IRequest<Student>;
