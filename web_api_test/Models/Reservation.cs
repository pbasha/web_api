using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_api_test.Models
{
    public class Reservation : IReservation
    {
        public int ReservationId { get; set; }
        public string ClientName { get; set; }
        public string Location { get; set; }
    }
}