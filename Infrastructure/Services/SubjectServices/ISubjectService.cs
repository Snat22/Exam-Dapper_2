using Domain.Models;

namespace Infrastructure.Services.SubjectServices;

public interface ISubjectService
{
    
    List<Subject> GetSubjects();
    Subject GetSubjectById(int id);
    bool AddSubject(Subject sb);
    bool UpdateSubject(Subject sb);
    bool DeleteSubject(int id);
}
