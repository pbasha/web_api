using System.Collections.Generic;
using System.Linq;

namespace web_api_test.Models
{
    public class ReservationRespository : IReservationRespository
    {
        private static ReservationRespository repo = new ReservationRespository();

        public static ReservationRespository Current
        {
            get
            {
                return repo;
            }
        }

        private List<IReservation> data = new List<IReservation> {
            new Reservation {
                ReservationId = 1, ClientName = "Петр", Location = "Отель"},
            new Reservation {
                ReservationId = 2, ClientName = "Вася", Location = "Библиотека"},
            new Reservation {
                ReservationId = 3, ClientName = "Игорь", Location = "Столовая"},
        };

        public IEnumerable<IReservation> GetAll()
        {
            return data;
        }

        public IReservation Get(int id)
        {
            return data.Where(r => r.ReservationId == id).FirstOrDefault();
        }

        public IReservation Add(IReservation item)
        {
            item.ReservationId = data.Count + 1;
            data.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            IReservation item = Get(id);
            if (item != null)
            {
                data.Remove(item);
            }
        }

        public bool Update(IReservation item)
        {
            IReservation storedItem = Get(item.ReservationId);
            if (storedItem != null)
            {
                storedItem.ClientName = item.ClientName;
                storedItem.Location = item.Location;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}