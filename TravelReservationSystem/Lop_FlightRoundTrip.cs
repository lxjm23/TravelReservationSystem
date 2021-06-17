using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelReservationSystem
{
    class Lop_FlightRoundTrip : Lop_Flight
    {
        private string returnDate;

        public Lop_FlightRoundTrip()
        {
        }

        public Lop_FlightRoundTrip(string flightOption, string flightNum, string from, string to, string dateOftravel, string dateReturn)
            : base(flightOption, flightNum, from, to, dateOftravel)
        {
            returnDate = dateReturn;
        }

        //property
        public string ReturnDate
        {
            get
            {
                return returnDate;
            }
            set
            {
                returnDate = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nReturn Date: " + returnDate;
        }

    }
}
