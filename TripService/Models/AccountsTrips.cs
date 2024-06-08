namespace TripService.Models
{
    public class AccountsTrips
    {
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public int TripId { get; set; }
        public Trip Trip { get; set; }
        public int Luggage { get; set; }
    }

}
