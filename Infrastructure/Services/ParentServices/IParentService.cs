using Domain.Models;

namespace Infrastructure.Services.ParentServices;

public interface IParentService
{
    List<Parent> GetParents();
    Parent GetParentById(int id);
    bool AddParent(Parent parent);
    bool UpdateParent(Parent parent);
    bool DeleteParent(int id);
}
