namespace GT_Find
{
    partial class Front
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Front));
            Logo = new PictureBox();
            Log_in = new Button();
            Sign_up = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(12, 20);
            Logo.Name = "Logo";
            Logo.Size = new Size(212, 194);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // Log_in
            // 
            Log_in.BackColor = Color.Transparent;
            Log_in.FlatAppearance.BorderColor = Color.DarkOrange;
            Log_in.FlatAppearance.BorderSize = 5;
            Log_in.FlatStyle = FlatStyle.Flat;
            Log_in.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Log_in.ForeColor = Color.DarkOrange;
            Log_in.Location = new Point(1384, 20);
            Log_in.Name = "Log_in";
            Log_in.Size = new Size(135, 55);
            Log_in.TabIndex = 1;
            Log_in.Text = "Log in";
            Log_in.UseVisualStyleBackColor = false;
            Log_in.Click += gotologinpage;
            // 
            // Sign_up
            // 
            Sign_up.BackColor = Color.Transparent;
            Sign_up.FlatAppearance.BorderColor = Color.DarkOrange;
            Sign_up.FlatAppearance.BorderSize = 5;
            Sign_up.FlatStyle = FlatStyle.Flat;
            Sign_up.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Sign_up.ForeColor = Color.DarkOrange;
            Sign_up.Location = new Point(1210, 20);
            Sign_up.Name = "Sign_up";
            Sign_up.Size = new Size(135, 55);
            Sign_up.TabIndex = 2;
            Sign_up.Text = "Sign up";
            Sign_up.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(408, 52);
            label1.Name = "label1";
            label1.Size = new Size(424, 98);
            label1.TabIndex = 4;
            label1.Text = "Find To Play";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(37, 292);
            label2.Name = "label2";
            label2.Size = new Size(1187, 54);
            label2.TabIndex = 5;
            label2.Text = "Look for team mates for any kind of game, never play alone again!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 361);
            label3.Name = "label3";
            label3.Size = new Size(690, 124);
            label3.TabIndex = 6;
            label3.Text = "Create a profile and start searching for team mates. \r\nChoose your games and prefences and make friends.\r\nOur algoritme makes sure you match with the best people for you!\r\n\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(517, 485);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 382);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 1920);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1210, 292);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Front
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1532, 928);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Sign_up);
            Controls.Add(Log_in);
            Controls.Add(Logo);
            Controls.Add(pictureBox1);
            Name = "Front";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private Button Log_in;
        private Button Sign_up;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
