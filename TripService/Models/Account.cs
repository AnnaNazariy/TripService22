﻿using System.Collections.Generic;
using System;

namespace TripService.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public ICollection<AccountsTrips> AccountsTrips { get; set; }
    }

}
