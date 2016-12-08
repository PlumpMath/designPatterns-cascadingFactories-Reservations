using System;

namespace Reservations
{
    public class VacationPartFactory : IVacationPartFactory
    {
        private IHotelSelector hotelSelector;
        private IHotelService hotelService;
        private IAirplaneService airplaneService;

        public VacationPartFactory(IHotelSelector hotelSelector,
                                    IHotelService hotelService,
                                    IAirplaneService airplaneService)
        {
            this.hotelSelector = hotelSelector;
            this.hotelService = hotelService;
            this.airplaneService = airplaneService;
        }

        public IVacationPart CreateDailyTrip(string tripName, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IVacationPart CreateFerryBooking(string lineName, bool fromMainland, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IVacationPart CreateFlight(string companyName, string source, string destination, DateTime date)
        {
            Console.WriteLine("Waiting for air ticketing service to respond...");
            return this.airplaneService.SelectFlight(companyName, source, destination, date);
        }

        public IVacationPart CreateHotelReservation(string town, string hotelName, DateTime arrivalDate, DateTime leaveDate)
        {
            Console.WriteLine("Looking up hotel " + hotelName + " in " + town);

            HotelInfo hotel = this.hotelSelector.SelectHotel(town, hotelName);

            Console.WriteLine("Waiting for remote hotel booking service to respond...");

            return this.hotelService.MakeBooking(hotel, arrivalDate, leaveDate);
        }

        public IVacationPart CreateMessage(string salon, DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}