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

        private void RefreshDisasterGrid()
        {
            DataGrid.DataSource = null;
            DataGrid.Rows.Clear();
            FirebaseResponse response = client.Get("Disasters/");
            Dictionary<string, Incidents> incidentDict = response.ResultAs<Dictionary<string, Incidents>>();

            List<Incidents> incidents = incidentDict.Values.ToList();
            DataGrid.DataSource = incidents;
            DataGrid.Refresh();
        }

        private void IncidentView_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                MessageBox.Show("Connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            RefreshDisasterGrid();

            FirebaseResponse TeamsResponse = client.Get("Teams/");
            Dictionary<string, string> teamsResult = TeamsResponse.ResultAs<Dictionary<string, string>>();

            foreach (var teamName in teamsResult.Values)
            {
                cbmResponderBox.Items.Add(teamName);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var incidentReportController = new IncidentReport(client);
            incidentReportController.AddIncident(NameTextBox.Text, GpsTextBox.Text, TypeTextBox.Text, DescriptionTextBox.Text, StatusTextBox.Text, cbmResponderBox.SelectedItem.ToString());

            NameTextBox.Clear();
            GpsTextBox.Clear();
            TypeTextBox.Clear();
            DescriptionTextBox.Clear();
            StatusTextBox.Clear();

            RefreshDisasterGrid();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var incidentReportController = new IncidentReport(client);
            incidentReportController.RemoveIncident(DeletionTextBox.Text);
            RefreshDisasterGrid();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshDisasterGrid();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            PortalView portalView = new PortalView();
            portalView.Show();
        }
    }
}
