using Domain.Models;
using Dapper;
using Infrastructure.DataContext;
namespace Infrastructure.Services.TeacherServices;

public class TeacherService : ITeacherService
{
    private readonly DapperContext _context;
    public TeacherService()
    {
        _context = new DapperContext();
    }
    public bool AddTeacher(Teacher teacher)
    {
        var sql = $"insert into teachers(teacher_code,fullname,gender,birthdate,email,phone,is_active,join_date,working_days,created_at,updated_at)"+
                $"values('{teacher.Teacher_Code}','{teacher.FullName}','{teacher.Gender}','{teacher.BirthDate}','{teacher.Email}','{teacher.Phone}','{teacher.IsActive}','{teacher.Join_Date}',{teacher.Working_Day},'{teacher.Created_At}','{teacher.Updated_At}')";
                var inserted = _context.Connection().Execute(sql);
                if (inserted > 0) return true;
                return false;
    }


    public Teacher GetTeacherById(int id)
    {
        var sql = $"select * from teacher where id={@id}";
        var selected = _context.Connection().QueryFirstOrDefault(sql);
        return selected;
    }

    public List<Teacher> GetTeachers()
    {
        var sql = $"select * from teacher";
                var selected = _context.Connection().Query<Teacher>(sql).ToList();
                return selected;
    }

    public bool UpdateTeacher(Teacher teacher)
    {
        var sql = $"update teachers set teacher_code = '{teacher.Teacher_Code}',fullname = '{teacher.FullName}',gender ='{teacher.Gender}',birthdate = '{teacher.BirthDate}',email = '{teacher.Email}',phone = '{teacher.Phone}',is_active = '{teacher.IsActive}',join_date = '{teacher.Join_Date}',working_days = {teacher.Working_Day},updated_at = '{teacher.Updated_At}' where id ={teacher.Id}";
        var updated = _context.Connection().Execute(sql);
         if(updated > 0 )return true;
        return false;
    }

        public bool DeleteTeacher(int id)
    {
        var sql = $"delete from teacher where id={@id}";
        var deleted = _context.Connection().Execute(sql);
        if(deleted > 0) return true;
        return false;
    }


}
