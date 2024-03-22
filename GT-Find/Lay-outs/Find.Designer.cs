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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 382);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 1920);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Logo
            // 
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(12, 20);
            Logo.Name = "Logo";
            Logo.Size = new Size(212, 194);
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
            label1.Location = new Point(408, 52);
            label1.Name = "label1";
            label1.Size = new Size(180, 98);
            label1.TabIndex = 18;
            label1.Text = "Find";
            // 
            // profilelbl
            // 
            profilelbl.AutoSize = true;
            profilelbl.Font = new Font("Impact", 14F);
            profilelbl.Location = new Point(1408, 252);
            profilelbl.Name = "profilelbl";
            profilelbl.Size = new Size(77, 29);
            profilelbl.TabIndex = 26;
            profilelbl.Text = "Profile";
            profilelbl.Click += gotoprofilepage;
            // 
            // findlbl
            // 
            findlbl.AutoSize = true;
            findlbl.Font = new Font("Impact", 14F);
            findlbl.Location = new Point(1407, 197);
            findlbl.Name = "findlbl";
            findlbl.Size = new Size(54, 29);
            findlbl.TabIndex = 25;
            findlbl.Text = "Find";
            // 
            // homelbl
            // 
            homelbl.AutoSize = true;
            homelbl.Font = new Font("Impact", 14F);
            homelbl.Location = new Point(1408, 142);
            homelbl.Name = "homelbl";
            homelbl.Size = new Size(69, 29);
            homelbl.TabIndex = 24;
            homelbl.Text = "Home";
            homelbl.Click += gotohomepage;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1414, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            pictureBox2.Click += openmenu;
            // 
            // Find
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1532, 928);
            Controls.Add(profilelbl);
            Controls.Add(findlbl);
            Controls.Add(homelbl);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(Logo);
            Controls.Add(pictureBox1);
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
    }
}