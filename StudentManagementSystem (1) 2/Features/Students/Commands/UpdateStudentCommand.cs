
using MediatR;

namespace StudentManagement.Features.Students.Commands;

public sealed record UpdateStudentCommand(Guid Id, string Name, int Age, string Course, string Email) : IRequest<bool>;
