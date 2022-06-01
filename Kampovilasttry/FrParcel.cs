using DBLayer;
using Kampovilasttry.Models;
using Kampovilasttry.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kampovilasttry
{
    public partial class FrParcel : Form
    {
        private Guest selectedGuest;

        public FrParcel()
        {
            InitializeComponent();
        }

        public FrParcel(Guest selectedGuest)
        {
            this.selectedGuest = selectedGuest;
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            FrMenu frMenu = new FrMenu();
            Hide();
            frMenu.ShowDialog();
            Close();
        }

        private void FrParcel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'npeterman_DBDataSet2.Parcels' table. You can move, or remove it, as needed.
            this.parcelsTableAdapter.Fill(this.npeterman_DBDataSet2.Parcels);
        }

        private void btnInput_Click(object sender, EventArgs e)
        {

            if (txtID.Text != "" && txtCapacity.Text != "" && txtPrice.Text != "" && txtSeason.Text != "" && txtType.Text != "")
            {
                DB.SetConfiguration(database: "npeterman_DB",
                                       username: "npeterman",
                                       password: "SY&$1!WH");
                DB.OpenConnection();
                var sql = "INSERT INTO Parcels (Id, Type, Capacity, Season, Price) VALUES ("+ txtID.Text +"," + "'"+ txtType.Text +"'"+"," + txtCapacity.Text +","+"'"+ txtSeason.Text+"'"+","+ txtPrice.Text +")";
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
                FrParcel frParcel = new FrParcel();
                Hide();
                frParcel.ShowDialog();
                Close();
            };
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FrParcel frParcel = new FrParcel();
            Hide();
            frParcel.ShowDialog();
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult mb = MessageBox.Show("Proceed with deletion?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(mb == DialogResult.Yes)
            {
              foreach(DataGridViewRow row in dgvParcels.SelectedRows)
                {
                    dgvParcels.Rows.Remove(row);
                    this.parcelsTableAdapter.Update(this.npeterman_DBDataSet2.Parcels);
                }
            }
        }

        private void dgvParcels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DB.OpenConnection();
            string searchValue = txtID.Text;
            try
            {
                var re = from row in npeterman_DBDataSet2.Parcels.AsEnumerable() where row[0].ToString().Equals(searchValue) select row;
                if (re.Count() == 0)
                {
                    MessageBox.Show("No Row");
                }
                else
                {
                    dgvParcels.DataSource=re.CopyToDataTable();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
    }
}

