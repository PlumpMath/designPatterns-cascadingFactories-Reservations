using System;
using System.Collections.Generic;

namespace Reservations
{
    public class VacationSpecificationBuilder
    {
        private IList<IVacationPart> parts = new List<IVacationPart>();

        private IVacationPartFactory partFactory;

        private DateTime arrivalDate;
        private int totalNights;

        private string livingTown;
        private string destinationTown;

        public VacationSpecificationBuilder(IVacationPartFactory partFactory,
                                            DateTime arrivalDate,
                                            int totalNights,
                                            string livingTown,
                                            string destinationTown)
        {
            this.partFactory = partFactory;

            this.arrivalDate = arrivalDate;
            this.totalNights = totalNights;

            this.livingTown = livingTown;
            this.destinationTown = destinationTown;
        }

        public void SelectHotel(string hotelName)
        {
            IVacationPart part = this.partFactory.CreateHotelReservation(this.destinationTown, hotelName, this.arrivalDate,
                                                                            this.arrivalDate.AddDays(this.totalNights));
            this.parts.Add(part);
        }

        public void SelectAirplane(string companyName)
        {
            this.parts.Add(CreateFlightToDestination(companyName));
            this.parts.Add(CreateFlightBack(companyName));
        }

        public VacationSpecification BuildVacation()
        {
            foreach (IVacationPart part in this.parts)
            {
                part.Purchase();
            }

            return new VacationSpecification(this.parts);
        }

        private IVacationPart CreateFlightToDestination(string companyName)
        {
            return this.partFactory.CreateFlight(companyName, this.livingTown, this.destinationTown, this.arrivalDate);
        }
        private IVacationPart CreateFlightBack(string companyName)
        {
            return this.partFactory.CreateFlight(companyName, this.destinationTown, this.livingTown,
                                                    this.arrivalDate.AddDays(this.totalNights));
        }
    }
}