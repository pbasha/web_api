using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_api_test.Models
{
    public class DBReservationRepository : IReservationRespository
    {

        public static DBReservationRepository Current
        {
            get
            {
                return repo;
            }
        }

        private static DBReservationRepository repo = new DBReservationRepository();

        private ResDBContext context = new ResDBContext();

        public IReservation Add(IReservation item)
        {
            context.Reservations.Add(item as Reservation);
            context.SaveChanges();
            return item;
        }

        public IReservation Get(int id)
        {
            return context.Reservations.Where(r => r.Id == id).FirstOrDefault();
        }

        public IEnumerable<IReservation> GetAll()
        {
            return context.Reservations;
        }

        public void Delete(int id)
        {
            Reservation item = Get(id) as Reservation;
            if (item != null)
            {
                context.Reservations.Remove(item);
                context.SaveChanges();
            }
        }

        public bool Update(IReservation item)
        {
            IReservation storedItem = Get(item.Id);
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