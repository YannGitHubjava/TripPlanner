using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripPlanner.Properties;

namespace TripPlanner
{
    public partial class frmNewTrip : Form
    {
        public frmNewTrip()
        {
            InitializeComponent();
        }

        private void frmNewTrip_Load(object sender, EventArgs e)
        {
            // Build all of the hotels and attractions for each destination.
            // TODO: Automate this?

            // California
            Hotel[] caHotels =
            {
                new Hotel("Rancho Valencia Resort & Spa", 5, 550, Resources.CA_H_05),
                new Hotel("Hotel Drisco", 4, 450,  Resources.CA_H_04),
                new Hotel("Simpson House Inn", 3, 350,  Resources.CA_H_03),
                new Hotel("Bay Shores Peninsula Hotel", 2, 150,  Resources.CA_H_02),
                new Hotel("Cosmopolitan Hotel", 1, 125,  Resources.CA_H_01)
            };
            Attraction[] caAttractions =
            {
                new Attraction("Yosemite National Park", Resources.CA_A_01),
                new Attraction("Golden Gate Bridge", Resources.CA_A_02),
                new Attraction("Lake Tahoe", Resources.CA_A_03),
                new Attraction("Big Sur Coastline", Resources.CA_A_04),
                new Attraction("Disneyland", Resources.CA_A_05)
            };
            Destination california = new Destination("Sacramento, California", caHotels, caAttractions);

            // Nevada
            Hotel[] nvHotels =
            {
                new Hotel("Mandarin Oriental Las Vegas", 5, 250, Resources.NV_H_05),
                new Hotel("Hyatt Regency Lake Tahoe Resort", 4, 150 ,Resources.NV_H_04),
                new Hotel("BEST WESTERN PLUS Henderson Hotel", 3, 125, Resources.NV_H_03),
                new Hotel("Comfort Inn & Suites Airport", 2, 75, Resources.NV_H_02),
                new Hotel("Motel 6 Carson City", 1, 60, Resources.NV_H_01)
            };
            Attraction[] nvAttractions =
            {
                new Attraction("Las Vegas Strip", Resources.NV_A_01),
                new Attraction("National Automobile Museum", Resources.NV_A_02),
                new Attraction("Las Vegas Bellagio Fountains", Resources.NV_A_03),
                new Attraction("Fremont Street Experience", Resources.NV_A_04),
                new Attraction("Hoover Dam", Resources.NV_A_05)
            };
            Destination nevada = new Destination("Carson City, Nevada", nvHotels, nvAttractions);

            // Colorado
            Hotel[] coHotels =
            {
                new Hotel("The Little Nell", 5, 650, Resources.CO_H_05),
                new Hotel("Inn at Lost Creek", 4, 250, Resources.CO_H_04),
                new Hotel("BlueSky Breckenridge", 3, 400, Resources.CO_H_03),
                new Hotel("Alpine Trail Ridge Inn", 2, 150, Resources.CO_H_02),
                new Hotel("Rodeway Inn Manitou Springs", 1, 75, Resources.CO_H_01)
            };
            Attraction[] coAttractions =
            {
                new Attraction("Garden of the Gods", Resources.CO_A_01),
                new Attraction("Mesa Verde National Park", Resources.CO_A_02),
                new Attraction("Great Sand Dunes National Park", Resources.CO_A_03),
                new Attraction("Vail Ski Resort", Resources.CO_A_04),
                new Attraction("Denver Museum of Nature and Science", Resources.CO_A_05)
            };
            Destination colorado = new Destination("Denver, Colorado", coHotels, coAttractions);

            // DC
            Hotel[] dcHotels =
            {
                new Hotel("The Jefferson", 5, 450, Resources.DC_H_05),
                new Hotel("Hotel Sofitel", 4, 250, Resources.DC_H_04),
                new Hotel("Carlyle Suites Hotel", 3, 130, Resources.DC_H_03),
                new Hotel("Hampton Inn Columbia", 2, 150, Resources.DC_H_02),
                new Hotel("Budget Host Travelers Motel", 1, 75, Resources.DC_H_01)
            };
            Attraction[] dcAttractions =
            {
                new Attraction("DC Capital Region", Resources.DC_A_01),
                new Attraction("Tour National Monuments and Memorials", Resources.DC_A_02),
                new Attraction("Tour the Three Houses of Government", Resources.DC_A_03),
                new Attraction("Walk Through Georgetown", Resources.DC_A_04),
                new Attraction("Walk, Bike or Kayak Along the C & O Canal", Resources.DC_A_05)
            };
            Destination washingtonDc = new Destination("Washington DC", dcHotels, dcAttractions);

            // Texas
            Hotel[] txHotels =
            {
                new Hotel("The St. Regis Houston", 5, 200, Resources.TX_H_05),
                new Hotel("The Inn at Dos Brisas", 4, 1200, Resources.TX_H_04),
                new Hotel("Best Western Premier Crown Chase Inn & Suites", 3, 125, Resources.TX_H_03),
                new Hotel("Comfort Suites Bay City", 2, 110, Resources.TX_H_02),
                new Hotel("Value Place Baytown", 1, 75, Resources.TX_H_01)
            };
            Attraction[] txAttractions =
            {
                new Attraction("The Alamo", Resources.TX_A_01),
                new Attraction("San Antonio River Walk (Paseo del Rio)", Resources.TX_A_02),
                new Attraction("Texas State Capitol", Resources.TX_A_03),
                new Attraction("Dallas World Aquarium", Resources.TX_A_04),
                new Attraction("Padre Island National Seashore", Resources.TX_A_05)
            };
            Destination texas = new Destination("Austin, Texas", txHotels, txAttractions);

            // Add all of the destinations to the combo box.
            cboDestination.Items.Add("Select a destination...");
            cboDestination.Items.Add(california);
            cboDestination.Items.Add(nevada);
            cboDestination.Items.Add(colorado);
            cboDestination.Items.Add(washingtonDc);
            cboDestination.Items.Add(texas);
            cboDestination.SelectedIndex = 0;

            // Set the min start and end dates to today and tomorrow respectively.
            dtpStart.MinDate = DateTime.Now;
            dtpEnd.MinDate = DateTime.Now.AddDays(1);
        }

        // Updates the hotels and attractions when the destination changes.
        private void UpdateForm(object sender, EventArgs e)
        {
            UpdateHotels();
            UpdateAttractions();
        }
        
        // Updates the hotels combo box.
        private void UpdateHotels()
        {
            // Clear combo box if no distination is selected.
            if (cboDestination.SelectedIndex < 1)
            {
                cboHotel.SelectedIndex = -1;
                cboHotel.Items.Clear();
                cboHotel.Enabled = false;
            }
            // Update the list of hotels.
            else
            {
                cboHotel.Items.Clear();
                Destination selectedDestination = (Destination) cboDestination.SelectedItem;
                cboHotel.Items.Add("Select a Hotel...");
                cboHotel.Items.AddRange(selectedDestination.Hotels);
                cboHotel.SelectedIndex = 0;
                cboHotel.Enabled = true;
            }
        }

        // Displays hotel information on the form.
        private void UpdateHotelInfo(object sender, EventArgs e)
        {
            // Clear hotel information if no hotel is selected.
            if (cboHotel.SelectedIndex < 1)
            {
                picHotel.Image = null;
                lblHotelCost.Text = "";
                lblHotelRating.Text = "";
            }
            // Grab hotel information and display it.
            else
            {
                Hotel selectedHotel = (Hotel)cboHotel.SelectedItem;

                // Display the hotel rating.
                // Build a string showing the rating with a number of stars.
                string stars = "";
                for (int i = 0; i < selectedHotel.Stars; i++)
                {
                    if (i < selectedHotel.Stars)
                    {
                        stars += "\u2605";
                    }
                }
                lblHotelRating.Text = string.Format("Rating: {0:n0} stars ({1})", selectedHotel.Stars, stars);

                // Display the hotel cost.
                lblHotelCost.Text = string.Format("Cost per night: {0:c}", selectedHotel.Price);
                
                // Display hotel picture.
                picHotel.Image = selectedHotel.Picture;
            }
        }

        // Updates the attractions list box.
        private void UpdateAttractions()
        {
            // Clear attractions list box if no destination is selected.  
            if (cboDestination.SelectedIndex < 1)
            {
                lstAttractions.SelectedIndex = -1;
                lstAttractions.Items.Clear();
            }
            // Update the list of attractions.
            else
            {
                lstAttractions.SelectedIndex = -1;
                lstAttractions.Items.Clear();
                Destination selectedDestination = (Destination) cboDestination.SelectedItem;
                lstAttractions.Items.AddRange(selectedDestination.Attractions);
            }

        }

        // Updates the attraction picture box to match the selected attraction.
        private void UpdateAttractionPicture(object sender, EventArgs e)
        {
            // Clear the picture if no attraction is selected.
            if (lstAttractions.SelectedIndex < 0)
            {
                picAttraction.Image = null;
            }
            // Update the picture box.
            else
            {
                Attraction selectedAttraction = (Attraction) lstAttractions.SelectedItem;
                picAttraction.Image = selectedAttraction.Picture;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            // Leave this method if the data is invalid.
            if (!IsValidData())
            {
                return;
            }

            Trip trip = new Trip(dtpStart.Value, dtpEnd.Value, (Destination) cboDestination.SelectedItem, (Hotel) cboHotel.SelectedItem);
            Form frmTripPlan = new frmTripPlan();
            frmTripPlan.Tag = trip;
            frmTripPlan.Show();
        }

        private bool IsValidData()
        {

            return
                // Check if the destination and hotel are selected.
                IsSelected(cboDestination) && IsSelected(cboHotel) && IsValidDateRange();

        }
        
        private bool IsSelected(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex < 1)
            {
                MessageBox.Show("You must select a " + comboBox.Tag + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidDateRange()
        {
            if (dtpEnd.Value <= dtpStart.Value)
            {
                MessageBox.Show("The end date must be at least one day after the start date.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpStart.Focus();
                return false;
            }

            return true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            cboDestination.SelectedIndex = 0;
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now.AddDays(1);
        }
    }
}
