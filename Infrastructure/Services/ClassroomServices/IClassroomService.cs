using Domain.Models;

namespace Infrastructure.Services.ClassroomServices;

public interface IClassroomService
{
    List<Classroom> GetClassRooms();
    Classroom GetClassRoomById(int id);
    bool AddClassRooms(Classroom classrom);
    bool UpdateClassRooms(Classroom classrom);
    bool DeleteClassRooms(int id);
}
