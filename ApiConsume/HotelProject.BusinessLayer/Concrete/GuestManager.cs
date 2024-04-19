
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class GuestManager : IGuestService
    {
        private readonly IGuestDal _guestDal;

        public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public void TAdd(Guest entity)
        {
            _guestDal.Add(entity);
        }

        public void TDelete(Guest entity)
        {
            _guestDal.Delete(entity);
        }

        public Guest TGetById(int id)
        {
            return _guestDal.GetById(id);
        }

        public List<Guest> TGetList()
        {
            return _guestDal.GetList();
        }

        public void TUpdate(Guest entity)
        {
            _guestDal.Update(entity);
        }
    }
}
