using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelReservationSystem
{
    class Lop_Passenger
    {
        private string passengerfirstName;
        private string passengerLastName;
        private string passengerAge;

        //default constructor
        public Lop_Passenger()
        {
        }

        //overloaded constuctor
        public Lop_Passenger(string firstName, string lastName, string age)
        {
            passengerfirstName = firstName;
            passengerLastName = lastName;
            passengerAge = age;
        }

        //properties

        public string PassengerFirstname
        {
            get
            {
                return passengerfirstName;
            }
            set
            {
                passengerfirstName = value;
            }
        }

        public string PassengerLastName
        {
            get
            {
                return passengerLastName;
            }
            set
            {
                passengerLastName = value;
            }
        }

        public string PassengerAge
        {
            get
            {
                return passengerAge;
            }
            set
            {
                passengerAge = value;
            }
        }

        //override toString() method
        public override string ToString()
        {
            return "\nFull Name: " + passengerfirstName + " " + passengerLastName +
                "\nAge: " + passengerAge;
        }

    }
}
