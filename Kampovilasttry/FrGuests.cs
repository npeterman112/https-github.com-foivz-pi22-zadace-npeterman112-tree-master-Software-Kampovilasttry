using DBLayer;
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
            // TODO: This line of code loads data into the 'npeterman_DBDataSet3.Guests' table. You can move, or remove it, as needed.
            this.guestsTableAdapter.Fill(this.npeterman_DBDataSet3.Guests);
            ShowGuests1();
        }
        private void ShowGuests1()
        {

            DB.SetConfiguration(database: "npeterman_DB",
                                username: "npeterman",
                                password: "SY&$1!WH");



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
