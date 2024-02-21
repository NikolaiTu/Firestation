using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FirestationSystem.Model;
using FirestationSystem.View;

namespace FirestationSystem
{
    public partial class RegisterView : Form
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "WPe2TkIbVDH9tblNk7E3nRvsdRxqhuvGUhdWjZKn",
            BasePath = "https://school-firefightproject-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        private void RegisterView_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);

                FirebaseResponse response = client.Get("Teams/");
                Dictionary<string, string> teamsResult = response.ResultAs<Dictionary<string, string>>();

                foreach (var teamName in teamsResult.Values)
                {
                    cbmTeamBox.Items.Add(teamName);
                }

                MessageBox.Show("connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(UsernameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text) || string.IsNullOrEmpty(cbmTeamBox.SelectedText))
            {
                MessageBox.Show("All fields must be filled");
            }
            else
            {
                var Register = new Register
                {
                    Name = UsernameTextBox.Text,
                    Password = PasswordTextBox.Text,
                    Team = cbmTeamBox.SelectedItem.ToString(),
                    Status = "Available"
                };

                //.push creates unique key
                FirebaseResponse response = client.Push("Users/", Register);

                Register res = response.ResultAs<Register>();
                MessageBox.Show("Register Account Successfully");
                //id.Text = string.Empty;
                //username.Text = string.Empty;
                //password.Text = string.Empty;
            }
        }

        private void RegisterViewButton_Click(object sender, EventArgs e)
        {
            Hide();
            LoginView loginView = new LoginView();
            loginView.Show();
        }
    }
}
