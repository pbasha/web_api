using System.Collections.Generic;

namespace web_api_test.Models
{
    public interface IReservationRespository
    {
        IEnumerable<IReservation> GetAll();
        IReservation Add(IReservation item);
        bool Update(IReservation item);
        void Delete(int id);
        IReservation Get(int id);
}
}