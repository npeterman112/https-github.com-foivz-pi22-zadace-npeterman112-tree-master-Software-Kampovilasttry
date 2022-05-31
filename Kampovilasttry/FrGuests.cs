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
            ShowGuests();
        }
        private void ShowGuests()
        {
            List<Guest> guests = GuestRepository.GetGuests();
            dgvGuests.DataSource = guests;

            dgvGuests.Columns["GuestID"].DisplayIndex = 0;
            dgvGuests.Columns["FirstName"].DisplayIndex = 1;
            dgvGuests.Columns["LastName"].DisplayIndex = 2;
            dgvGuests.Columns["OIB"].DisplayIndex = 3;
            dgvGuests.Columns["Phone"].DisplayIndex = 4;
            dgvGuests.Columns["Age"].DisplayIndex = 5;

        }
    }
}
