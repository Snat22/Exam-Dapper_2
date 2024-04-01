using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services.ParentServices;

public class ParentService : IParentService
{
    private readonly DapperContext _context;
    public ParentService()
    {
        _context = new DapperContext();
    }
    public bool AddParent(Parent parent)
    {
        var sql = $"insert into parents(parent_code,fullname,phone,created_at,updated_at)"+
                $"values('{parent.Parent_Code}','{parent.FullName}','{parent.Phone}','{parent.Created_At}','{parent.Updated_At}')";
                var inserted = _context.Connection().Execute(sql);
                if(inserted > 0) return true;
                return false;
    }

    public Parent GetParentById(int id)
    {
        var sql = $"select * from parents where id = {@id}";
        var selected = _context.Connection().QueryFirstOrDefault(sql);
        return selected;
    }

    public List<Parent> GetParents()
    {
    var sql = $"select * from parents";
        var selected = _context.Connection().Query<Parent>(sql).ToList();
        return selected;    
        }

    public bool UpdateParent(Parent parent)
    {
        var sql = $"update parents set parent_code = '{parent.Parent_Code}',fullname = '{parent.FullName}',phone='{parent.Phone}',updated_at = '{parent.Updated_At}' where id ={parent.Id}";
        var updated = _context.Connection().Execute(sql);
        if(updated > 0) return true;
        return false;
    }

    
    public bool DeleteParent(int id)
    {
        var sql = $"delete from parents where id={@id}";
        var deleted = _context.Connection().Execute(sql);
        if(deleted > 0) return true;
        return false;
    }


}
