
using Domain.Models;
using Infrastructure.Services.ClassroomServices;
using Infrastructure.Services.ClassServices;
using Infrastructure.Services.ParentServices;
using Infrastructure.Services.Realtions;
using Infrastructure.Services.SchoolServices;
using Infrastructure.Services.StudentServices;
using Infrastructure.Services.SubjectServices;
using Infrastructure.Services.TeacherServices;

var stdService = new StudentService();
var classroomService = new ClassroomService();
var classService = new ClassService();
var parentService = new ParentService();
var schoolService = new SchoolService();
var teachService = new TeacherService();
var sbService = new SubjectService();
var classRlService = new Class_StudentService();
var std_parentService = new Student_ParentService();

// var sc = new School()
// {
//     Title = "Test5",
//     Level_Count = 15,
//     Is_Active = 104,
//     Created_At = DateTime.UtcNow,
//     Updated_At = DateTime.UtcNow
// };

// schoolService.AddSchool(sc);

// foreach (var item in schoolService.GetSchools())
// {
//     System.Console.WriteLine(item.Title);
//     System.Console.WriteLine(item.Level_Count);
//     System.Console.WriteLine(item.Is_Active);
//     System.Console.WriteLine(item.Created_At);
// }

// var s = schoolService.GetSchoolById(id:1).ToString();
// System.Console.WriteLine(s);

// var up = new School()
// {
//     Id = 4,
//     Name = "TEST4.1",
//     Level_Count = 15,
//     Is_Active = 104,
//     Updated_At = DateTime.UtcNow
// };

// schoolService.UpdateSchool(up);

// schoolService.DeleteSchool(5);


// var subject = new Subject()
// {
//     Title = "JAVA",
//     School_Id = 4,
//     Stage = 1,
//     Created_At = DateTime.UtcNow,
//     Updated_At = DateTime.UtcNow
// };
// sbService.AddSubject(subject);

// foreach (var item in sbService.GetSubjects())
// {
//     System.Console.WriteLine(item.Title);
//     System.Console.WriteLine(item.School_Id);
//     System.Console.WriteLine(item.Stage);
//     System.Console.WriteLine(item.Created_At);
//     System.Console.WriteLine(item.Updated_At);
//  }
// var subUpd = new Subject()
// {
//     Id = 1,
//     Title = "C#2",
//     School_Id = 2,
//     Stage = 2,
//     Updated_At = DateTime.UtcNow
// };

// sbService.UpdateSubject(subUpd);

// sbService.DeleteSubject(5);

// var std = new Student()
// {
//     StudentCode = "AA5",
//     FullName = "Test5 testov5",
//     Gender = "male",
//     BirthDate = new DateTime(2001-04-04),
//     Email = "testov5@gmail.com",
//     Phone = "+0005",
//     School_Id = 4,
//     Stage_In = 1,
//     Section = "G5",
//     IsActive = "Is",
//     JoinDate = new DateTime(2010-03-02),
//     Created_At = DateTime.UtcNow,
//     Updated_at = DateTime.UtcNow
// };

// stdService.AddStudent(std);

// foreach (var item in stdService.GetStudents())
// {
//     System.Console.WriteLine(item.Id);
//     System.Console.WriteLine(item.StudentCode);
//     System.Console.WriteLine(item.FullName);
//     System.Console.WriteLine(item.Gender);
//     System.Console.WriteLine(item.BirthDate);
//     System.Console.WriteLine(item.Email);
//     System.Console.WriteLine(item.Phone);
//     System.Console.WriteLine(item.School_Id);
//     System.Console.WriteLine(item.Stage_In);
//     System.Console.WriteLine(item.Section);
//     System.Console.WriteLine(item.IsActive);
//     System.Console.WriteLine(item.JoinDate);
//     System.Console.WriteLine(item.Created_At);
//     System.Console.WriteLine(item.Updated_at);
// }

// var updStd = new Student()
// {
//     Id = 1,
//     StudentCode = "AA1.1",
//     FullName = "Test1.1 testov",
//     Gender = "female",
//     BirthDate = new DateTime(2001-05-01),
//     Email = "testov1.1@gmail.com",
//     Phone = "+0001.1",
//     School_Id = 1,
//     Stage_In = 2,
//     Section = "G",
//     IsActive = "Not",
//     JoinDate = new DateTime(2010-01-02),
//     Updated_at = DateTime.UtcNow
// };

// stdService.UpdateStudent(updStd);
// stdService.DeleteStudent(1);

// var parnt = new Parent()
// {
//     Parent_Code = "AAAA5",
//     FullName = "Test5t5",
//     Phone = "+5000",
//     Created_At = DateTime.UtcNow,
//     Updated_At = DateTime.UtcNow
// };
// parentService.AddParent(parnt);

// foreach (var item in parentService.GetParents())
// {
//     System.Console.WriteLine(item.Id);
//     System.Console.WriteLine(item.Parent_Code);
//     System.Console.WriteLine(item.FullName);
//     System.Console.WriteLine(item.Phone);
//     System.Console.WriteLine(item.Created_At);
//     System.Console.WriteLine(item.Updated_At);
// }

// var updParnt = new Parent()
// {
//     Id = 6,
//     Parent_Code = "AAAA5.5",
//     FullName = "Test5t5.1",
//     Phone = "+5000.1",
//     Updated_At = DateTime.UtcNow
// };
// parentService.UpdateParent(updParnt);
// parentService.DeleteParent(6);

// var std_parent = new Student_Parent()
// {
//     Student_Id = 2,
//     Parent_Id = 7,
// };
// std_parentService.AddStudent_Parent(std_parent);

// var teacher = new Teacher()
// {
//     Teacher_Code = "TT1",
//     FullName = "Teacher1T1",
//     Gender = "male",
//     BirthDate = new DateTime(1990-01-01),
//     Email = "Teacher1@gmail.com",
//     Phone = "+9991",
//     IsActive = "Is",
//     Join_Date = new DateTime(2020-01-01),
//     Working_Day = 123,
//     Created_At = DateTime.Now,
//     Updated_At = DateTime.Now
// };
// teachService.AddTeacher(teacher);

// foreach (var item in teachService.GetTeachers())
// {
//     System.Console.WriteLine(item.Id);
//     System.Console.WriteLine(item.FullName);
//     System.Console.WriteLine(item.Gender);
//     System.Console.WriteLine(item.BirthDate);
//     System.Console.WriteLine(item.Email);
// }

// var updTeacher = new Teacher()
// {
//     Id = 1,
//     Teacher_Code = "TT1.1",
//     FullName = "Teacher1T1.1",
//     Gender = "male",
//     BirthDate = new DateTime(1990-01-01),
//     Email = "Teacher1.1@gmail.com",
//     Phone = "+9991.1",
//     IsActive = "Is",
//     Join_Date = new DateTime(2020-02-01),
//     Working_Day = 125,
//     Created_At = DateTime.Now,
//     Updated_At = DateTime.Now

// };
// teachService.UpdateTeacher(updTeacher);
// teachService.DeleteTeacher(1);

// var classrom = new Classroom()
// {
//     Capacity = 21,
//     RoomType = 1,
//     Description = "TEst1",
//     Created_At = DateTime.Now,

//     Updated_At = DateTime.Now
// };
// classroomService.AddClassRooms(classrom);

// foreach (var item in classroomService.GetClassRooms())
// {
//     System.Console.WriteLine(item.Id);
//     System.Console.WriteLine(item.Capacity);
//     System.Console.WriteLine(item.Description);
//     System.Console.WriteLine(item.Created_At);
//     System.Console.WriteLine(item.Updated_At);
// }


// var classromUPD = new Classroom()
// {
//        Id = 1, 
//     Capacity = 22,
//     RoomType = 1,
//     Description = "TEst1",
//     Updated_At = DateTime.Now
// };
// classroomService.UpdateClassRooms(classromUPD);

// classroomService.DeleteClassRooms(1);

var clas = new Classes()
{
    CalssName = "Te1",
    Subject_Id = 1,
    Classroom_Id = 1,
    Section = "T1",
    Created_At = DateTime.Now,
    Updated_At = DateTime.Now
};
classService.AddClasses(clas);