namespace web_api_test.Models
{
    public interface IReservation
    {
        int ReservationId { get; set; }
        string ClientName { get; set; }
        string Location { get; set; }
    }
}