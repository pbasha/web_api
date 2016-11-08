using System.ComponentModel.DataAnnotations;

namespace web_api_test.Models
{
    public interface IReservation
    {
        int ReservationId { get; set; }

        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
             ErrorMessage = "Characters are not allowed.")]
        string ClientName { get; set; }

        [Required]
        string Location { get; set; }

        [Required]
        [RegularExpression(@"^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*
      @[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$")]
        string Email { get; set; }

        [Required]
        [RegularExpression(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}", ErrorMessage = "Invalid Phone Number!")]
        string Phone { get; set; }
    }
}