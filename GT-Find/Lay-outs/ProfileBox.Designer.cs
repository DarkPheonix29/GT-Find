namespace GT_Find
{
    partial class ProfileBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private Label lblUsername;
        private Label lblBio;
        private Label lblRegion;
        private Label lblCountry;
        private Label lblPlatform;

        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblBio = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPlatform = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(3, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 22);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblBio
            // 
            this.lblBio.AutoSize = true;
            this.lblBio.Location = new System.Drawing.Point(3, 30);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(25, 15);
            this.lblBio.TabIndex = 1;
            this.lblBio.Text = "Bio";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(3, 55);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(45, 15);
            this.lblRegion.TabIndex = 2;
            this.lblRegion.Text = "Region";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(3, 80);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(50, 15);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Country";
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Location = new System.Drawing.Point(3, 105);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(54, 15);
            this.lblPlatform.TabIndex = 4;
            this.lblPlatform.Text = "Platform";
            // 
            // ProfileBox
            // 
            this.Controls.Add(this.lblPlatform);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.lblUsername);
            this.Name = "ProfileBox";
            this.Size = new System.Drawing.Size(200, 130);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}