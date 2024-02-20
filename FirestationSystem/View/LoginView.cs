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

        public static string UsernamePass;
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
                            UsernamePass = UsernameTextBox.Text;

                            MessageBox.Show("Welcome " + UsernameTextBox.Text);
                            //Declare some public string so you can pass the data to the another Frame.
                            //home home = new home();
                            //this.Hide();
                            //home.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong username");
                    }
                }
            }
        }
    }
}
