using System.ComponentModel.DataAnnotations;

namespace DemoApi.Models
{
    public class HotelBooking
    {
        [Key]
        public int BookingId { get; set; }
        public int RoomNumber { get; set; }
        public string ClientName { get; set; }
    }
}
