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
    public partial class FrParcel2 : Form
    {
        public FrParcel2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrParcel2_Load(object sender, EventArgs e)
        {
            ShowParcels();
        }
        private void ShowParcels()
        {
            List<Parcel> parcels = ParcelRepository.GetParcels();
            dgvParcels.DataSource = parcels;
        }
    }
}
