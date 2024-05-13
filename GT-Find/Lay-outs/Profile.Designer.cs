namespace GT_Find.Lay_outs
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            Logo = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            profilelbl = new Label();
            findlbl = new Label();
            homelbl = new Label();
            pictureBox2 = new PictureBox();
            boitext = new TextBox();
            regiontxt = new TextBox();
            countrytxt = new TextBox();
            platformtxt = new TextBox();
            fun4 = new CheckBox();
            fun2 = new CheckBox();
            fun3 = new CheckBox();
            fun1 = new CheckBox();
            fun5 = new CheckBox();
            cop5 = new CheckBox();
            cop1 = new CheckBox();
            cop3 = new CheckBox();
            cop2 = new CheckBox();
            cop4 = new CheckBox();
            srs5 = new CheckBox();
            srs1 = new CheckBox();
            srs3 = new CheckBox();
            srs2 = new CheckBox();
            srs4 = new CheckBox();
            com5 = new CheckBox();
            com1 = new CheckBox();
            com3 = new CheckBox();
            com2 = new CheckBox();
            com4 = new CheckBox();
            ded5 = new CheckBox();
            ded1 = new CheckBox();
            ded3 = new CheckBox();
            ded2 = new CheckBox();
            ded4 = new CheckBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            saveprofilebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(10, 15);
            Logo.Margin = new Padding(3, 2, 3, 2);
            Logo.Name = "Logo";
            Logo.Size = new Size(186, 146);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 13;
            Logo.TabStop = false;
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
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(357, 39);
            label1.Name = "label1";
            label1.Size = new Size(208, 80);
            label1.TabIndex = 16;
            label1.Text = "Profile";
            // 
            // profilelbl
            // 
            profilelbl.AutoSize = true;
            profilelbl.Font = new Font("Impact", 14F);
            profilelbl.Location = new Point(1228, 189);
            profilelbl.Name = "profilelbl";
            profilelbl.Size = new Size(63, 23);
            profilelbl.TabIndex = 22;
            profilelbl.Text = "Profile";
            // 
            // findlbl
            // 
            findlbl.AutoSize = true;
            findlbl.Font = new Font("Impact", 14F);
            findlbl.Location = new Point(1228, 148);
            findlbl.Name = "findlbl";
            findlbl.Size = new Size(43, 23);
            findlbl.TabIndex = 21;
            findlbl.Text = "Find";
            findlbl.Click += gotofindpage;
            // 
            // homelbl
            // 
            homelbl.AutoSize = true;
            homelbl.Font = new Font("Impact", 14F);
            homelbl.Location = new Point(1228, 106);
            homelbl.Name = "homelbl";
            homelbl.Size = new Size(56, 23);
            homelbl.TabIndex = 20;
            homelbl.Text = "Home";
            homelbl.Click += gotohomepage;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1234, 39);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Click += openmenu;
            // 
            // boitext
            // 
            boitext.BorderStyle = BorderStyle.FixedSingle;
            boitext.Location = new Point(10, 266);
            boitext.Margin = new Padding(3, 2, 3, 2);
            boitext.Multiline = true;
            boitext.Name = "boitext";
            boitext.Size = new Size(628, 94);
            boitext.TabIndex = 23;
            // 
            // regiontxt
            // 
            regiontxt.AutoCompleteCustomSource.AddRange(new string[] { "Africa", "Asia", "Central America", "Europe", "Middle East", "North America.", "Pacific", "South America" });
            regiontxt.AutoCompleteMode = AutoCompleteMode.Suggest;
            regiontxt.Location = new Point(10, 431);
            regiontxt.Margin = new Padding(3, 2, 3, 2);
            regiontxt.Name = "regiontxt";
            regiontxt.Size = new Size(151, 23);
            regiontxt.TabIndex = 26;
            // 
            // countrytxt
            // 
            countrytxt.AutoCompleteCustomSource.AddRange(new string[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Austrian Empire*", "Azerbaijan", "Baden*", "Bahamas, The", "Bahrain", "Bangladesh", "Barbados", "Bavaria*", "Belarus", "Belgium", "Belize", "Benin (Dahomey)", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Brunswick and Lüneburg*", "Bulgaria", "Burkina Faso (Upper Volta)", "Burma", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Cayman Islands, The", "Central African Republic", "Central American Federation*", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo Free State, The*", "Costa Rica", "Cote d’Ivoire (Ivory Coast)", "Croatia", "Cuba", "Cyprus", "Czechia", "Czechoslovakia*", "Democratic Republic of the Congo", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Duchy of Parma, The*", "East Germany (German Democratic Republic)*", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Federal Government of Germany (1848-49)*", "Fiji", "Finland", "France", "Gabon", "Gambia, The", "Georgia", "Germany", "Ghana", "Grand Duchy of Tuscany, The*", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Hanover*", "Hanseatic Republics*", "Hawaii*", "Hesse*", "Holy See", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kingdom of Serbia/Yugoslavia*", "Kiribati", "Korea", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Lew Chew (Loochoo)*", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mecklenburg-Schwerin*", "Mecklenburg-Strelitz*", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Namibia", "Nassau*", "Nauru", "Nepal", "Netherlands, The", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North German Confederation*", "North German Union*", "North Macedonia", "Norway", "Oldenburg*", "Oman", "Orange Free State*", "Pakistan", "Palau", "Panama", "Papal States*", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Piedmont-Sardinia*", "Poland", "Portugal", "Qatar", "Republic of Genoa*", "Republic of Korea (South Korea)", "Republic of the Congo", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Schaumburg-Lippe*", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands, The", "Somalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Tajikistan", "Tanzania", "Texas*", "Thailand", "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Two Sicilies*", "Uganda", "Ukraine", "Union of Soviet Socialist Republics*", "United Arab Emirates, The", "United Kingdom, The", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Württemberg*", "Yemen", "ZZambia", "Zimbabwe" });
            countrytxt.AutoCompleteMode = AutoCompleteMode.Suggest;
            countrytxt.Location = new Point(10, 497);
            countrytxt.Margin = new Padding(3, 2, 3, 2);
            countrytxt.Name = "countrytxt";
            countrytxt.Size = new Size(151, 23);
            countrytxt.TabIndex = 27;
            // 
            // platformtxt
            // 
            platformtxt.AutoCompleteCustomSource.AddRange(new string[] { "PC", "PlayStation 5", "Nintendo Switch", "Xbox Series X", "Mobile" });
            platformtxt.AutoCompleteMode = AutoCompleteMode.Suggest;
            platformtxt.Location = new Point(10, 565);
            platformtxt.Margin = new Padding(3, 2, 3, 2);
            platformtxt.Name = "platformtxt";
            platformtxt.Size = new Size(151, 23);
            platformtxt.TabIndex = 28;
            // 
            // fun4
            // 
            fun4.AutoSize = true;
            fun4.Location = new Point(1255, 338);
            fun4.Margin = new Padding(3, 2, 3, 2);
            fun4.Name = "fun4";
            fun4.Size = new Size(32, 19);
            fun4.TabIndex = 29;
            fun4.Tag = "fun";
            fun4.Text = "4";
            fun4.UseVisualStyleBackColor = true;
            // 
            // fun2
            // 
            fun2.AutoSize = true;
            fun2.Location = new Point(1176, 338);
            fun2.Margin = new Padding(3, 2, 3, 2);
            fun2.Name = "fun2";
            fun2.Size = new Size(32, 19);
            fun2.TabIndex = 30;
            fun2.Tag = "fun";
            fun2.Text = "2";
            fun2.UseVisualStyleBackColor = true;
            // 
            // fun3
            // 
            fun3.AutoSize = true;
            fun3.Location = new Point(1215, 338);
            fun3.Margin = new Padding(3, 2, 3, 2);
            fun3.Name = "fun3";
            fun3.Size = new Size(32, 19);
            fun3.TabIndex = 31;
            fun3.Tag = "fun";
            fun3.Text = "3";
            fun3.UseVisualStyleBackColor = true;
            // 
            // fun1
            // 
            fun1.AutoSize = true;
            fun1.Location = new Point(1137, 338);
            fun1.Margin = new Padding(3, 2, 3, 2);
            fun1.Name = "fun1";
            fun1.Size = new Size(32, 19);
            fun1.TabIndex = 32;
            fun1.Tag = "fun";
            fun1.Text = "1";
            fun1.UseVisualStyleBackColor = true;
            // 
            // fun5
            // 
            fun5.AutoSize = true;
            fun5.Location = new Point(1294, 338);
            fun5.Margin = new Padding(3, 2, 3, 2);
            fun5.Name = "fun5";
            fun5.Size = new Size(32, 19);
            fun5.TabIndex = 33;
            fun5.Tag = "fun";
            fun5.Text = "5";
            fun5.UseVisualStyleBackColor = true;
            // 
            // cop5
            // 
            cop5.AutoSize = true;
            cop5.Location = new Point(1294, 394);
            cop5.Margin = new Padding(3, 2, 3, 2);
            cop5.Name = "cop5";
            cop5.Size = new Size(32, 19);
            cop5.TabIndex = 38;
            cop5.Tag = "cop";
            cop5.Text = "5";
            cop5.UseVisualStyleBackColor = true;
            // 
            // cop1
            // 
            cop1.AutoSize = true;
            cop1.Location = new Point(1137, 394);
            cop1.Margin = new Padding(3, 2, 3, 2);
            cop1.Name = "cop1";
            cop1.Size = new Size(32, 19);
            cop1.TabIndex = 37;
            cop1.Tag = "cop";
            cop1.Text = "1";
            cop1.UseVisualStyleBackColor = true;
            // 
            // cop3
            // 
            cop3.AutoSize = true;
            cop3.Location = new Point(1215, 394);
            cop3.Margin = new Padding(3, 2, 3, 2);
            cop3.Name = "cop3";
            cop3.Size = new Size(32, 19);
            cop3.TabIndex = 36;
            cop3.Tag = "cop";
            cop3.Text = "3";
            cop3.UseVisualStyleBackColor = true;
            // 
            // cop2
            // 
            cop2.AutoSize = true;
            cop2.Location = new Point(1176, 394);
            cop2.Margin = new Padding(3, 2, 3, 2);
            cop2.Name = "cop2";
            cop2.Size = new Size(32, 19);
            cop2.TabIndex = 35;
            cop2.Tag = "cop";
            cop2.Text = "2";
            cop2.UseVisualStyleBackColor = true;
            // 
            // cop4
            // 
            cop4.AutoSize = true;
            cop4.Location = new Point(1255, 394);
            cop4.Margin = new Padding(3, 2, 3, 2);
            cop4.Name = "cop4";
            cop4.Size = new Size(32, 19);
            cop4.TabIndex = 34;
            cop4.Tag = "cop";
            cop4.Text = "4";
            cop4.UseVisualStyleBackColor = true;
            // 
            // srs5
            // 
            srs5.AutoSize = true;
            srs5.Location = new Point(1294, 450);
            srs5.Margin = new Padding(3, 2, 3, 2);
            srs5.Name = "srs5";
            srs5.Size = new Size(32, 19);
            srs5.TabIndex = 43;
            srs5.Tag = "srs";
            srs5.Text = "5";
            srs5.UseVisualStyleBackColor = true;
            // 
            // srs1
            // 
            srs1.AutoSize = true;
            srs1.Location = new Point(1137, 450);
            srs1.Margin = new Padding(3, 2, 3, 2);
            srs1.Name = "srs1";
            srs1.Size = new Size(32, 19);
            srs1.TabIndex = 42;
            srs1.Tag = "srs";
            srs1.Text = "1";
            srs1.UseVisualStyleBackColor = true;
            // 
            // srs3
            // 
            srs3.AutoSize = true;
            srs3.Location = new Point(1215, 450);
            srs3.Margin = new Padding(3, 2, 3, 2);
            srs3.Name = "srs3";
            srs3.Size = new Size(32, 19);
            srs3.TabIndex = 41;
            srs3.Tag = "srs";
            srs3.Text = "3";
            srs3.UseVisualStyleBackColor = true;
            // 
            // srs2
            // 
            srs2.AutoSize = true;
            srs2.Location = new Point(1176, 450);
            srs2.Margin = new Padding(3, 2, 3, 2);
            srs2.Name = "srs2";
            srs2.Size = new Size(32, 19);
            srs2.TabIndex = 40;
            srs2.Tag = "srs";
            srs2.Text = "2";
            srs2.UseVisualStyleBackColor = true;
            // 
            // srs4
            // 
            srs4.AutoSize = true;
            srs4.Location = new Point(1255, 450);
            srs4.Margin = new Padding(3, 2, 3, 2);
            srs4.Name = "srs4";
            srs4.Size = new Size(32, 19);
            srs4.TabIndex = 39;
            srs4.Tag = "srs";
            srs4.Text = "4";
            srs4.UseVisualStyleBackColor = true;
            // 
            // com5
            // 
            com5.AutoSize = true;
            com5.Location = new Point(1294, 506);
            com5.Margin = new Padding(3, 2, 3, 2);
            com5.Name = "com5";
            com5.Size = new Size(32, 19);
            com5.TabIndex = 48;
            com5.Tag = "com";
            com5.Text = "5";
            com5.UseVisualStyleBackColor = true;
            // 
            // com1
            // 
            com1.AutoSize = true;
            com1.Location = new Point(1137, 506);
            com1.Margin = new Padding(3, 2, 3, 2);
            com1.Name = "com1";
            com1.Size = new Size(32, 19);
            com1.TabIndex = 47;
            com1.Tag = "com";
            com1.Text = "1";
            com1.UseVisualStyleBackColor = true;
            // 
            // com3
            // 
            com3.AutoSize = true;
            com3.Location = new Point(1215, 506);
            com3.Margin = new Padding(3, 2, 3, 2);
            com3.Name = "com3";
            com3.Size = new Size(32, 19);
            com3.TabIndex = 46;
            com3.Tag = "com";
            com3.Text = "3";
            com3.UseVisualStyleBackColor = true;
            // 
            // com2
            // 
            com2.AutoSize = true;
            com2.Location = new Point(1176, 506);
            com2.Margin = new Padding(3, 2, 3, 2);
            com2.Name = "com2";
            com2.Size = new Size(32, 19);
            com2.TabIndex = 45;
            com2.Tag = "com";
            com2.Text = "2";
            com2.UseVisualStyleBackColor = true;
            // 
            // com4
            // 
            com4.AutoSize = true;
            com4.Location = new Point(1255, 506);
            com4.Margin = new Padding(3, 2, 3, 2);
            com4.Name = "com4";
            com4.Size = new Size(32, 19);
            com4.TabIndex = 44;
            com4.Tag = "com";
            com4.Text = "4";
            com4.UseVisualStyleBackColor = true;
            // 
            // ded5
            // 
            ded5.AutoSize = true;
            ded5.Location = new Point(1294, 562);
            ded5.Margin = new Padding(3, 2, 3, 2);
            ded5.Name = "ded5";
            ded5.Size = new Size(32, 19);
            ded5.TabIndex = 53;
            ded5.Tag = "ded";
            ded5.Text = "5";
            ded5.UseVisualStyleBackColor = true;
            // 
            // ded1
            // 
            ded1.AutoSize = true;
            ded1.Location = new Point(1137, 562);
            ded1.Margin = new Padding(3, 2, 3, 2);
            ded1.Name = "ded1";
            ded1.Size = new Size(32, 19);
            ded1.TabIndex = 52;
            ded1.Tag = "ded";
            ded1.Text = "1";
            ded1.UseVisualStyleBackColor = true;
            // 
            // ded3
            // 
            ded3.AutoSize = true;
            ded3.Location = new Point(1215, 562);
            ded3.Margin = new Padding(3, 2, 3, 2);
            ded3.Name = "ded3";
            ded3.Size = new Size(32, 19);
            ded3.TabIndex = 51;
            ded3.Tag = "ded";
            ded3.Text = "3";
            ded3.UseVisualStyleBackColor = true;
            // 
            // ded2
            // 
            ded2.AutoSize = true;
            ded2.Location = new Point(1176, 562);
            ded2.Margin = new Padding(3, 2, 3, 2);
            ded2.Name = "ded2";
            ded2.Size = new Size(32, 19);
            ded2.TabIndex = 50;
            ded2.Tag = "ded";
            ded2.Text = "2";
            ded2.UseVisualStyleBackColor = true;
            // 
            // ded4
            // 
            ded4.AutoSize = true;
            ded4.Location = new Point(1255, 562);
            ded4.Margin = new Padding(3, 2, 3, 2);
            ded4.Name = "ded4";
            ded4.Size = new Size(32, 19);
            ded4.TabIndex = 49;
            ded4.Tag = "ded";
            ded4.Text = "4";
            ded4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 12.2F);
            label4.Location = new Point(10, 244);
            label4.Name = "label4";
            label4.Size = new Size(33, 21);
            label4.TabIndex = 54;
            label4.Text = "Bio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12.2F);
            label2.Location = new Point(10, 410);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 55;
            label2.Text = "Region";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 12.2F);
            label3.Location = new Point(10, 476);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 56;
            label3.Text = "Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 12.2F);
            label5.Location = new Point(10, 543);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 57;
            label5.Text = "Platform";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 12.2F);
            label6.Location = new Point(1136, 316);
            label6.Name = "label6";
            label6.Size = new Size(35, 21);
            label6.TabIndex = 58;
            label6.Text = "Fun";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 12.2F);
            label7.Location = new Point(1136, 372);
            label7.Name = "label7";
            label7.Size = new Size(95, 21);
            label7.TabIndex = 59;
            label7.Text = "Competitive";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 12.2F);
            label8.Location = new Point(1136, 428);
            label8.Name = "label8";
            label8.Size = new Size(65, 21);
            label8.TabIndex = 60;
            label8.Text = "Serious";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 12.2F);
            label9.Location = new Point(1136, 484);
            label9.Name = "label9";
            label9.Size = new Size(122, 21);
            label9.TabIndex = 61;
            label9.Text = "Communication";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Impact", 12.2F);
            label10.Location = new Point(1137, 541);
            label10.Name = "label10";
            label10.Size = new Size(87, 21);
            label10.TabIndex = 62;
            label10.Text = "Dedication";
            // 
            // saveprofilebtn
            // 
            saveprofilebtn.BackColor = Color.DarkOrange;
            saveprofilebtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveprofilebtn.ForeColor = Color.White;
            saveprofilebtn.Location = new Point(594, 584);
            saveprofilebtn.Margin = new Padding(3, 2, 3, 2);
            saveprofilebtn.Name = "saveprofilebtn";
            saveprofilebtn.Size = new Size(127, 34);
            saveprofilebtn.TabIndex = 63;
            saveprofilebtn.Text = "Save";
            saveprofilebtn.UseVisualStyleBackColor = false;
            saveprofilebtn.Click += SaveProfileButton_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1340, 696);
            Controls.Add(saveprofilebtn);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(ded5);
            Controls.Add(ded1);
            Controls.Add(ded3);
            Controls.Add(ded2);
            Controls.Add(ded4);
            Controls.Add(com5);
            Controls.Add(com1);
            Controls.Add(com3);
            Controls.Add(com2);
            Controls.Add(com4);
            Controls.Add(srs5);
            Controls.Add(srs1);
            Controls.Add(srs3);
            Controls.Add(srs2);
            Controls.Add(srs4);
            Controls.Add(cop5);
            Controls.Add(cop1);
            Controls.Add(cop3);
            Controls.Add(cop2);
            Controls.Add(cop4);
            Controls.Add(fun5);
            Controls.Add(fun1);
            Controls.Add(fun3);
            Controls.Add(fun2);
            Controls.Add(fun4);
            Controls.Add(platformtxt);
            Controls.Add(countrytxt);
            Controls.Add(regiontxt);
            Controls.Add(boitext);
            Controls.Add(profilelbl);
            Controls.Add(findlbl);
            Controls.Add(homelbl);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(Logo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Profile";
            Text = "Form1";
            Load += Profile_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private PictureBox pictureBox1;
        private Label label1;
        private Label profilelbl;
        private Label findlbl;
        private Label homelbl;
        private PictureBox pictureBox2;
        private TextBox boitext;
        private TextBox platformtxt;
        private TextBox textBox3;
        private TextBox regiontxt;
        private TextBox countrytxt;
        private CheckBox fun4;
        private CheckBox fun2;
        private CheckBox fun3;
        private CheckBox fun1;
        private CheckBox fun5;
        private CheckBox cop5;
        private CheckBox cop1;
        private CheckBox cop3;
        private CheckBox cop2;
        private CheckBox cop4;
        private CheckBox srs5;
        private CheckBox srs1;
        private CheckBox srs3;
        private CheckBox srs2;
        private CheckBox srs4;
        private CheckBox com5;
        private CheckBox com1;
        private CheckBox com3;
        private CheckBox com2;
        private CheckBox com4;
        private CheckBox ded5;
        private CheckBox ded1;
        private CheckBox ded3;
        private CheckBox ded2;
        private CheckBox ded4;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button saveprofilebtn;
    }
}