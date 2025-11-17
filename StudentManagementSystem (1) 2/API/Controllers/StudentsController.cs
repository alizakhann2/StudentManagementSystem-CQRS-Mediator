
using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Features.Students.Commands;
using StudentManagement.Features.Students.Queries;

namespace StudentManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class StudentsController : ControllerBase
{
    private readonly IMediator _mediator;

    public StudentsController(IMediator mediator) => _mediator = mediator;

    [HttpGet]
    public async Task<IActionResult> GetAll() =>
        Ok(await _mediator.Send(new GetAllStudentsQuery()));

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var student = await _mediator.Send(new GetStudentByIdQuery(id));
        return student is null ? NotFound() : Ok(student);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateStudentCommand command)
    {
        var result = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, UpdateStudentCommand command)
    {
        if (id != command.Id) return BadRequest("Route ID mismatch");
        var ok = await _mediator.Send(command);
        return ok ? NoContent() : NotFound();
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var ok = await _mediator.Send(new DeleteStudentCommand(id));
        return ok ? NoContent() : NotFound();
    }
}
