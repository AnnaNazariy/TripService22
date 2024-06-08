using System.Collections.Generic;

namespace TripService.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }

}
