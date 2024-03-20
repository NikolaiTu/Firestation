using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FirestationSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirestationSystem.View
{
    public partial class LoginView : Form
    {
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "WPe2TkIbVDH9tblNk7E3nRvsdRxqhuvGUhdWjZKn",
            BasePath = "https://school-firefightproject-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginView_Load(object sender, EventArgs e)
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
        }


        //public static string GlobalUsername;
        //public static string GlobalTeam;
        //public static string GlobalStatus;

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                MessageBox.Show("All fields must be filled");
            }
            else
            {
                FirebaseResponse response = client.Get("Users/");
                Dictionary<string, Register> result = response.ResultAs<Dictionary<string, Register>>();

                foreach (var get in result)
                {
                    string UserResult = get.Value.Name;
                    string PassResult = get.Value.Password;

                    if (UsernameTextBox.Text == UserResult)
                    {

                        if (PasswordTextBox.Text == PassResult)
                        {
                            GlobalVariables.GlobalUsername = UsernameTextBox.Text;
                            GlobalVariables.GlobalTeam = get.Value.Team;
                            GlobalVariables.GlobalStatus = get.Value.Status;
                            GlobalVariables.GlobalIdentifier = get.Key;

                            MessageBox.Show("Welcome " + UsernameTextBox.Text);

                            Hide();
                            PortalView portalView = new PortalView();
                            portalView.Show();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password");
                        }
                    }
                }
            }
        }

        private void RegisterViewButton_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterView registerView = new RegisterView();
            registerView.Show();
        }
    }
}
