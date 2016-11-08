using System;
using System.Collections.Generic;
using System.Web.Http;
using web_api_test.Models;

namespace web_api_test.Controllers
{
    public class WebController : ApiController
    {
        private IReservationRespository repo = ReservationRespository.Current;

        public IEnumerable<IReservation> GetAllReservations()
        {
            return repo.GetAll();
        }

        public IReservation GetReservation(int id)
        {
            return repo.Get(id);
        }

        [HttpPost]
        public IReservation CreateReservation(Reservation item)
        {
            return repo.Add(item);
        }

        [HttpPut]
        public bool UpdateReservation(IReservation item)
        {
            return repo.Update(item);
        }

        //public IReservation PostReservation(IReservation item)
        //{
        //    return repo.Add(item);
        //}

        //public bool PutReservation(IReservation item)
        //{
        //    return repo.Update(item);
        //}

        [HttpDelete]
        public void DeleteReservation(int id)
        {
            repo.Remove(id);
        }
    }
}
