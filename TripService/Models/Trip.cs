using System.Collections.Generic;
using System;

namespace TripService.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public DateTime BookDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime? CancelDate { get; set; }
        public ICollection<AccountsTrips> AccountsTrips { get; set; }
    }

}
