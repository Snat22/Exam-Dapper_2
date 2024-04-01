using Domain.Models;

namespace Infrastructure.Services.StudentServices;

public interface IStudentService
{
    List<Student> GetStudents();
    Student GetStudentById(int id);
    bool AddStudent(Student student);
    bool UpdateStudent(Student student);
    bool DeleteStudent(int id);
}
