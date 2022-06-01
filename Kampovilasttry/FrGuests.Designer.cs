namespace Kampovilasttry
{
    partial class FrGuests
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
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.npetermanDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.npeterman_DBDataSet1 = new Kampovilasttry.npeterman_DBDataSet1();
            this.npeterman_DBDataSet3 = new Kampovilasttry.npeterman_DBDataSet3();
            this.npetermanDBDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npetermanDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npeterman_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npeterman_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npetermanDBDataSet3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGuests
            // 
            this.dgvGuests.AllowUserToOrderColumns = true;
            this.dgvGuests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGuests.AutoGenerateColumns = false;
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.DataSource = this.npetermanDBDataSet3BindingSource;
            this.dgvGuests.Location = new System.Drawing.Point(28, 12);
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuests.Size = new System.Drawing.Size(715, 374);
            this.dgvGuests.TabIndex = 0;
            this.dgvGuests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuests1_CellContentClick);
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(561, 392);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(75, 23);
            this.btnRezerviraj.TabIndex = 1;
            this.btnRezerviraj.Text = "Rezervacija";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // npetermanDBDataSet1BindingSource
            // 
            this.npetermanDBDataSet1BindingSource.DataSource = this.npeterman_DBDataSet1;
            this.npetermanDBDataSet1BindingSource.Position = 0;
            // 
            // npeterman_DBDataSet1
            // 
            this.npeterman_DBDataSet1.DataSetName = "npeterman_DBDataSet1";
            this.npeterman_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // npeterman_DBDataSet3
            // 
            this.npeterman_DBDataSet3.DataSetName = "npeterman_DBDataSet3";
            this.npeterman_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // npetermanDBDataSet3BindingSource
            // 
            this.npetermanDBDataSet3BindingSource.DataSource = this.npeterman_DBDataSet3;
            this.npetermanDBDataSet3BindingSource.Position = 0;
            // 
            // FrGuests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.dgvGuests);
            this.Name = "FrGuests";
            this.Text = "FrGuests";
            this.Load += new System.EventHandler(this.FrGuests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npetermanDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npeterman_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npeterman_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npetermanDBDataSet3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.BindingSource npetermanDBDataSet1BindingSource;
        private npeterman_DBDataSet1 npeterman_DBDataSet1;
        private System.Windows.Forms.BindingSource npetermanDBDataSet3BindingSource;
        private npeterman_DBDataSet3 npeterman_DBDataSet3;
    }
}