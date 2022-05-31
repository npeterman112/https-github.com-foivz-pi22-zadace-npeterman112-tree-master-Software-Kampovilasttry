using Kampovilasttry.Models;
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

        private void button1_Click(object sender, EventArgs e)
        {

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

        }
    }
}
