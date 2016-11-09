using System.ComponentModel.DataAnnotations;

namespace web_api_test.Models
{
    public interface IReservation
    {
        int Id { get; set; }     
        string ClientName { get; set; }
        string Location { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
    }
}