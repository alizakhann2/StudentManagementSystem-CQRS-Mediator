
using MediatR;
using StudentManagement.Models;

namespace StudentManagement.Features.Students.Queries;

public sealed record GetAllStudentsQuery() : IRequest<IEnumerable<Student>>;
