# StudentManagementSystem-CQRS-Mediator
This project is a clean, maintainable ASP.NET Core Web API implementing:

CQRS (Command Query Responsibility Segregation)

Mediator Pattern (using MediatR)

In-Memory Repository for data storage (no database required)

FluentValidation for input validation

Swagger for testing API endpoints

It supports CRUD operations for Students:
✔ Add
✔ Update
✔ Delete
✔ Get All
✔ Get By Id

Project Structure
StudentManagementSystem/
 ├── Program.cs
 ├── StudentManagementSystem.csproj
 ├── Models/
 │    └── Student.cs
 ├── Data/
 │    ├── IStudentRepository.cs
 │    └── InMemoryStudentRepository.cs
 ├── Features/
 │   └── Students/
 │        ├── Commands/
 │        │     ├── CreateStudentCommand.cs
 │        │     ├── UpdateStudentCommand.cs
 │        │     ├── DeleteStudentCommand.cs
 │        │     └── Handlers/
 │        ├── Queries/
 │        │     ├── GetAllStudentsQuery.cs
 │        │     ├── GetStudentByIdQuery.cs
 │        │     └── Handlers/
 ├── API/
 │    └── Controllers/
 │           └── StudentsController.cs
 └── Validators/
       ├── CreateStudentCommandValidator.cs
       └── UpdateStudentCommandValidator.cs

How to Run the Project
1. Restore dependencies
dotnet restore

2. Build the project
dotnet build

3. Run
dotnet run

4. Open Swagger UI
https://localhost:<port>/swagger
