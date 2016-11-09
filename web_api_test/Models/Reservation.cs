using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web_api_test.Models
{
    public class Reservation : IReservation
    {
        public int ReservationId { get; set; }

        [DisplayName("Name: ")]
        [Required]
        [RegularExpression(@"^[a-z -']+$")]
        public string ClientName { get; set; }

        [DisplayName("Location: ")]
        [Required]
        [RegularExpression(@"^[a-z -']+$")]
        public string Location { get; set; }

        [DisplayName("Email: ")]
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Email { get; set; }

        [DisplayName("Phone: ")]
        [Required]
        [RegularExpression(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}", ErrorMessage = "Invalid Phone Number!")]
        public string Phone { get; set; }
    }
}