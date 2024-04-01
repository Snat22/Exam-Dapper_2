using Domain.Models;

namespace Infrastructure.Services.ClassServices;

public interface IClassService
{
    List<Classes> GetClasses();
    Classes GetClassesById(int id);
    bool AddClasses(Classes classe);
    bool UpdateClasses(Classes classe);
    bool DeleteClasses(int id);
}
