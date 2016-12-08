using System;

namespace Reservations
{
    public class HotelService : IHotelService
    {
        public IVacationPart MakeBooking(HotelInfo hotel, DateTime checkin, DateTime checkout)
        {
            Console.WriteLine("Booking hotel " + hotel.Name + " in " + hotel.Town + " " + checkin.ToString("dd-MMM-yyyy") + " " + checkout.ToString("dd-MMM-yyyy"));
            Console.WriteLine();

            return new Hotel(hotel);
        }
    }
}