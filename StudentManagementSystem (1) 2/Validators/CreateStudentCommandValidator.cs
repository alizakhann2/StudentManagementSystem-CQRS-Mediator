
using FluentValidation;
using StudentManagement.Features.Students.Commands;

namespace StudentManagement.Validators;

public sealed class CreateStudentCommandValidator : AbstractValidator<CreateStudentCommand>
{
    public CreateStudentCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Age).InclusiveBetween(15, 100);
        RuleFor(x => x.Course).NotEmpty();
        RuleFor(x => x.Email).EmailAddress();
    }
}
