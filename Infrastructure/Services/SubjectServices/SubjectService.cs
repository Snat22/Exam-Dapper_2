using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services.SubjectServices;

public class SubjectService : ISubjectService
{
    private readonly DapperContext _context;
    public SubjectService()
    {
        _context = new DapperContext();
    }
    public bool AddSubject(Subject sb)
    {
        var sql = $"insert into subjects(title,school_id,stage,created_at,updated_at)"+
                $"values('{sb.Title}',{sb.School_Id},{sb.Stage},'{sb.Created_At}','{sb.Updated_At}')";
                var inserted = _context.Connection().Execute(sql);
                if(inserted > 0) return true;
                return false;
    }
    public Subject GetSubjectById(int id)
    {
        var sql = $"select * from subjects where id = {@id}";
        var selected = _context.Connection().QueryFirstOrDefault(sql);
        return selected;
    }

    public List<Subject> GetSubjects()
    {
        var sql = $"select * from subjects";
        var selected = _context.Connection().Query<Subject>(sql).ToList();
        return selected;
    }

    public bool UpdateSubject(Subject sb)
    {
        var sql = $"update subjects set title = '{sb.Title}',school_id = {sb.School_Id},stage = {sb.Stage},updated_at = '{sb.Updated_At}' where id = {sb.Id}";
        var updated = _context.Connection().Execute(sql);
         if(updated > 0) return true;
                return false;
    }

        public bool DeleteSubject(int id)
    {
        var sql = $"delete from subjects where id = {@id}";
        var deleted = _context.Connection().Execute(sql);
         if(deleted > 0) return true;
                return false;
    }


}
