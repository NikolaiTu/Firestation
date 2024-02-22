using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FirestationSystem.Controller;
using FirestationSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirestationSystem.View
{
    public partial class IncidentView : Form
    {
        private IncidentReport incidentReportController;
        private TruckLoader truckLoader;

        public IncidentView()
        {
            InitializeComponent();
        }

        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "WPe2TkIbVDH9tblNk7E3nRvsdRxqhuvGUhdWjZKn",
            BasePath = "https://school-firefightproject-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        private void IncidentView_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);

                FirebaseResponse response = client.Get("Disasters/DispatchedTrucks");
                List<string> dispatchedTruckNames = response.ResultAs<List<string>>();

                truckLoader = new TruckLoader(client);
                truckLoader.LoadTrucks(this.Controls, dispatchedTruckNames);

                response = client.Get("Disasters/");
                Dictionary<string, Incidents> incidentsResult = response.ResultAs<Dictionary<string, Incidents>>();

                List<Incidents> incidents = incidentsResult.Values.ToList();

                dataGridView1.DataSource = incidents;

                MessageBox.Show("Connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<Truck> GetSelectedTrucks()
        {
            List<Truck> selectedTrucks = new List<Truck>();

            foreach (var control in Controls)
            {
                if (control is CheckBox checkbox && checkbox.Checked)
                {
                    var truck = new Truck
                    {
                        TruckId = checkbox.Tag.ToString(),
                        Name = checkbox.Text,
                        Status = "Dispatched"
                    };

                    selectedTrucks.Add(truck);
                }
            }

            return selectedTrucks;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            List<Truck> selectedTrucks = GetSelectedTrucks();

            incidentReportController.AddIncident(NameTextBox.Text, GpsTextBox.Text, TypeTextBox.Text, DescriptionTextBox.Text, StatusTextBox.Text, selectedTrucks);

            NameTextBox.Clear();
            GpsTextBox.Clear();
            TypeTextBox.Clear();
            DescriptionTextBox.Clear();
            StatusTextBox.Clear();

            foreach (var control in Controls)
            {
                if (control is CheckBox checkbox)
                {
                    checkbox.Checked = false;
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            PortalView portalView = new PortalView();
            portalView.Show();
        }
    }
}
