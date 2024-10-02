using DemoApi.Data;
using DemoApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HotelBookingController : ControllerBase
    {
        private readonly ApiuContext _context;
        public HotelBookingController(ApiuContext context)
        {
            _context = context;
        }
        //create and edit
        [HttpPost]
        public JsonResult CreateEdit(HotelBooking booking)
        {
            if (booking.BookingId == 0)
            {
                _context.HotelBookings.Add(booking);
            }
            else
            {
                var check = _context.HotelBookings.Find(booking.BookingId);
                if (check == null)
                {
                    return new JsonResult(NotFound());
                }
                check = booking;
            }
            _context.SaveChanges();
            return new JsonResult(Ok(booking));
        }
        //get hotel booking 
        [HttpGet]
        public JsonResult Get(int id)
        {
            var result = _context.HotelBookings.Find(id);
            if(result == null)
            {
                return new JsonResult(NotFound());
            }
            return new JsonResult(Ok(result));
        }

        //delete hotelbooking 
        [HttpDelete]
        public JsonResult delete(int id)
        {
            var res = _context.HotelBookings.Find(id);
            if (res == null)
            {
                return new JsonResult(NotFound());
            }
            _context.HotelBookings.Remove(res);
            _context.SaveChanges();

            ;
            return new JsonResult(NoContent());

        }
        [HttpGet]
        //get all hotelbooking 
        public JsonResult GetAllBooking()
        {
            var resultss = _context.HotelBookings.ToList();
            return new JsonResult(Ok(resultss));


        }

    }
}
