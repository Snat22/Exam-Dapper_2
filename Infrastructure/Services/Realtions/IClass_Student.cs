using Domain.Models;

namespace Infrastructure.Services.Realtions;

public interface IClass_Student
{
    List<Class_Student> GetClass_Students();
    Class_Student GetClass_StudentById(int id);
    bool AddClass_Student(Class_Student cs);
    bool UpdateClassStudent(Class_Student cs);
    bool DeleteClassStudent(int id);
}
