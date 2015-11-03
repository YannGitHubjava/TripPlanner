using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TripPlanner
{
    public partial class frmTripPlan : Form
    {
        public frmTripPlan()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTripPlan_Load(object sender, EventArgs e)
        {
            this.Show();

            Trip trip = (Trip) this.Tag;

            // Build the trip plan.
            string newLine = Environment.NewLine;
            string tripString = "";
            tripString += "Destination: " + trip.Destination + newLine;
            tripString += "Start Date: " + trip.StartDate.ToShortDateString() + newLine;
            tripString += "End Date: " + trip.EndDate.ToShortDateString() + newLine;
            tripString += "Hotel:" + newLine;
            tripString += "\t" + trip.Hotel + newLine;
            tripString += "\tRating: " + trip.Hotel.Stars + "stars." + newLine;
            tripString += "\tCost per night: " + trip.Hotel.Price.ToString("c") + newLine;
            decimal totalCost = trip.Hotel.Price * (trip.EndDate - trip.StartDate).Days;
            tripString += "\tTotal Cost: " + totalCost.ToString("c") + newLine;
            tripString += "Attractions:" + newLine;
            foreach (var attraction in trip.Destination.Attractions)
            {
                tripString += "\t" + attraction + newLine;
            }

            txtPlan.Text = tripString;
            txtPlan.Select(0, 0);
        }
    }
}
