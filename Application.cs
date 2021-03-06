using System;

namespace Reservations
{
    public class Application
    {
        private IVacationPartFactory partFactory;

        public Application(IVacationPartFactory partFactory)
        {
            this.partFactory = partFactory;
        }

        public void Run()
        {
            VacationSpecificationBuilder builder =
                new VacationSpecificationBuilder(
                    this.partFactory,
                    new DateTime(2016, 12, 5), 14,
                    "Crouded City", "Seatown");

            builder.SelectHotel("Small one");
            builder.SelectAirplane("Noisy one");

            VacationSpecification spec = builder.BuildVacation();
        }
    }
}