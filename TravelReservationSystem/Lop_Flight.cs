using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelReservationSystem
{
    class Lop_Flight
    {
        private string flightType;
        private string flightNumber;
        private string source;
        private string destination;
        private string travelDate;


        //default constructor
        public Lop_Flight()
        {
        }

        //overloaded Construtor
        public Lop_Flight(string flightOption, string flightNum, string from, string to, string dateOftravel)
        {
            flightType = flightOption;
            flightNumber = flightNum;
            source = from;
            destination = to;
            travelDate = dateOftravel;
        }

        // properties for private 

        public string FlightType
        {
            get
            {
                return flightType;
            }
            set
            {
                flightType = value;
            }
        }
        public string FlightNumber
        {
            get
            {
                return flightNumber;
            }
            set
            {
                flightNumber = value;
            }
        }

        public string Origin
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
            }
        }

        public string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }

        public string TravelDate
        {
            get
            {
                return travelDate;
            }
            set
            {
                travelDate = value;
            }
        }

        //override toString method()
        public override string ToString()
        {
            return "Flight Type: " + flightType +
                "\nFlight Number: " + flightNumber +
                "\nFrom: " + source +
                "\nTo: " + destination +
                "\nTravel Date: " + travelDate;
        }

    }
}
