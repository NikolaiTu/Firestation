using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class EmployeesView : Form
    {
        public EmployeesView()
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
            FirebaseResponse response = client.Get("Users/");
            Dictionary<string, Users> result = response.ResultAs<Dictionary<string, Users>>();

            List<Users> users = result.Values.ToList();
            DataGrid.DataSource = users;
            DataGrid.Refresh();
        }

        private void EmployeesView_Load(object sender, EventArgs e)
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            PortalView portalView = new PortalView();
            portalView.Show();
        }
    }
}
