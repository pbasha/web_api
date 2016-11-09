using System.Data.Entity;

namespace web_api_test.Models
{
    public class ReservationContext : DbContext
    {
        public DbSet<Reservation> Reservations { get; set; }
    }
}