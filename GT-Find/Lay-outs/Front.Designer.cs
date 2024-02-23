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
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(12, 12);
            Logo.Name = "Logo";
            Logo.Size = new Size(102, 95);
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
            Log_in.Location = new Point(682, 12);
            Log_in.Name = "Log_in";
            Log_in.Size = new Size(106, 49);
            Log_in.TabIndex = 1;
            Log_in.Text = "Log in";
            Log_in.UseVisualStyleBackColor = false;
            // 
            // Sign_up
            // 
            Sign_up.BackColor = Color.Transparent;
            Sign_up.FlatAppearance.BorderColor = Color.DarkOrange;
            Sign_up.FlatAppearance.BorderSize = 5;
            Sign_up.FlatStyle = FlatStyle.Flat;
            Sign_up.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Sign_up.ForeColor = Color.DarkOrange;
            Sign_up.Location = new Point(557, 12);
            Sign_up.Name = "Sign_up";
            Sign_up.Size = new Size(106, 49);
            Sign_up.TabIndex = 2;
            Sign_up.Text = "Sign up";
            Sign_up.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(139, 20);
            label1.Name = "label1";
            label1.Size = new Size(318, 75);
            label1.TabIndex = 4;
            label1.Text = "Find To Play";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(37, 165);
            label2.Name = "label2";
            label2.Size = new Size(626, 28);
            label2.TabIndex = 5;
            label2.Text = "Look for team mates for any kind of game, never play alone again!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 232);
            label3.Name = "label3";
            label3.Size = new Size(447, 80);
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
            // Front
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1532, 931);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Sign_up);
            Controls.Add(Log_in);
            Controls.Add(Logo);
            Name = "Front";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
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
    }
}
