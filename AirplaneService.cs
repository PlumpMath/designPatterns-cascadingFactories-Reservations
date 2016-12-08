using System;

namespace Reservations
{
    public class AirplaneService : IAirplaneService
    {
        public IVacationPart SelectFlight(string companyName, string origin, string destination, DateTime travelDate)
        {
            Console.WriteLine("Booking flight " + origin + " - " + destination + " on " + travelDate.ToString("dd-MMM-yyy")
                                + " using "+companyName);

            Console.WriteLine();

            return new AirplaneTicket(origin, destination);
        }
    }
}