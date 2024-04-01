using Domain.Models;

namespace Infrastructure.Services.TeacherServices;

public interface ITeacherService
{
    List<Teacher> GetTeachers();
    Teacher GetTeacherById(int id);
    bool AddTeacher(Teacher teacher);
    bool UpdateTeacher(Teacher teacher);
    bool DeleteTeacher(int id);
}
