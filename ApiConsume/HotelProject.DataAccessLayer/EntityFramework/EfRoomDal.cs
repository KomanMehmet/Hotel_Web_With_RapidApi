
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfRoomDal : GenericRepository<Room>, IRoomDal
    {
        public EfRoomDal(Context context) : base(context)
        {
        }

        public List<Room> GetFirstThreeRooms()
        {
            using var context = new Context();

            var values = context.Rooms.OrderBy(x => x.RoomID).Take(3).ToList();

            return values;
        }
    }
}
