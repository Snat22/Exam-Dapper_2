using Domain.Models;

namespace Infrastructure.Services.SchoolServices;

public interface ISchoolService
{
    List<School> GetSchools();
    School GetSchoolById(int id);
    bool AddSchool(School school);
    bool UpdateSchool(School school);
    bool DeleteSchool(int id);
}
