using System;

namespace Reservations
{
    public class HotelSelector : IHotelSelector
    {
        public HotelInfo SelectHotel(string town, string hotelName)
        {
            return new HotelInfo()
            {
                Name = hotelName,
                Town = town
            };
        }
    }
}