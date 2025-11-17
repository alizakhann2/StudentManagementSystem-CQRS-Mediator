
using MediatR;
using StudentManagement.Data;
using StudentManagement.Models;

namespace StudentManagement.Features.Students.Queries.Handlers;

public sealed class GetAllStudentsHandler : IRequestHandler<GetAllStudentsQuery, IEnumerable<Student>>
{
    private readonly IStudentRepository _repo;
    public GetAllStudentsHandler(IStudentRepository repo) => _repo = repo;

    public Task<IEnumerable<Student>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
    {
        var students = _repo.GetAll();
        return Task.FromResult(students);
    }
}
