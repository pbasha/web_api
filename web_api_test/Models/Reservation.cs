using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web_api_test.Models
{
    public class Reservation : IReservation
    {
        public int ReservationId { get; set; }
        // Allow up to 40 uppercase and lowercase 
        // characters. Use custom error.
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
             ErrorMessage = "Characters are not allowed.")]
        public string ClientName { get; set; }

        [Required]
        public string Location { get; set; }

        [RegularExpression(@"^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*
      @[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}", ErrorMessage = "Invalid Phone Number!")]
        public string Phone { get; set; }
    }
}