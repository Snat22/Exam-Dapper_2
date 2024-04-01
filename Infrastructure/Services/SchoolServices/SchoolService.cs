using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services.SchoolServices;

public class SchoolService : ISchoolService
{
    private readonly DapperContext _context;
    public SchoolService()
    {
        _context = new DapperContext();
    }
    public bool AddSchool(School school)
    {
        var sql = $"insert into schools(school_title,level_count,is_active,created_at,updated_at)"+
                $"values('{school.Title}',{school.Level_Count},{school.Is_Active},'{school.Created_At}','{school.Updated_At}')";

                var inserted = _context.Connection().Execute(sql);
                if(inserted > 0) return true;
                return false;
    }


    public School GetSchoolById(int id)
    {
        var sql = $"select * from schools where id={@id}";
        var selected = _context.Connection().QueryFirstOrDefault(sql).ToList();
        return selected;
    }

    public List<School> GetSchools()
    {
        var sql = $"select * from schools";
        var selected = _context.Connection().Query<School>(sql).ToList();
        return selected;
    }

    public bool UpdateSchool(School school)
    {
        var sql = $"update schools set school_title = '{school.Title}',level_count = {school.Level_Count},is_active={school.Is_Active},updated_at='{school.Updated_At}' where id = {school.Id}";
        var updated = _context.Connection().Execute(sql);
        if(updated > 0) return true;
        return false;
    }

    public bool DeleteSchool(int id)
    {
        var sql = $"delete from schools where id = {@id}";
        var deleted = _context.Connection().Execute(sql);
        if(deleted > 0) return true;
        return false;
    }

}
