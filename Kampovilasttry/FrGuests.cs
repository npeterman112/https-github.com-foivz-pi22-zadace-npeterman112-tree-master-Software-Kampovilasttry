using Kampovilasttry.Models;
using Kampovilasttry.Repositories;
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
    public partial class FrGuests : Form
    {
        public FrGuests()
        {
            InitializeComponent();
        }

        private void FrGuests_Load(object sender, EventArgs e)
        {
            ShowGuests1();
        }
        private void ShowGuests1()
        {
            List<Guest> guests1 = GuestRepository.GetGuests();
            dgvGuests.DataSource = guests1;

            dgvGuests.Columns["GuestID"].DisplayIndex = 0;
            dgvGuests.Columns["FirstName"].DisplayIndex = 1;
            dgvGuests.Columns["LastName"].DisplayIndex = 2;
            dgvGuests.Columns["OIB"].DisplayIndex = 3;
            dgvGuests.Columns["Phone"].DisplayIndex = 4;
            dgvGuests.Columns["Age"].DisplayIndex = 5;

        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            Guest selectedGuest = dgvGuests.CurrentRow.DataBoundItem as Guest;
            if (selectedGuest != null)
            {
                FrParcel frmParcel = new FrParcel(selectedGuest);
                frmParcel.ShowDialog();
            }

        }

        private void dgvGuests1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
