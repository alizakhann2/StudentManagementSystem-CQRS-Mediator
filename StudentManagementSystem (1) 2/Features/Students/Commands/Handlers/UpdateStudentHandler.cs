
using MediatR;
using StudentManagement.Data;

namespace StudentManagement.Features.Students.Commands.Handlers;

public sealed class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, bool>
{
    private readonly IStudentRepository _repo;
    public UpdateStudentHandler(IStudentRepository repo) => _repo = repo;

    public Task<bool> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
    {
        var existing = _repo.GetById(request.Id);
        if (existing == null) return Task.FromResult(false);

        existing.Name = request.Name;
        existing.Age = request.Age;
        existing.Course = request.Course;
        existing.Email = request.Email;

        return Task.FromResult(_repo.Update(existing));
    }
}
