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
    public partial class Lop_RoundTripTicket : Form
    {
        public Lop_RoundTripTicket()
        {
            InitializeComponent();
        }

        private void RoundTripTicket_Load(object sender, EventArgs e)
        {
            tbFullName.Text = Lop_Main.firstName + " " + Lop_Main.lastName;
            tbOrigin.Text = Lop_Main.origin;
            tbDestination.Text = Lop_Main.destination;
            tbFlightNumber.Text = Lop_Main.flightNum;
            tbDate.Text = Lop_Main.departureDate;
            tbGate.Text = Lop_Main.gate;

            tbFullName2.Text = Lop_Main.firstName + " " + Lop_Main.lastName;
            tbOrigin2.Text = Lop_Main.destination;
            tbDestination2.Text = Lop_Main.origin;
            tbFlightNumber2.Text = Lop_Main.flightNum;
            tbReturnDate2.Text = Lop_Main.returnDate;
            tbGate2.Text = Lop_Main.gate;
        }
    }
}
