using DemoApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace DemoApi.Data
{
    public class ApiuContext : DbContext
    {
        public DbSet<HotelBooking> HotelBookings { get; set; }
        public ApiuContext(DbContextOptions<ApiuContext> options ) : base(options) 
        {
            
        }

    }
}
