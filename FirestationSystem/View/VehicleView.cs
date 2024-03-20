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
    public partial class VehicleView : Form
    {
        public VehicleView()
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
            FirebaseResponse response = client.Get("Vehicles/");
            Dictionary<string, Vehicles> vehicletDict = response.ResultAs<Dictionary<string, Vehicles>>();

            List<Vehicles> vehicles = vehicletDict.Values.ToList();
            DataGrid.DataSource = vehicles;
            DataGrid.Refresh();
        }

        private void VehicleView_Load(object sender, EventArgs e)
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
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var vehicleSubmissionController = new VehicleLogging(client);
            vehicleSubmissionController.AddVehicle(NameTextBox.Text, StatusTextBox.Text, ShiftStartTimeTextBox.Text, ShiftEndTimeTextBox.Text);

            NameTextBox.Clear();
            StatusTextBox.Clear();
            ShiftStartTimeTextBox.Clear();
            ShiftEndTimeTextBox.Clear();

            RefreshDisasterGrid();
        }
    }
}
