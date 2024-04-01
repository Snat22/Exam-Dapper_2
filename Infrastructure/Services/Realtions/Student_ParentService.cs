using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services.Realtions;

public class Student_ParentService : IStudent_ParentService
{
        private readonly DapperContext _context;
        public Student_ParentService()
        {
            _context = new DapperContext();
        }
    public bool AddStudent_Parent(Student_Parent sp)
    {
        var sql = $"insert into student_parent(student_id,parent_id)"+
        $"values({sp.Student_Id},{sp.Parent_Id})";
        var inserted = _context.Connection().Execute(sql);
        if(inserted > 0) return true;
        return false;
    }


    public Student_Parent GetStudent_ParentById(int id)
    {
        var sql = $"select * from student_parent where id = {@id}";
        var selected = _context.Connection().QueryFirstOrDefault(sql);
        return selected;
    }

    public List<Student_Parent> GetStudent_Parents()
    {
        var sql = $"select * from student_parent";
        var selected = _context.Connection().Query<Student_Parent>(sql).ToList();
        return selected;
    }

    public bool UpdateStudent_Parent(Student_Parent sp)
    {
        var sql = $"update student_parent set student_id = {sp.Student_Id},parent_id = {sp.Parent_Id} where id = {sp.Id}";
        var updated = _context.Connection().Execute(sql);
        if(updated > 0) return true;
        return false;
    }

        public bool DeleteStudent_Parent(int id)
    {
        var sql = $"delete from student_parent where id = {@id}";
        var deleted = _context.Connection().Execute(sql);
        if(deleted > 0) return true;
        return false;
    }


}
