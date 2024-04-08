using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void TAdd(Room entity)
        {
            _roomDal.Add(entity);
        }

        public void TDelete(Room entity)
        {
            _roomDal.Delete(entity);
        }

        public Room TGetById(int id)
        {
            return _roomDal.GetById(id);
        }

        public List<Room> TGetFirstThreeRooms()
        {
            return _roomDal.GetFirstThreeRooms();
        }

        public List<Room> TGetList()
        {
            return _roomDal.GetList();
        }

        public void TUpdate(Room entity)
        {
            _roomDal.Update(entity);
        }
    }
}
