using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services.Realtions;

public class Class_StudentService : IClass_Student
{
    private readonly DapperContext _context;
    public Class_StudentService()
    {
        _context = new DapperContext();
    }
    public bool AddClass_Student(Class_Student cs)
    {
        var sql = $"insert into class_student(class_id,student_id)"+
            $"values({cs.Class_Id},{cs.Student_Id})";
            var inserted = _context.Connection().Execute(sql);
            if(inserted > 0) return true;
            return false;
    }


    public Class_Student GetClass_StudentById(int id)
    {
        var sql = $"select * from class_studnet where id = {@id}";
                var selected = _context.Connection().QueryFirstOrDefault(sql);
                return selected;
    }

    public List<Class_Student> GetClass_Students()
    {
        var sql = $"select * from class_student";
        var selected = _context.Connection().Query<Class_Student>(sql).ToList();
        return selected;
    }

    public bool UpdateClassStudent(Class_Student cs)
    {
        var sql = $"update class_student set class_id = {cs.Class_Id},student_id = {cs.Student_Id} where id = {cs.Id}";
        var updated = _context.Connection().Execute(sql);
          if(updated > 0) return true;
            return false; 
    }

        public bool DeleteClassStudent(int id)
    {
        var sql = $"delete from class_student where id = {@id}";
        var deleted = _context.Connection().Execute(sql);
          if(deleted > 0) return true;
            return false;
    }


}
