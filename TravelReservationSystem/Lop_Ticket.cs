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
    public partial class Lop_Ticket : Form
    {
        public Lop_Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            tbFullName.Text = Lop_Main.firstName + " " + Lop_Main.lastName;
            tbOrigin.Text = Lop_Main.origin;
            tbDestination.Text = Lop_Main.destination;
            tbFlightNumber.Text = Lop_Main.flightNum;
            tbDate.Text = Lop_Main.departureDate;
            tbGate.Text = Lop_Main.gate;
        }

        
    }
}
