namespace HairBeautyNWRC
{
    partial class frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.pnl_Home = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_Side = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.PictureBox();
            this.btnUsers = new System.Windows.Forms.PictureBox();
            this.btnClients = new System.Windows.Forms.PictureBox();
            this.btnStock = new System.Windows.Forms.PictureBox();
            this.btnSales = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnSch = new System.Windows.Forms.PictureBox();
            this.btn_Test = new System.Windows.Forms.Button();
            this.Cal_Month = new System.Windows.Forms.MonthCalendar();
            this.pnl_TopSeperation = new System.Windows.Forms.Panel();
            this.pnl_SideSeperation = new System.Windows.Forms.Panel();
            this.nWRC_HairBeautyDataSet = new HairBeautyNWRC.NWRC_HairBeautyDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new HairBeautyNWRC.NWRC_HairBeautyDataSetTableAdapters.ClientTableAdapter();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_SalonSelection = new System.Windows.Forms.Label();
            this.lbl_SalonNoSelection = new System.Windows.Forms.Label();
            this.rb_Salon4 = new System.Windows.Forms.RadioButton();
            this.rb_Salon3 = new System.Windows.Forms.RadioButton();
            this.rb_Salon2 = new System.Windows.Forms.RadioButton();
            this.rb_Salon1 = new System.Windows.Forms.RadioButton();
            this.cb_Salon = new System.Windows.Forms.ComboBox();
            this.lbl_DayDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_hb = new System.Windows.Forms.PictureBox();
            this.pb_NwrcLogo = new System.Windows.Forms.PictureBox();
            this.pnl_Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWRC_HairBeautyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NwrcLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Home
            // 
            this.pnl_Home.BackColor = System.Drawing.Color.Maroon;
            this.pnl_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_Home.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Home.Controls.Add(this.pictureBox1);
            this.pnl_Home.Location = new System.Drawing.Point(214, 180);
            this.pnl_Home.Name = "pnl_Home";
            this.pnl_Home.Size = new System.Drawing.Size(961, 405);
            this.pnl_Home.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(957, 401);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_Side
            // 
            this.pnl_Side.BackColor = System.Drawing.Color.White;
            this.pnl_Side.Controls.Add(this.btnReports);
            this.pnl_Side.Controls.Add(this.btnUsers);
            this.pnl_Side.Controls.Add(this.btnClients);
            this.pnl_Side.Controls.Add(this.btnStock);
            this.pnl_Side.Controls.Add(this.btnSales);
            this.pnl_Side.Controls.Add(this.btnHome);
            this.pnl_Side.Controls.Add(this.btnSch);
            this.pnl_Side.Controls.Add(this.btn_Test);
            this.pnl_Side.Controls.Add(this.Cal_Month);
            this.pnl_Side.Location = new System.Drawing.Point(5, 131);
            this.pnl_Side.Name = "pnl_Side";
            this.pnl_Side.Size = new System.Drawing.Size(229, 707);
            this.pnl_Side.TabIndex = 2;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.BackgroundImage = global::HairBeautyNWRC.Properties.Resources.Round_Button_reportup;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReports.Location = new System.Drawing.Point(48, 466);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(119, 109);
            this.btnReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReports.TabIndex = 17;
            this.btnReports.TabStop = false;
            this.btnReports.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseDown);
            this.btnReports.MouseLeave += new System.EventHandler(this.customBtn_MouseLeave);
            this.btnReports.MouseMove += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseMove);
            this.btnReports.MouseUp += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseUp);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.BackgroundImage = global::HairBeautyNWRC.Properties.Resources.Round_Button_userup;
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsers.Location = new System.Drawing.Point(110, 351);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(119, 109);
            this.btnUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUsers.TabIndex = 16;
            this.btnUsers.TabStop = false;
            this.btnUsers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseDown);
            this.btnUsers.MouseLeave += new System.EventHandler(this.customBtn_MouseLeave);
            this.btnUsers.MouseMove += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseMove);
            this.btnUsers.MouseUp += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseUp);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.Transparent;
            this.btnClients.BackgroundImage = global::HairBeautyNWRC.Properties.Resources.Round_Button_clientsup;
            this.btnClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClients.Location = new System.Drawing.Point(0, 351);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(119, 109);
            this.btnClients.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClients.TabIndex = 15;
            this.btnClients.TabStop = false;
            this.btnClients.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseDown);
            this.btnClients.MouseLeave += new System.EventHandler(this.customBtn_MouseLeave);
            this.btnClients.MouseMove += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseMove);
            this.btnClients.MouseUp += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseUp);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.Transparent;
            this.btnStock.BackgroundImage = global::HairBeautyNWRC.Properties.Resources.Round_Button_stockup;
            this.btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStock.Location = new System.Drawing.Point(110, 276);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(119, 109);
            this.btnStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStock.TabIndex = 14;
            this.btnStock.TabStop = false;
            this.btnStock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseDown);
            this.btnStock.MouseLeave += new System.EventHandler(this.customBtn_MouseLeave);
            this.btnStock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseMove);
            this.btnStock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseUp);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.Transparent;
            this.btnSales.BackgroundImage = global::HairBeautyNWRC.Properties.Resources.Round_Button_salesup;
            this.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSales.Location = new System.Drawing.Point(7, 276);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(119, 109);
            this.btnSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSales.TabIndex = 13;
            this.btnSales.TabStop = false;
            this.btnSales.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseDown);
            this.btnSales.MouseLeave += new System.EventHandler(this.customBtn_MouseLeave);
            this.btnSales.MouseMove += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseMove);
            this.btnSales.MouseUp += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseUp);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::HairBeautyNWRC.Properties.Resources.ButtonUp;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Image = global::HairBeautyNWRC.Properties.Resources.Round_Buttonh_bUp;
            this.btnHome.Location = new System.Drawing.Point(0, 161);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(119, 109);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 12;
            this.btnHome.TabStop = false;
            this.btnHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseDown);
            this.btnHome.MouseLeave += new System.EventHandler(this.customBtn_MouseLeave);
            this.btnHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseMove);
            this.btnHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseUp);
            // 
            // btnSch
            // 
            this.btnSch.BackColor = System.Drawing.Color.Transparent;
            this.btnSch.BackgroundImage = global::HairBeautyNWRC.Properties.Resources.Round_Button_calup;
            this.btnSch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSch.Location = new System.Drawing.Point(110, 161);
            this.btnSch.Name = "btnSch";
            this.btnSch.Size = new System.Drawing.Size(119, 109);
            this.btnSch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSch.TabIndex = 11;
            this.btnSch.TabStop = false;
            this.btnSch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseDown);
            this.btnSch.MouseLeave += new System.EventHandler(this.customBtn_MouseLeave);
            this.btnSch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseMove);
            this.btnSch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.customBtn_MouseUp);
            // 
            // btn_Test
            // 
            this.btn_Test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Test.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Test.Location = new System.Drawing.Point(48, 624);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(166, 86);
            this.btn_Test.TabIndex = 9;
            this.btn_Test.Text = "Test";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // Cal_Month
            // 
            this.Cal_Month.BackColor = System.Drawing.Color.White;
            this.Cal_Month.CausesValidation = false;
            this.Cal_Month.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cal_Month.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Cal_Month.Location = new System.Drawing.Point(0, 0);
            this.Cal_Month.Name = "Cal_Month";
            this.Cal_Month.TabIndex = 3;
            this.Cal_Month.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Cal_Month_DateSelected);
            // 
            // pnl_TopSeperation
            // 
            this.pnl_TopSeperation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnl_TopSeperation.Location = new System.Drawing.Point(263, 131);
            this.pnl_TopSeperation.Name = "pnl_TopSeperation";
            this.pnl_TopSeperation.Size = new System.Drawing.Size(200, 43);
            this.pnl_TopSeperation.TabIndex = 3;
            // 
            // pnl_SideSeperation
            // 
            this.pnl_SideSeperation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnl_SideSeperation.Location = new System.Drawing.Point(510, 142);
            this.pnl_SideSeperation.Name = "pnl_SideSeperation";
            this.pnl_SideSeperation.Size = new System.Drawing.Size(200, 32);
            this.pnl_SideSeperation.TabIndex = 4;
            // 
            // nWRC_HairBeautyDataSet
            // 
            this.nWRC_HairBeautyDataSet.DataSetName = "NWRC_HairBeautyDataSet";
            this.nWRC_HairBeautyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.nWRC_HairBeautyDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.White;
            this.pnl_top.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_top.BackgroundImage")));
            this.pnl_top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_top.Controls.Add(this.lbl_SalonSelection);
            this.pnl_top.Controls.Add(this.lbl_SalonNoSelection);
            this.pnl_top.Controls.Add(this.rb_Salon4);
            this.pnl_top.Controls.Add(this.rb_Salon3);
            this.pnl_top.Controls.Add(this.rb_Salon2);
            this.pnl_top.Controls.Add(this.rb_Salon1);
            this.pnl_top.Controls.Add(this.cb_Salon);
            this.pnl_top.Controls.Add(this.lbl_DayDate);
            this.pnl_top.Controls.Add(this.panel1);
            this.pnl_top.Controls.Add(this.pb_hb);
            this.pnl_top.Controls.Add(this.pb_NwrcLogo);
            this.pnl_top.Location = new System.Drawing.Point(2, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(971, 125);
            this.pnl_top.TabIndex = 0;
            // 
            // lbl_SalonSelection
            // 
            this.lbl_SalonSelection.AutoSize = true;
            this.lbl_SalonSelection.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SalonSelection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_SalonSelection.Font = new System.Drawing.Font("Nueva Std", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalonSelection.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_SalonSelection.Location = new System.Drawing.Point(471, 65);
            this.lbl_SalonSelection.Name = "lbl_SalonSelection";
            this.lbl_SalonSelection.Size = new System.Drawing.Size(145, 43);
            this.lbl_SalonSelection.TabIndex = 11;
            this.lbl_SalonSelection.Text = "Beauty";
            // 
            // lbl_SalonNoSelection
            // 
            this.lbl_SalonNoSelection.AutoSize = true;
            this.lbl_SalonNoSelection.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SalonNoSelection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_SalonNoSelection.Font = new System.Drawing.Font("Nueva Std", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalonNoSelection.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_SalonNoSelection.Location = new System.Drawing.Point(422, 65);
            this.lbl_SalonNoSelection.Name = "lbl_SalonNoSelection";
            this.lbl_SalonNoSelection.Size = new System.Drawing.Size(141, 43);
            this.lbl_SalonNoSelection.TabIndex = 10;
            this.lbl_SalonNoSelection.Text = "Salon 1";
            // 
            // rb_Salon4
            // 
            this.rb_Salon4.AutoSize = true;
            this.rb_Salon4.Location = new System.Drawing.Point(178, 104);
            this.rb_Salon4.Name = "rb_Salon4";
            this.rb_Salon4.Size = new System.Drawing.Size(61, 17);
            this.rb_Salon4.TabIndex = 8;
            this.rb_Salon4.Text = "Salon 4";
            this.rb_Salon4.UseVisualStyleBackColor = true;
            this.rb_Salon4.CheckedChanged += new System.EventHandler(this.rb_Salon_CheckedChanged);
            // 
            // rb_Salon3
            // 
            this.rb_Salon3.AutoSize = true;
            this.rb_Salon3.Location = new System.Drawing.Point(178, 82);
            this.rb_Salon3.Name = "rb_Salon3";
            this.rb_Salon3.Size = new System.Drawing.Size(61, 17);
            this.rb_Salon3.TabIndex = 7;
            this.rb_Salon3.Text = "Salon 3";
            this.rb_Salon3.UseVisualStyleBackColor = true;
            this.rb_Salon3.CheckedChanged += new System.EventHandler(this.rb_Salon_CheckedChanged);
            // 
            // rb_Salon2
            // 
            this.rb_Salon2.AutoSize = true;
            this.rb_Salon2.Location = new System.Drawing.Point(178, 60);
            this.rb_Salon2.Name = "rb_Salon2";
            this.rb_Salon2.Size = new System.Drawing.Size(61, 17);
            this.rb_Salon2.TabIndex = 6;
            this.rb_Salon2.Text = "Salon 2";
            this.rb_Salon2.UseVisualStyleBackColor = true;
            this.rb_Salon2.CheckedChanged += new System.EventHandler(this.rb_Salon_CheckedChanged);
            // 
            // rb_Salon1
            // 
            this.rb_Salon1.AutoSize = true;
            this.rb_Salon1.Checked = true;
            this.rb_Salon1.Location = new System.Drawing.Point(178, 39);
            this.rb_Salon1.Name = "rb_Salon1";
            this.rb_Salon1.Size = new System.Drawing.Size(61, 17);
            this.rb_Salon1.TabIndex = 5;
            this.rb_Salon1.TabStop = true;
            this.rb_Salon1.Text = "Salon 1";
            this.rb_Salon1.UseVisualStyleBackColor = true;
            this.rb_Salon1.CheckedChanged += new System.EventHandler(this.rb_Salon_CheckedChanged);
            // 
            // cb_Salon
            // 
            this.cb_Salon.FormattingEnabled = true;
            this.cb_Salon.Items.AddRange(new object[] {
            "Hair",
            "Beauty"});
            this.cb_Salon.Location = new System.Drawing.Point(178, 9);
            this.cb_Salon.Name = "cb_Salon";
            this.cb_Salon.Size = new System.Drawing.Size(121, 21);
            this.cb_Salon.TabIndex = 4;
            this.cb_Salon.SelectedIndexChanged += new System.EventHandler(this.cb_Salon_SelectedIndexChanged);
            // 
            // lbl_DayDate
            // 
            this.lbl_DayDate.AutoSize = true;
            this.lbl_DayDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DayDate.Font = new System.Drawing.Font("Monotype Corsiva", 35F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DayDate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_DayDate.Location = new System.Drawing.Point(193, 9);
            this.lbl_DayDate.Name = "lbl_DayDate";
            this.lbl_DayDate.Size = new System.Drawing.Size(537, 56);
            this.lbl_DayDate.TabIndex = 3;
            this.lbl_DayDate.Text = "Day and Date will appear here";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 499);
            this.panel1.TabIndex = 2;
            // 
            // pb_hb
            // 
            this.pb_hb.BackColor = System.Drawing.Color.Transparent;
            this.pb_hb.Image = ((System.Drawing.Image)(resources.GetObject("pb_hb.Image")));
            this.pb_hb.Location = new System.Drawing.Point(10, 3);
            this.pb_hb.Name = "pb_hb";
            this.pb_hb.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.pb_hb.Size = new System.Drawing.Size(162, 119);
            this.pb_hb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_hb.TabIndex = 1;
            this.pb_hb.TabStop = false;
            // 
            // pb_NwrcLogo
            // 
            this.pb_NwrcLogo.BackColor = System.Drawing.Color.Transparent;
            this.pb_NwrcLogo.Image = ((System.Drawing.Image)(resources.GetObject("pb_NwrcLogo.Image")));
            this.pb_NwrcLogo.Location = new System.Drawing.Point(616, -23);
            this.pb_NwrcLogo.Name = "pb_NwrcLogo";
            this.pb_NwrcLogo.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.pb_NwrcLogo.Size = new System.Drawing.Size(220, 148);
            this.pb_NwrcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_NwrcLogo.TabIndex = 0;
            this.pb_NwrcLogo.TabStop = false;
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pnl_SideSeperation);
            this.Controls.Add(this.pnl_TopSeperation);
            this.Controls.Add(this.pnl_Side);
            this.Controls.Add(this.pnl_Home);
            this.Controls.Add(this.pnl_top);
            this.Name = "frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.pnl_Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Side.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWRC_HairBeautyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NwrcLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.PictureBox pb_NwrcLogo;
        private System.Windows.Forms.PictureBox pb_hb;
        private System.Windows.Forms.Panel pnl_Home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Side;
        private System.Windows.Forms.Panel pnl_TopSeperation;
        private System.Windows.Forms.Panel pnl_SideSeperation;
        private System.Windows.Forms.MonthCalendar Cal_Month;
        private System.Windows.Forms.PictureBox pictureBox1;
        private NWRC_HairBeautyDataSet nWRC_HairBeautyDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private NWRC_HairBeautyDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Label lbl_DayDate;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.PictureBox btnSch;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox btnReports;
        private System.Windows.Forms.PictureBox btnUsers;
        private System.Windows.Forms.PictureBox btnClients;
        private System.Windows.Forms.PictureBox btnStock;
        private System.Windows.Forms.PictureBox btnSales;
        private System.Windows.Forms.RadioButton rb_Salon4;
        private System.Windows.Forms.RadioButton rb_Salon3;
        private System.Windows.Forms.RadioButton rb_Salon2;
        private System.Windows.Forms.RadioButton rb_Salon1;
        private System.Windows.Forms.ComboBox cb_Salon;
        private System.Windows.Forms.Label lbl_SalonNoSelection;
        public System.Windows.Forms.Label lbl_SalonSelection;
    }
}