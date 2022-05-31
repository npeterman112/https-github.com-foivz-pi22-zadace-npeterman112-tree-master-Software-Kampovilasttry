namespace Kampovilasttry
{
    partial class FrMenu
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
            this.btnGuestList = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAccomodationList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuestList
            // 
            this.btnGuestList.Location = new System.Drawing.Point(97, 71);
            this.btnGuestList.Name = "btnGuestList";
            this.btnGuestList.Size = new System.Drawing.Size(129, 33);
            this.btnGuestList.TabIndex = 0;
            this.btnGuestList.Text = "Guests list";
            this.btnGuestList.UseVisualStyleBackColor = true;
            this.btnGuestList.Click += new System.EventHandler(this.btnGuestList_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(97, 232);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(129, 33);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAccomodationList
            // 
            this.btnAccomodationList.Location = new System.Drawing.Point(97, 131);
            this.btnAccomodationList.Name = "btnAccomodationList";
            this.btnAccomodationList.Size = new System.Drawing.Size(129, 33);
            this.btnAccomodationList.TabIndex = 5;
            this.btnAccomodationList.Text = "Accomodations list";
            this.btnAccomodationList.UseVisualStyleBackColor = true;
            this.btnAccomodationList.Click += new System.EventHandler(this.btnAccomodationList_Click);
            // 
            // FrMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 345);
            this.Controls.Add(this.btnAccomodationList);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnGuestList);
            this.Name = "FrMenu";
            this.Text = "FrMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuestList;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAccomodationList;
    }
}