
using StudentManagement.Models;

namespace StudentManagement.Data;

public sealed class InMemoryStudentRepository : IStudentRepository
{
    private readonly List<Student> _students = new();
    private readonly object _lock = new();

    public InMemoryStudentRepository()
    {
        _students.Add(new Student { Name = "Alice", Age = 20, Course = "CS", Email = "alice@example.com" });
        _students.Add(new Student { Name = "Bob", Age = 22, Course = "ECE", Email = "bob@example.com" });
    }

    public IEnumerable<Student> GetAll()
    {
        lock (_lock)
        {
            return _students.Select(s => s).ToList();
        }
    }

    public Student? GetById(Guid id)
    {
        lock (_lock)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }
    }

    public void Add(Student student)
    {
        lock (_lock)
        {
            _students.Add(student);
        }
    }

    public bool Update(Student student)
    {
        lock (_lock)
        {
            var idx = _students.FindIndex(s => s.Id == student.Id);
            if (idx == -1) return false;
            _students[idx] = student;
            return true;
        }
    }

    public bool Delete(Guid id)
    {
        lock (_lock)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null) return false;
            _students.Remove(student);
            return true;
        }
    }
}
