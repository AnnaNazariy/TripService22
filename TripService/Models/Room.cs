﻿using System.Collections.Generic;

namespace TripService.Models
{
    public class Room
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public int Beds { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public ICollection<Trip> Trips { get; set; }
    }

}
