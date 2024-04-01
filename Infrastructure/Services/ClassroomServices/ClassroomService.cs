using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services.ClassroomServices;

public class ClassroomService : IClassroomService
{
        private readonly DapperContext _context;
        public ClassroomService()
        {
            _context = new DapperContext();
        }
    public bool AddClassRooms(Classroom classrom)
    {
        var sql = $"insert into classroom(capacity,room_type,description,created_at,updated_at)"+
                $"values({classrom.Capacity},{classrom.RoomType},'{classrom.Description}','{classrom.Created_At}','{classrom.Updated_At}')";
                var inserted = _context.Connection().Execute(sql);
             if(inserted > 0) return true;
                return false;
    }


    public Classroom GetClassRoomById(int id)
    {
        var sql = $"select * from classroom where id = {@id}";
        var selected = _context.Connection().QueryFirstOrDefault(sql);
        return selected;

    }

    public List<Classroom> GetClassRooms()
    {
                var sql = $"select * from classroom ";
        var selected = _context.Connection().Query<Classroom>(sql).ToList();
        return selected;

    }

    public bool UpdateClassRooms(Classroom classrom)
    {
        var sql = $"update classroom set capacity={classrom.Capacity},room_type = {classrom.RoomType},description = '{classrom.Description}',updated_at = '{classrom.Updated_At}'";
        var updated = _context.Connection().Execute(sql);
        if(updated > 0 )return true;
        return false;
    }

    
    public bool DeleteClassRooms(int id)
    {
        var sql = $"delete from classroom where id = {@id}";
        var deleted = _context.Connection().Execute(sql);
         if(deleted > 0 )return true;
        return false;
    }

}
