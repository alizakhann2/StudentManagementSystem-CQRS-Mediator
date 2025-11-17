
using MediatR;
using StudentManagement.Data;
using StudentManagement.Models;

namespace StudentManagement.Features.Students.Commands.Handlers;

public sealed class CreateStudentHandler : IRequestHandler<CreateStudentCommand, Student>
{
    private readonly IStudentRepository _repo;
    public CreateStudentHandler(IStudentRepository repo) => _repo = repo;

    public Task<Student> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
    {
        var student = new Student
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Age = request.Age,
            Course = request.Course,
            Email = request.Email
        };
        _repo.Add(student);
        return Task.FromResult(student);
    }
}
