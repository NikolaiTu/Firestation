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
    public partial class AccountView : Form
    {
        public AccountView()
        {
            InitializeComponent();
        }

        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "WPe2TkIbVDH9tblNk7E3nRvsdRxqhuvGUhdWjZKn",
            BasePath = "https://school-firefightproject-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        private void AccountView_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                MessageBox.Show("connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FirebaseResponse response = client.Get("Statuses/");
            Dictionary<string, string> statusDictResult = response.ResultAs<Dictionary<string, string>>();

            foreach (var teamName in statusDictResult.Values)
            {
                StatusCmbBox.Items.Add(teamName);
            }

            UsernameLabel.Text = GlobalVariables.GlobalUsername;
            TeamLabel.Text = GlobalVariables.GlobalTeam;
            StatusLabel.Text = GlobalVariables.GlobalStatus;
        }

        private void StatusConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                var statusData = new
                {
                    Status = StatusCmbBox.Text
                };

                FirebaseResponse response = client.Update($"Users/{GlobalVariables.GlobalIdentifier}", statusData);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Status updated successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to update status.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
