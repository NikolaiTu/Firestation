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
            FirebaseResponse response = client.Get("Disasters/");
            Dictionary<string, Incidents> incidentDict = response.ResultAs<Dictionary<string, Incidents>>();

            FirebaseResponse TeamsResponse = client.Get("Teams/");
            Dictionary<string, string> teamsResult = TeamsResponse.ResultAs<Dictionary<string, string>>();

            List<Incidents> incidents = incidentDict.Values.ToList();
            DataGrid.DataSource = incidents;

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
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            PortalView portalView = new PortalView();
            portalView.Show();
        }
    }
}
