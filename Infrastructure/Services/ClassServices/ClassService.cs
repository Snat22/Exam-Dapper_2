using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services.ClassServices;

public class ClassService : IClassService
{
    private readonly DapperContext _context;
    public ClassService()
    {
        _context = new DapperContext();
    }
    public bool AddClasses(Classes classe)
    {
        var sql = $"insert into classes(class_name,subjeect_id,classroom_id,section,created_at,updated_at)"+
                $"values('{classe.CalssName}',{classe.Subject_Id},{classe.Classroom_Id},'{classe.Section}','{classe.Created_At}','{classe.Updated_At}')";
                var inserted = _context.Connection().Execute(sql);
                if(inserted > 0) return true;
                return false;
    }

    

    public List<Classes> GetClasses()
    {
        var sql = $"select * from classes";
        var selected = _context.Connection().Query<Classes>(sql).ToList();
        return selected;
    }

    public Classes GetClassesById(int id)
    {
        var sql = $"select * from classes where id = {@id}";
        var selected = _context.Connection().QueryFirstOrDefault(sql);
        return selected;
    }

    public bool UpdateClasses(Classes classe)
    {
        var sql = $"update classes set class_name = '{classe.CalssName}',subject_id = {classe.Subject_Id},classroom_id = {classe.Classroom_Id},section='{classe.Section}',updated_at='{classe.Updated_At}' where id = {classe.Id}";
        var updated = _context.Connection().Execute(sql);
         if(updated > 0) return true;
                return false;
    }

    public bool DeleteClasses(int id)
    {
        var sql = $"delete from classes where id = {@id}";
        var deleted = _context.Connection().Execute(sql);
         if(deleted > 0) return true;
                return false;
    }

}
