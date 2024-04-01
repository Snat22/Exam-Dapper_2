using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services.StudentServices;

public class StudentService : IStudentService
{
    private readonly DapperContext _context;
    public StudentService()
    {
        _context = new DapperContext();
    }
    
    public bool AddStudent(Student student)
    {
        var sql = $"insert into students(student_code,fullname,gender,birthdate,email,phone,school_id,stage_in,sections,is_active,join_date,created_at,updated_at)"+
                $"values('{student.StudentCode}','{student.FullName}','{student.Gender}','{student.BirthDate}','{student.Email}','{student.Phone}',{student.School_Id},{student.Stage_In},'{student.Section}','{student.IsActive}','{student.JoinDate}','{student.Created_At}','{student.Updated_at}')";
                var inserted = _context.Connection().Execute(sql);
                 if(inserted > 0 )return true;
        return false;
    }


    public Student GetStudentById(int id)
    {
        var sql = $"select * from students where id={@id}";
        var selected = _context.Connection().QueryFirstOrDefault(sql);
        return selected;

    }

    public List<Student> GetStudents()
    {
        
        var sql = $"select * from students";
        var selected = _context.Connection().Query<Student>(sql).ToList();
        return selected;
    }

    public bool UpdateStudent(Student student)
    {
        var sql = $"update students set student_code = '{student.StudentCode}',fullname = '{student.FullName}',gender = '{student.Gender}',birthdate = '{student.BirthDate}',email = '{student.Email}',phone = '{student.Phone}',school_id = {student.School_Id},stage_in = {student.Stage_In},sections = '{student.Section}',is_active = '{student.IsActive}',join_date = '{student.JoinDate}',updated_at = '{student.Updated_at}' where id = {student.Id}";
        var updated = _context.Connection().Execute(sql);
         if(updated > 0 )return true;
        return false;

    }

        public bool DeleteStudent(int id)
    {
        var sql = $"delete from students where id = {@id}";
        var deleted = _context.Connection().Execute(sql);
        if(deleted > 0) return true;
        return false;
    }


}
