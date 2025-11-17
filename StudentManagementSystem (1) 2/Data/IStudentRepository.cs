
using StudentManagement.Models;

namespace StudentManagement.Data;

public interface IStudentRepository
{
    IEnumerable<Student> GetAll();
    Student? GetById(Guid id);
    void Add(Student student);
    bool Update(Student student);
    bool Delete(Guid id);
}
