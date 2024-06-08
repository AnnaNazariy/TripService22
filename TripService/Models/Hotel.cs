using System.Collections.Generic;

namespace TripService.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int EmployeeCount { get; set; }
        public decimal BaseRate { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }

}
