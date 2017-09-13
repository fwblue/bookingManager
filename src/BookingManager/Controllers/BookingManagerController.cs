using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bookings.Models;

namespace BookingManager.Controllers
{
    [Route("api/BookingManager")]
    public class BookingManagerController
    {
        // POST api/values
        [HttpPost]
        public String Post([FromBody] Booking bookingMessage)
        {
            return Guid.NewGuid().ToString();
        }

        [HttpGet]
        public String Get([FromBody] Booking bookingMessage)
        {
            return Guid.NewGuid().ToString();
        }


    }
}
