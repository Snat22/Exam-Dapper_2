using Domain.Models;

namespace Infrastructure.Services.Realtions;

public interface IStudent_ParentService
{
    List<Student_Parent> GetStudent_Parents();
    Student_Parent GetStudent_ParentById(int id);
    bool AddStudent_Parent(Student_Parent sp);
    bool UpdateStudent_Parent(Student_Parent sp);
    bool DeleteStudent_Parent(int id);
}
