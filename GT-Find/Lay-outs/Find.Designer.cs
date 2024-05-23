namespace GT_Find.Lay_outs
{
    partial class Find
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Find));
            pictureBox1 = new PictureBox();
            Logo = new PictureBox();
            label1 = new Label();
            profilelbl = new Label();
            findlbl = new Label();
            homelbl = new Label();
            pictureBox2 = new PictureBox();
            flowLayoutPanelProfiles = new FlowLayoutPanel();
            lblUsername = new Label();
            lblBio = new Label();
            lblRegion = new Label();
            lblCountry = new Label();
            lblPlatform = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 286);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 1920);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Logo
            // 
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(10, 15);
            Logo.Margin = new Padding(3, 2, 3, 2);
            Logo.Name = "Logo";
            Logo.Size = new Size(186, 146);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 17;
            Logo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(357, 39);
            label1.Name = "label1";
            label1.Size = new Size(142, 80);
            label1.TabIndex = 18;
            label1.Text = "Find";
            // 
            // profilelbl
            // 
            profilelbl.AutoSize = true;
            profilelbl.Font = new Font("Impact", 14F);
            profilelbl.Location = new Point(1232, 189);
            profilelbl.Name = "profilelbl";
            profilelbl.Size = new Size(63, 23);
            profilelbl.TabIndex = 26;
            profilelbl.Text = "Profile";
            profilelbl.Click += gotoprofilepage;
            // 
            // findlbl
            // 
            findlbl.AutoSize = true;
            findlbl.Font = new Font("Impact", 14F);
            findlbl.Location = new Point(1231, 148);
            findlbl.Name = "findlbl";
            findlbl.Size = new Size(43, 23);
            findlbl.TabIndex = 25;
            findlbl.Text = "Find";
            // 
            // homelbl
            // 
            homelbl.AutoSize = true;
            homelbl.Font = new Font("Impact", 14F);
            homelbl.Location = new Point(1232, 106);
            homelbl.Name = "homelbl";
            homelbl.Size = new Size(56, 23);
            homelbl.TabIndex = 24;
            homelbl.Text = "Home";
            homelbl.Click += gotohomepage;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1237, 39);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            pictureBox2.Click += openmenu;
            // 
            // flowLayoutPanelProfiles
            // 
            flowLayoutPanelProfiles.BackColor = Color.Transparent;
            flowLayoutPanelProfiles.Location = new Point(12, 166);
            flowLayoutPanelProfiles.Name = "flowLayoutPanelProfiles";
            flowLayoutPanelProfiles.Size = new Size(453, 518);
            flowLayoutPanelProfiles.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblUsername.Location = new Point(3, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 22);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblBio
            // 
            lblBio.AutoSize = true;
            lblBio.Location = new Point(3, 30);
            lblBio.Name = "lblBio";
            lblBio.Size = new Size(25, 15);
            lblBio.TabIndex = 1;
            lblBio.Text = "Bio";
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Location = new Point(3, 55);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(45, 15);
            lblRegion.TabIndex = 2;
            lblRegion.Text = "Region";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(3, 80);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(50, 15);
            lblCountry.TabIndex = 3;
            lblCountry.Text = "Country";
            // 
            // lblPlatform
            // 
            lblPlatform.AutoSize = true;
            lblPlatform.Location = new Point(3, 105);
            lblPlatform.Name = "lblPlatform";
            lblPlatform.Size = new Size(54, 15);
            lblPlatform.TabIndex = 4;
            lblPlatform.Text = "Platform";
            // 
            // Find
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1340, 696);
            Controls.Add(flowLayoutPanelProfiles);
            Controls.Add(profilelbl);
            Controls.Add(findlbl);
            Controls.Add(homelbl);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(Logo);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Find";
            Text = "Form1";
            Load += Find_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox Logo;
        private Label label1;
        private Label profilelbl;
        private Label findlbl;
        private Label homelbl;
        private PictureBox pictureBox2;
        private Label lblUsername;
        private Label lblBio;
        private Label lblRegion;
        private Label lblCountry;
        private Label lblPlatform;
        private FlowLayoutPanel flowLayoutPanelProfiles;
    }
}