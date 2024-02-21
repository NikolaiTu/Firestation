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
    }
}
