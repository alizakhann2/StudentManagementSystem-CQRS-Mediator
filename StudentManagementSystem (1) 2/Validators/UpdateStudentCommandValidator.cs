
using FluentValidation;
using StudentManagement.Features.Students.Commands;

namespace StudentManagement.Validators;

public sealed class UpdateStudentCommandValidator : AbstractValidator<UpdateStudentCommand>
{
    public UpdateStudentCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Age).InclusiveBetween(15, 100);
        RuleFor(x => x.Course).NotEmpty();
        RuleFor(x => x.Email).EmailAddress();
    }
}
