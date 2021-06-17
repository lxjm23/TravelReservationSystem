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
    public partial class Lop_Details : Form
    {
        public Lop_Details()
        {
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            lblFlighType.Text = Lop_Main.flightType;
            lblFullName.Text = Lop_Main.firstName + " " + Lop_Main.lastName;
            lblAge.Text = Lop_Main.age;
            lblOrigin.Text = Lop_Main.origin;
            lblDestination.Text = Lop_Main.destination;
            lblFlightNumberShow.Text = Lop_Main.flightNum;
            lblDeptDate.Text = Lop_Main.departureDate;
            lblReturnDate.Text = Lop_Main.returnDate;
            if (Lop_Main.isRoundtrip == true)
            {
               
                string x = Lop_Main.flightFare.ToString();
                lblFlightFare.Text = Lop_Main.flightFare.ToString() + " + " + x;
            }
            else
            {
                lblFlightFare.Text = Lop_Main.flightFare.ToString();
            }
            if(Lop_Main.isFrequentFlyer == true)
            {
                lblCollectedMiles.Visible = true;
                lblCollectedMilesShow.Visible = true;
                lblCollectedMilesShow.Text = Lop_Main.collectedMiles.ToString();
            }

            lblProcFee.Text = Lop_Main.processingFee.ToString();
            lblTaxes.Text = Lop_Main.taxes.ToString() + "%";
            lblTotal.Text = "$" + Lop_Main.total.ToString();
            
        }

        private void btnPrintTicket_Click(object sender, EventArgs e)
        {
            if(Lop_Main.isRoundtrip == true)
            {
                Lop_RoundTripTicket roundTrip = new Lop_RoundTripTicket();
                roundTrip.Show();
            }
            else
            {
                Lop_Ticket ticket = new Lop_Ticket();
                ticket.Show();
            }
            
            
        }
    }
}
