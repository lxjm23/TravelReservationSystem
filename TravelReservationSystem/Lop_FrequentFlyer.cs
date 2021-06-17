using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelReservationSystem
{
    class Lop_FrequentFlyer : Lop_Passenger
    {
        private string flyerNumber;
        private int collectedMiles;

        //default constructor
        public Lop_FrequentFlyer()
            : base()
        {
        }

        // overloaded constructor
        public Lop_FrequentFlyer(string firstName, string lastName, string age,
            string flyerId, int milesCollected)
            : base(firstName, lastName, age) // calling base class for the constructor
        {
            flyerNumber = flyerId;
            collectedMiles = milesCollected;
        }

        // Properties

        public string FlyerNumber
        {
            get
            {
                return flyerNumber;
            }
            set
            {
                flyerNumber = value;
            }
        }

        public int CollectedMiles
        {
            get
            {
                return collectedMiles;
            }
            set
            {
                collectedMiles = value;
            }
        }

        //override to string method
        public override string ToString()
        {
            return base.ToString() + "Flyer Number: " + flyerNumber +
                "\nCollected Miles: " + collectedMiles;
        }
    }
}
