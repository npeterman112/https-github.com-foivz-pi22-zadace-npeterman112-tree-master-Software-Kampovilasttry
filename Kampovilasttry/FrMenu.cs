using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kampovilasttry
{
    public partial class FrMenu : Form
    {
        public FrMenu()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrLogin frLogin = new FrLogin();
            Hide();
            frLogin.ShowDialog();
            Close();
        }

        private void btnAccomodationList_Click(object sender, EventArgs e)
        {

        }

        private void btnGuestList_Click(object sender, EventArgs e)
        {
            FrGuests frGuests = new FrGuests();
            Hide();
            frGuests.ShowDialog();
            Close();
        }
    }
}
