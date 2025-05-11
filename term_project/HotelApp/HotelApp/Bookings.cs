namespace HotelApp
{
    internal class Bookings
    {
        public int Booking_ID { get; set; }
        public int Guest_ID { get; set; }
        public DateTime Check_in { get; set; }
        public DateTime Check_out { get; set; }
        public float Price { get; set; }
        public int Room_Number { get; set; }
    }
}