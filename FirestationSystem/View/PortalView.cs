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
    public partial class PortalView : Form
    {
        public PortalView()
        {
            InitializeComponent();
        }

        private void AccountViewButton_Click(object sender, EventArgs e)
        {
            Hide();
            AccountView account = new AccountView();
            account.Show();
        }

        private void DisasterViewButton_Click(object sender, EventArgs e)
        {
            Hide();
            IncidentView incidentView = new IncidentView();
            incidentView.Show();
        }

        private void VehicleViewButton_Click(object sender, EventArgs e)
        {
            Hide();
            VehicleView vehicleView = new VehicleView();
            vehicleView.Show();
        }
    }
}
