using System;

namespace Reservations
{
    public class Hotel : IVacationPart
    {
        private HotelInfo hotelInfo;

        public Hotel(HotelInfo hotelInfo)
        {
            this.hotelInfo = hotelInfo;
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void Purchase()
        {
            Console.WriteLine("Making reservation - Hotel " + hotelInfo.Name + " in " + hotelInfo.Town);
        }

        public void Reserve()
        {
            throw new NotImplementedException();
        }
    }
}