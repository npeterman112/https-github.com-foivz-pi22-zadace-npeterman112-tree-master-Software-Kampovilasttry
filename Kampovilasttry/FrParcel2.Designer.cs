namespace Kampovilasttry
{
    partial class FrParcel2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvParcels = new System.Windows.Forms.DataGridView();
            this.npeterman_DBDataSet2 = new Kampovilasttry.npeterman_DBDataSet2();
            this.npetermanDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npeterman_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npetermanDBDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParcels
            // 
            this.dgvParcels.AutoGenerateColumns = false;
            this.dgvParcels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcels.DataSource = this.npetermanDBDataSet2BindingSource;
            this.dgvParcels.Location = new System.Drawing.Point(12, 12);
            this.dgvParcels.Name = "dgvParcels";
            this.dgvParcels.Size = new System.Drawing.Size(776, 390);
            this.dgvParcels.TabIndex = 0;
            this.dgvParcels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // npeterman_DBDataSet2
            // 
            this.npeterman_DBDataSet2.DataSetName = "npeterman_DBDataSet2";
            this.npeterman_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // npetermanDBDataSet2BindingSource
            // 
            this.npetermanDBDataSet2BindingSource.DataSource = this.npeterman_DBDataSet2;
            this.npetermanDBDataSet2BindingSource.Position = 0;
            // 
            // FrParcel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvParcels);
            this.Name = "FrParcel2";
            this.Text = "FrParcel2";
            this.Load += new System.EventHandler(this.FrParcel2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npeterman_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npetermanDBDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParcels;
        private System.Windows.Forms.BindingSource npetermanDBDataSet2BindingSource;
        private npeterman_DBDataSet2 npeterman_DBDataSet2;
    }
}