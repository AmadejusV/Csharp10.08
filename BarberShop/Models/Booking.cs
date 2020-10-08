using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop.Models
{
    public class Booking
    {
        public Guid Id { get; set; }
        public Barber Barber { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public DateTime AvailableTime { get; set; }
        public Client Client { get; set; }

        public Booking()
        {
            Id = Guid.NewGuid();
        }
    }
}
