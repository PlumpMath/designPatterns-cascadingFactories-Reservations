using System;

namespace Reservations
{
    public class AirplaneTicket : IVacationPart
    {
        private string departingFrom;
        private string goingTo;

        public AirplaneTicket(string departingFrom, string goingTo)
        {
            this.departingFrom = departingFrom;
            this.goingTo = goingTo;
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void Purchase()
        {
            Console.WriteLine("Making reservation - Flight " + departingFrom + " - " + goingTo);
        }

        public void Reserve()
        {
            throw new NotImplementedException();
        }
    }
}