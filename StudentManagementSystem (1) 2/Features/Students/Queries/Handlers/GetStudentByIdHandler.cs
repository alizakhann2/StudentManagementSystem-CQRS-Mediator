
using MediatR;
using StudentManagement.Data;
using StudentManagement.Models;

namespace StudentManagement.Features.Students.Queries.Handlers;

public sealed class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, Student?>
{
    private readonly IStudentRepository _repo;
    public GetStudentByIdHandler(IStudentRepository repo) => _repo = repo;

    public Task<Student?> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_repo.GetById(request.Id));
    }
}
