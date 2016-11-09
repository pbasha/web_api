using System.Data.Entity;

namespace web_api_test.Models
{
    public class ResDBContext : DbContext
    {
        public DbSet<Reservation> Reservations { get; set; }
    }
}