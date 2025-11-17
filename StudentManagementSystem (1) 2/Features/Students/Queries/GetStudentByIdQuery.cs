
using MediatR;
using StudentManagement.Models;

namespace StudentManagement.Features.Students.Queries;

public sealed record GetStudentByIdQuery(Guid Id) : IRequest<Student?>;
