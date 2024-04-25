namespace GT_Find
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            Logo = new PictureBox();
            label1 = new Label();
            userlogtext = new TextBox();
            passlogtxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            loginbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
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
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Logo
            // 
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(12, 20);
            Logo.Name = "Logo";
            Logo.Size = new Size(212, 194);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 10;
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
            label1.Size = new Size(233, 98);
            label1.TabIndex = 11;
            label1.Text = "Log In";
            // 
            // userlogtext
            // 
            userlogtext.BorderStyle = BorderStyle.FixedSingle;
            userlogtext.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userlogtext.ForeColor = SystemColors.WindowText;
            userlogtext.Location = new Point(600, 409);
            userlogtext.Name = "userlogtext";
            userlogtext.Size = new Size(362, 43);
            userlogtext.TabIndex = 12;
            userlogtext.TextChanged += emailtext_TextChanged;
            // 
            // passlogtxt
            // 
            passlogtxt.BorderStyle = BorderStyle.FixedSingle;
            passlogtxt.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passlogtxt.ForeColor = SystemColors.WindowText;
            passlogtxt.Location = new Point(600, 551);
            passlogtxt.Name = "passlogtxt";
            passlogtxt.Size = new Size(362, 43);
            passlogtxt.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(600, 344);
            label2.Name = "label2";
            label2.Size = new Size(132, 35);
            label2.TabIndex = 14;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(600, 485);
            label3.Name = "label3";
            label3.Size = new Size(127, 35);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.DarkOrange;
            loginbtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginbtn.ForeColor = Color.White;
            loginbtn.Location = new Point(701, 641);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(145, 46);
            loginbtn.TabIndex = 16;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += gotohomepage;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1532, 928);
            Controls.Add(loginbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passlogtxt);
            Controls.Add(userlogtext);
            Controls.Add(label1);
            Controls.Add(Logo);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox Logo;
        private Label label1;
        private TextBox userlogtext;
        private TextBox passlogtxt;
        private Label label2;
        private Label label3;
        private Button loginbtn;
    }
}