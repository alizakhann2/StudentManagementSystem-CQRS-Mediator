
using MediatR;
using StudentManagement.Data;

namespace StudentManagement.Features.Students.Commands.Handlers;

public sealed class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, bool>
{
    private readonly IStudentRepository _repo;
    public DeleteStudentHandler(IStudentRepository repo) => _repo = repo;

    public Task<bool> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_repo.Delete(request.Id));
    }
}
