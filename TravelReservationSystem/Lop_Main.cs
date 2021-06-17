using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelReservationSystem
{
    public partial class Lop_Main : Form
    {
        
        public static string flightType, flightNum, origin, destination, departureDate, returnDate, firstName, lastName, errorMessage, age, gate;
        public static int  miles, collectedMiles;
        public static double  flightFare, total;
        public static double processingFee = 30;
        public static double taxes = 1.15;
        public static bool isRoundtrip, isFrequentFlyer;

        Lop_Details details = new Lop_Details();
        Lop_FrequentFlyer[] frequentPassengers;
        private void Main_Load(object sender, EventArgs e)
        {
            
            
            frequentPassengers = new Lop_FrequentFlyer[5]; //allocates 5 spaces for frequent passengers
            frequentPassengers[0] = new Lop_FrequentFlyer("Jake", "Deen", "25", "123456", 2400);
            frequentPassengers[1] = new Lop_FrequentFlyer("John", "Michaels", "20", "789456", 1500);
            frequentPassengers[2] = new Lop_FrequentFlyer("Mika", "Reese", "40", "321578", 3500);
            frequentPassengers[3] = new Lop_FrequentFlyer("Jackie", "Wood", "25", "659784", 3800);
            frequentPassengers[4] = new Lop_FrequentFlyer("Rick", "Rol", "54", "246785", 4500);
        }

        private void rbRoundTrip_CheckedChanged(object sender, EventArgs e)
        {
            isRoundtrip = true;
            flightType = "Round Trip Flight";
            lblReturnDate.Visible = true;
            dateTimePickerReturnDate.Visible = true;
        }

        private void rbOneWay_CheckedChanged(object sender, EventArgs e)
        {
            flightType = "One Way Flight";
            dateTimePickerReturnDate.Visible = false;
            lblReturnDate.Visible = false;
        }

        private void btnAutoFill_Click(object sender, EventArgs e)
        {
            foreach (Lop_FrequentFlyer flyer in frequentPassengers)
            {
                if (flyer.FlyerNumber == tbFlyerNumber.Text)
                {
                    tbFirstName.Text = flyer.PassengerFirstname;
                    tbLastName.Text = flyer.PassengerLastName;
                    tbAge.Text = flyer.PassengerAge.ToString();
                }
                

            }
            
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            firstName = tbFirstName.Text;
        }

        private void dateTimePickerReturnDate_ValueChanged(object sender, EventArgs e)
        {
            returnDate = dateTimePickerReturnDate.Text;
        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {
            age = tbAge.Text;
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            lastName = tbLastName.Text;
        }


        private void cbFrequentFlyer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFrequentFlyer.Checked)
            {
                isFrequentFlyer = true;
                lblFlyerNumber.Visible = true;
                tbFlyerNumber.Visible = true;
                btnAutoFill.Visible = true;
                tbAge.ReadOnly = true;
                tbFirstName.ReadOnly = true;
                tbLastName.ReadOnly = true;
            }
            else
            {
                tbAge.ReadOnly = false;
                tbFirstName.ReadOnly = false;
                tbLastName.ReadOnly = false;
                lblFlyerNumber.Visible = false;
                tbFlyerNumber.Visible = false;
                btnAutoFill.Visible = false;
            }
        }

        private void dateTimePickerLeaveDate_ValueChanged(object sender, EventArgs e)
        {
            departureDate = dateTimePickerLeaveDate.Text;
        }

      
        public Lop_Main()
        {
            InitializeComponent();
        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void cbFlightList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFlightList.SelectedIndex == 1)
            {
                flightNum = "AZ3 6DS";
                tbOrigin.Text = origin = "Toronto";
                tbDestination.Text = destination = "Japan";
                miles = 6431;
                flightFare = 1000;
                gate = "G1";
            }
            else if (cbFlightList.SelectedIndex == 2)
            {
                flightNum = "JF4 FRE";
                tbOrigin.Text = origin = "Vancouver";
                tbDestination.Text = destination = "China";
                miles = 5875;
                flightFare = 1200;
                gate = "A4";
            }
            else if (cbFlightList.SelectedIndex == 3)
            {
                flightNum = "45G F8E";
                tbOrigin.Text = origin = "Toronto";
                tbDestination.Text  = destination = "China";
                miles = 6834;
                flightFare = 1400;
                gate = "T4";
            }
            else if (cbFlightList.SelectedIndex == 4)
            {
                flightNum = "46F 5DS";
                tbOrigin.Text = origin = "Korea";
                tbDestination.Text = destination = "Japan";
                miles = 576;
                flightFare = 500;
                gate = "V4";
            }
            else if (cbFlightList.SelectedIndex == 5)
            {
                flightNum = "BMN 978";
                tbOrigin.Text = origin = "London";
                tbDestination.Text =  destination = "Toronto";
                miles = 3574;
                flightFare = 900;
                gate = "L3";
            }

        }

        

        private void btnBookFlight_Click(object sender, EventArgs e)
        {
            Lop_Details details = new Lop_Details();
            if(rbOneWay.Checked != true && rbRoundTrip.Checked != true)
            {
                lblErrorMessage.Text = "Please select flight type";
                tabMainControl.SelectedTab = tpSearchFlight;
            }
            else if(cbFlightList.SelectedIndex == 0 || cbFlightList.Text == "")
            {
                lblErrorMessage.Text = "Please select flights";
                cbFlightList.Focus();
                tabMainControl.SelectedTab = tpSearchFlight;
            }
            else if (dateTimePickerLeaveDate.Value <= DateTime.Now)
            {
                lblErrorMessage.Text = "Please select another departure day";
                tabMainControl.SelectedTab = tpSearchFlight;
            }
            else if (rbRoundTrip.Checked && dateTimePickerLeaveDate.Value >= dateTimePickerReturnDate.Value )
            {
                lblErrorMessage.Text = "Please select other return day";
                tabMainControl.SelectedTab = tpSearchFlight;
            }
            /*else if (dateTimePickerLeaveDate.Value == dateTimePickerReturnDate.Value)
            {
                lblErrorMessage.Text = "Please select other return day";
                tabMainControl.SelectedTab = tpSearchFlight;
            validation for same day is not working
            }*/
            else if (tbFirstName.Text == "")
            {
                lblErrorMessage.Text = "Please enter first name";
                tbFirstName.Focus();
                tabMainControl.SelectedTab = tpPassengerInfo;
            }
            else if (tbLastName.Text == "")
            {
                tbLastName.Focus();
                lblErrorMessage.Text = "Please enter Last name";
                tabMainControl.SelectedTab = tpPassengerInfo;
            }
            else if (tbAge.Text == "")
            {
                tbAge.Focus();
                lblErrorMessage.Text = "Please enter age";
                tabMainControl.SelectedTab = tpPassengerInfo;
            }
            else
            {
                if(rbOneWay.Checked && cbFrequentFlyer.Checked)
                {
                    
                    
                    //retrives datas
                    Lop_Flight flight1 = new Lop_Flight();
                    flight1.FlightType = flightType;
                    flight1.FlightNumber = flightNum;
                    flight1.Origin = origin;
                    flight1.Destination = destination;
                    flight1.TravelDate = departureDate;


                    int postion = -1;
                    foreach (Lop_FrequentFlyer flyer in frequentPassengers)
                    {
                        if (flyer.FlyerNumber == tbFlyerNumber.Text)
                        {
                            postion++;
                        }
                    }
                   
                    collectedMiles = frequentPassengers[postion].CollectedMiles += miles;
                }
                if (rbOneWay.Checked && cbFrequentFlyer.Checked != true)
                {
                    Lop_Flight flight = new Lop_Flight();
                    flight.FlightType = flightType;
                    flight.FlightNumber = flightNum;
                    flight.Origin = origin;
                    flight.Destination = destination;
                    flight.TravelDate = departureDate;

                    Lop_Passenger passenger = new Lop_Passenger();
                    passenger.PassengerFirstname = firstName;
                    passenger.PassengerLastName = lastName;
                    passenger.PassengerAge = age;
                }
                if (rbRoundTrip.Checked && cbFrequentFlyer.Checked)
                {
                    Lop_FlightRoundTrip flightRoundTrip = new Lop_FlightRoundTrip();
                    flightRoundTrip.FlightType = flightType;
                    flightRoundTrip.FlightNumber = flightNum;
                    flightRoundTrip.Origin = origin;
                    flightRoundTrip.Destination = destination;
                    flightRoundTrip.TravelDate = departureDate;
                    flightRoundTrip.ReturnDate = returnDate;

                    int postion = -1;
                    foreach (Lop_FrequentFlyer flyer in frequentPassengers)
                    {
                        if (flyer.FlyerNumber == tbFlyerNumber.Text)
                        {
                            postion++;
                        }
                    }

                    collectedMiles = frequentPassengers[postion].CollectedMiles += (miles *2);
                }
                if (rbRoundTrip.Checked && cbFrequentFlyer.Checked != true)
                {
                    Lop_FlightRoundTrip flightRoundTrip = new Lop_FlightRoundTrip();
                    flightRoundTrip.FlightType = flightType;
                    flightRoundTrip.FlightNumber = flightNum;
                    flightRoundTrip.Origin = origin;
                    flightRoundTrip.Destination = destination;
                    flightRoundTrip.TravelDate = departureDate;
                    flightRoundTrip.ReturnDate = returnDate;

                    Lop_Passenger passenger = new Lop_Passenger();
                    passenger.PassengerFirstname = firstName;
                    passenger.PassengerLastName = lastName;
                    passenger.PassengerAge = age;
                }
                total = calculateFees();
                details.Show();

                
            }
           
        }


        private double calculateFees()
        {
            if(rbOneWay.Checked)
            {
                total = (flightFare + processingFee) * taxes;
            }
            else
                total = ((flightFare + processingFee) * taxes) *2;
            return total;
        }

        
    }
}
