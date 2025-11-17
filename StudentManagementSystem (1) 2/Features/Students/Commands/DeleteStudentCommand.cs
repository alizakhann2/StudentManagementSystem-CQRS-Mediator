
using MediatR;

namespace StudentManagement.Features.Students.Commands;

public sealed record DeleteStudentCommand(Guid Id) : IRequest<bool>;
