namespace HotelProject.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TAdd(T entity);

        void TDelete(T entity);

        void TUpdate(T entity);

        List<T> TGetList();

        T TGetById(int id);
    }
}
