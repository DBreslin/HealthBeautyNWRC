namespace HairBeautyNWRC
{
    partial class uc_Treatments
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Treatments));
            this.tab_Treatments = new System.Windows.Forms.TabControl();
            this.tp_Treatments = new System.Windows.Forms.TabPage();
            this.dgv_Treatments = new System.Windows.Forms.DataGridView();
            this.tp_AddTreat = new System.Windows.Forms.TabPage();
            this.pnl_AddUser = new System.Windows.Forms.Panel();
            this.cb_TreatType = new System.Windows.Forms.ComboBox();
            this.cb_TreatGroup = new System.Windows.Forms.ComboBox();
            this.picTreat = new System.Windows.Forms.PictureBox();
            this.txt_TreatName = new System.Windows.Forms.TextBox();
            this.btn_AddTreat = new System.Windows.Forms.Button();
            this.lbl_TreatNo = new System.Windows.Forms.Label();
            this.lbl_TreatNoText = new System.Windows.Forms.Label();
            this.txt_TreatPrice = new System.Windows.Forms.TextBox();
            this.lbl_TreatName = new System.Windows.Forms.Label();
            this.lbl_TreatType = new System.Windows.Forms.Label();
            this.lbl_TreatGroup = new System.Windows.Forms.Label();
            this.lbl_TreatPrice = new System.Windows.Forms.Label();
            this.tp_EditTreatment = new System.Windows.Forms.TabPage();
            this.pnl_EditUser = new System.Windows.Forms.Panel();
            this.txt_TreatNameEdit = new System.Windows.Forms.TextBox();
            this.txt_TreatPriceEdit = new System.Windows.Forms.TextBox();
            this.lbl_TreatNameEdit = new System.Windows.Forms.Label();
            this.lbl_TreatTypeEdit = new System.Windows.Forms.Label();
            this.lbl_TreatPriceEdit = new System.Windows.Forms.Label();
            this.cb_TreatGroupEdit = new System.Windows.Forms.ComboBox();
            this.lbl_EditTreat = new System.Windows.Forms.Label();
            this.pic_EditTreatment = new System.Windows.Forms.PictureBox();
            this.btn_EditTreat = new System.Windows.Forms.Button();
            this.lbl_EditTreatNoText = new System.Windows.Forms.Label();
            this.lbl_TreatGroupEdit = new System.Windows.Forms.Label();
            this.cb_TreatTypeEdit = new System.Windows.Forms.ComboBox();
            this.tab_Treatments.SuspendLayout();
            this.tp_Treatments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Treatments)).BeginInit();
            this.tp_AddTreat.SuspendLayout();
            this.pnl_AddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTreat)).BeginInit();
            this.tp_EditTreatment.SuspendLayout();
            this.pnl_EditUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EditTreatment)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Treatments
            // 
            this.tab_Treatments.Controls.Add(this.tp_Treatments);
            this.tab_Treatments.Controls.Add(this.tp_AddTreat);
            this.tab_Treatments.Controls.Add(this.tp_EditTreatment);
            this.tab_Treatments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Treatments.Location = new System.Drawing.Point(0, 0);
            this.tab_Treatments.Name = "tab_Treatments";
            this.tab_Treatments.SelectedIndex = 0;
            this.tab_Treatments.Size = new System.Drawing.Size(958, 611);
            this.tab_Treatments.TabIndex = 5;
            this.tab_Treatments.Tag = "";
            this.tab_Treatments.SelectedIndexChanged += new System.EventHandler(this.tab_Treatments_SelectedIndexChanged);
            // 
            // tp_Treatments
            // 
            this.tp_Treatments.BackColor = System.Drawing.Color.DarkGray;
            this.tp_Treatments.Controls.Add(this.dgv_Treatments);
            this.tp_Treatments.Location = new System.Drawing.Point(4, 22);
            this.tp_Treatments.Name = "tp_Treatments";
            this.tp_Treatments.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Treatments.Size = new System.Drawing.Size(950, 585);
            this.tp_Treatments.TabIndex = 0;
            this.tp_Treatments.Text = "Treatment List";
            // 
            // dgv_Treatments
            // 
            this.dgv_Treatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Treatments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Treatments.Location = new System.Drawing.Point(3, 3);
            this.dgv_Treatments.Name = "dgv_Treatments";
            this.dgv_Treatments.RowTemplate.Height = 40;
            this.dgv_Treatments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Treatments.Size = new System.Drawing.Size(944, 579);
            this.dgv_Treatments.TabIndex = 0;
            // 
            // tp_AddTreat
            // 
            this.tp_AddTreat.BackColor = System.Drawing.Color.PaleVioletRed;
            this.tp_AddTreat.Controls.Add(this.pnl_AddUser);
            this.tp_AddTreat.Location = new System.Drawing.Point(4, 22);
            this.tp_AddTreat.Name = "tp_AddTreat";
            this.tp_AddTreat.Padding = new System.Windows.Forms.Padding(3);
            this.tp_AddTreat.Size = new System.Drawing.Size(950, 585);
            this.tp_AddTreat.TabIndex = 1;
            this.tp_AddTreat.Text = "Add Treatment";
            // 
            // pnl_AddUser
            // 
            this.pnl_AddUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_AddUser.Controls.Add(this.cb_TreatType);
            this.pnl_AddUser.Controls.Add(this.cb_TreatGroup);
            this.pnl_AddUser.Controls.Add(this.picTreat);
            this.pnl_AddUser.Controls.Add(this.txt_TreatName);
            this.pnl_AddUser.Controls.Add(this.btn_AddTreat);
            this.pnl_AddUser.Controls.Add(this.lbl_TreatNo);
            this.pnl_AddUser.Controls.Add(this.lbl_TreatNoText);
            this.pnl_AddUser.Controls.Add(this.txt_TreatPrice);
            this.pnl_AddUser.Controls.Add(this.lbl_TreatName);
            this.pnl_AddUser.Controls.Add(this.lbl_TreatType);
            this.pnl_AddUser.Controls.Add(this.lbl_TreatGroup);
            this.pnl_AddUser.Controls.Add(this.lbl_TreatPrice);
            this.pnl_AddUser.Location = new System.Drawing.Point(75, 117);
            this.pnl_AddUser.Name = "pnl_AddUser";
            this.pnl_AddUser.Size = new System.Drawing.Size(783, 341);
            this.pnl_AddUser.TabIndex = 25;
            // 
            // cb_TreatType
            // 
            this.cb_TreatType.FormattingEnabled = true;
            this.cb_TreatType.Items.AddRange(new object[] {
            "Hairdressing",
            "Hand and Feet Treats",
            "Eye Treatments",
            "Facial Treatments",
            "Waxing",
            "Body Treatments"});
            this.cb_TreatType.Location = new System.Drawing.Point(218, 168);
            this.cb_TreatType.Name = "cb_TreatType";
            this.cb_TreatType.Size = new System.Drawing.Size(192, 21);
            this.cb_TreatType.TabIndex = 27;
            // 
            // cb_TreatGroup
            // 
            this.cb_TreatGroup.FormattingEnabled = true;
            this.cb_TreatGroup.Items.AddRange(new object[] {
            "Hair",
            "Beauty"});
            this.cb_TreatGroup.Location = new System.Drawing.Point(218, 93);
            this.cb_TreatGroup.Name = "cb_TreatGroup";
            this.cb_TreatGroup.Size = new System.Drawing.Size(121, 21);
            this.cb_TreatGroup.TabIndex = 26;
            this.cb_TreatGroup.SelectedIndexChanged += new System.EventHandler(this.cb_TreatGroup_SelectedIndexChanged);
            // 
            // picTreat
            // 
            this.picTreat.Image = ((System.Drawing.Image)(resources.GetObject("picTreat.Image")));
            this.picTreat.Location = new System.Drawing.Point(509, 43);
            this.picTreat.Name = "picTreat";
            this.picTreat.Size = new System.Drawing.Size(205, 184);
            this.picTreat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTreat.TabIndex = 25;
            this.picTreat.TabStop = false;
            // 
            // txt_TreatName
            // 
            this.txt_TreatName.BackColor = System.Drawing.Color.MistyRose;
            this.txt_TreatName.Location = new System.Drawing.Point(218, 132);
            this.txt_TreatName.Name = "txt_TreatName";
            this.txt_TreatName.Size = new System.Drawing.Size(192, 20);
            this.txt_TreatName.TabIndex = 15;
            // 
            // btn_AddTreat
            // 
            this.btn_AddTreat.BackColor = System.Drawing.Color.Plum;
            this.btn_AddTreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddTreat.Location = new System.Drawing.Point(535, 233);
            this.btn_AddTreat.Name = "btn_AddTreat";
            this.btn_AddTreat.Size = new System.Drawing.Size(153, 64);
            this.btn_AddTreat.TabIndex = 0;
            this.btn_AddTreat.Text = "Add New Treatment";
            this.btn_AddTreat.UseVisualStyleBackColor = false;
            this.btn_AddTreat.Click += new System.EventHandler(this.btn_AddTreat_Click);
            // 
            // lbl_TreatNo
            // 
            this.lbl_TreatNo.AutoSize = true;
            this.lbl_TreatNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TreatNo.Location = new System.Drawing.Point(40, 57);
            this.lbl_TreatNo.Name = "lbl_TreatNo";
            this.lbl_TreatNo.Size = new System.Drawing.Size(150, 18);
            this.lbl_TreatNo.TabIndex = 1;
            this.lbl_TreatNo.Text = "Treatment number ";
            // 
            // lbl_TreatNoText
            // 
            this.lbl_TreatNoText.AutoSize = true;
            this.lbl_TreatNoText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_TreatNoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TreatNoText.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbl_TreatNoText.Location = new System.Drawing.Point(222, 57);
            this.lbl_TreatNoText.Name = "lbl_TreatNoText";
            this.lbl_TreatNoText.Size = new System.Drawing.Size(48, 16);
            this.lbl_TreatNoText.TabIndex = 2;
            this.lbl_TreatNoText.Text = "********";
            // 
            // txt_TreatPrice
            // 
            this.txt_TreatPrice.BackColor = System.Drawing.Color.MistyRose;
            this.txt_TreatPrice.Location = new System.Drawing.Point(218, 207);
            this.txt_TreatPrice.Name = "txt_TreatPrice";
            this.txt_TreatPrice.Size = new System.Drawing.Size(192, 20);
            this.txt_TreatPrice.TabIndex = 22;
            // 
            // lbl_TreatName
            // 
            this.lbl_TreatName.AutoSize = true;
            this.lbl_TreatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TreatName.Location = new System.Drawing.Point(51, 132);
            this.lbl_TreatName.Name = "lbl_TreatName";
            this.lbl_TreatName.Size = new System.Drawing.Size(133, 18);
            this.lbl_TreatName.TabIndex = 3;
            this.lbl_TreatName.Text = "Treatment Name";
            // 
            // lbl_TreatType
            // 
            this.lbl_TreatType.AutoSize = true;
            this.lbl_TreatType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TreatType.Location = new System.Drawing.Point(59, 171);
            this.lbl_TreatType.Name = "lbl_TreatType";
            this.lbl_TreatType.Size = new System.Drawing.Size(125, 18);
            this.lbl_TreatType.TabIndex = 4;
            this.lbl_TreatType.Text = "Treatment Type";
            // 
            // lbl_TreatGroup
            // 
            this.lbl_TreatGroup.AutoSize = true;
            this.lbl_TreatGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TreatGroup.Location = new System.Drawing.Point(48, 96);
            this.lbl_TreatGroup.Name = "lbl_TreatGroup";
            this.lbl_TreatGroup.Size = new System.Drawing.Size(136, 18);
            this.lbl_TreatGroup.TabIndex = 7;
            this.lbl_TreatGroup.Text = "Treatment Group";
            // 
            // lbl_TreatPrice
            // 
            this.lbl_TreatPrice.AutoSize = true;
            this.lbl_TreatPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TreatPrice.Location = new System.Drawing.Point(54, 209);
            this.lbl_TreatPrice.Name = "lbl_TreatPrice";
            this.lbl_TreatPrice.Size = new System.Drawing.Size(167, 18);
            this.lbl_TreatPrice.TabIndex = 12;
            this.lbl_TreatPrice.Text = "Treatment Price      £";
            // 
            // tp_EditTreatment
            // 
            this.tp_EditTreatment.BackColor = System.Drawing.Color.LightBlue;
            this.tp_EditTreatment.Controls.Add(this.pnl_EditUser);
            this.tp_EditTreatment.Location = new System.Drawing.Point(4, 22);
            this.tp_EditTreatment.Name = "tp_EditTreatment";
            this.tp_EditTreatment.Padding = new System.Windows.Forms.Padding(3);
            this.tp_EditTreatment.Size = new System.Drawing.Size(950, 585);
            this.tp_EditTreatment.TabIndex = 2;
            this.tp_EditTreatment.Text = "Edit Treatment";
            // 
            // pnl_EditUser
            // 
            this.pnl_EditUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_EditUser.Controls.Add(this.cb_TreatTypeEdit);
            this.pnl_EditUser.Controls.Add(this.txt_TreatNameEdit);
            this.pnl_EditUser.Controls.Add(this.txt_TreatPriceEdit);
            this.pnl_EditUser.Controls.Add(this.lbl_TreatNameEdit);
            this.pnl_EditUser.Controls.Add(this.lbl_TreatTypeEdit);
            this.pnl_EditUser.Controls.Add(this.lbl_TreatPriceEdit);
            this.pnl_EditUser.Controls.Add(this.cb_TreatGroupEdit);
            this.pnl_EditUser.Controls.Add(this.lbl_EditTreat);
            this.pnl_EditUser.Controls.Add(this.pic_EditTreatment);
            this.pnl_EditUser.Controls.Add(this.btn_EditTreat);
            this.pnl_EditUser.Controls.Add(this.lbl_EditTreatNoText);
            this.pnl_EditUser.Controls.Add(this.lbl_TreatGroupEdit);
            this.pnl_EditUser.Location = new System.Drawing.Point(97, 88);
            this.pnl_EditUser.Name = "pnl_EditUser";
            this.pnl_EditUser.Size = new System.Drawing.Size(778, 335);
            this.pnl_EditUser.TabIndex = 26;
            // 
            // txt_TreatNameEdit
            // 
            this.txt_TreatNameEdit.BackColor = System.Drawing.Color.MistyRose;
            this.txt_TreatNameEdit.Location = new System.Drawing.Point(209, 148);
            this.txt_TreatNameEdit.Name = "txt_TreatNameEdit";
            this.txt_TreatNameEdit.Size = new System.Drawing.Size(192, 20);
            this.txt_TreatNameEdit.TabIndex = 31;
            // 
            // txt_TreatPriceEdit
            // 
            this.txt_TreatPriceEdit.BackColor = System.Drawing.Color.MistyRose;
            this.txt_TreatPriceEdit.Location = new System.Drawing.Point(209, 223);
            this.txt_TreatPriceEdit.Name = "txt_TreatPriceEdit";
            this.txt_TreatPriceEdit.Size = new System.Drawing.Size(192, 20);
            this.txt_TreatPriceEdit.TabIndex = 33;
            // 
            // lbl_TreatNameEdit
            // 
            this.lbl_TreatNameEdit.AutoSize = true;
            this.lbl_TreatNameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TreatNameEdit.Location = new System.Drawing.Point(42, 148);
            this.lbl_TreatNameEdit.Name = "lbl_TreatNameEdit";
            this.lbl_TreatNameEdit.Size = new System.Drawing.Size(133, 18);
            this.lbl_TreatNameEdit.TabIndex = 28;
            this.lbl_TreatNameEdit.Text = "Treatment Name";
            // 
            // lbl_TreatTypeEdit
            // 
            this.lbl_TreatTypeEdit.AutoSize = true;
            this.lbl_TreatTypeEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TreatTypeEdit.Location = new System.Drawing.Point(50, 187);
            this.lbl_TreatTypeEdit.Name = "lbl_TreatTypeEdit";
            this.lbl_TreatTypeEdit.Size = new System.Drawing.Size(125, 18);
            this.lbl_TreatTypeEdit.TabIndex = 29;
            this.lbl_TreatTypeEdit.Text = "Treatment Type";
            // 
            // lbl_TreatPriceEdit
            // 
            this.lbl_TreatPriceEdit.AutoSize = true;
            this.lbl_TreatPriceEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TreatPriceEdit.Location = new System.Drawing.Point(45, 225);
            this.lbl_TreatPriceEdit.Name = "lbl_TreatPriceEdit";
            this.lbl_TreatPriceEdit.Size = new System.Drawing.Size(167, 18);
            this.lbl_TreatPriceEdit.TabIndex = 30;
            this.lbl_TreatPriceEdit.Text = "Treatment Price      £";
            // 
            // cb_TreatGroupEdit
            // 
            this.cb_TreatGroupEdit.FormattingEnabled = true;
            this.cb_TreatGroupEdit.Items.AddRange(new object[] {
            "Hair",
            "Beauty"});
            this.cb_TreatGroupEdit.Location = new System.Drawing.Point(210, 112);
            this.cb_TreatGroupEdit.Name = "cb_TreatGroupEdit";
            this.cb_TreatGroupEdit.Size = new System.Drawing.Size(121, 21);
            this.cb_TreatGroupEdit.TabIndex = 27;
            // 
            // lbl_EditTreat
            // 
            this.lbl_EditTreat.AutoSize = true;
            this.lbl_EditTreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EditTreat.Location = new System.Drawing.Point(32, 70);
            this.lbl_EditTreat.Name = "lbl_EditTreat";
            this.lbl_EditTreat.Size = new System.Drawing.Size(150, 18);
            this.lbl_EditTreat.TabIndex = 26;
            this.lbl_EditTreat.Text = "Treatment number ";
            // 
            // pic_EditTreatment
            // 
            this.pic_EditTreatment.Image = ((System.Drawing.Image)(resources.GetObject("pic_EditTreatment.Image")));
            this.pic_EditTreatment.Location = new System.Drawing.Point(525, 43);
            this.pic_EditTreatment.Name = "pic_EditTreatment";
            this.pic_EditTreatment.Size = new System.Drawing.Size(205, 200);
            this.pic_EditTreatment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_EditTreatment.TabIndex = 25;
            this.pic_EditTreatment.TabStop = false;
            // 
            // btn_EditTreat
            // 
            this.btn_EditTreat.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_EditTreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditTreat.Location = new System.Drawing.Point(558, 249);
            this.btn_EditTreat.Name = "btn_EditTreat";
            this.btn_EditTreat.Size = new System.Drawing.Size(153, 64);
            this.btn_EditTreat.TabIndex = 0;
            this.btn_EditTreat.Text = "Edit Treatment";
            this.btn_EditTreat.UseVisualStyleBackColor = false;
            // 
            // lbl_EditTreatNoText
            // 
            this.lbl_EditTreatNoText.AutoSize = true;
            this.lbl_EditTreatNoText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_EditTreatNoText.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbl_EditTreatNoText.Location = new System.Drawing.Point(214, 74);
            this.lbl_EditTreatNoText.Name = "lbl_EditTreatNoText";
            this.lbl_EditTreatNoText.Size = new System.Drawing.Size(0, 13);
            this.lbl_EditTreatNoText.TabIndex = 2;
            // 
            // lbl_TreatGroupEdit
            // 
            this.lbl_TreatGroupEdit.AutoSize = true;
            this.lbl_TreatGroupEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TreatGroupEdit.Location = new System.Drawing.Point(39, 111);
            this.lbl_TreatGroupEdit.Name = "lbl_TreatGroupEdit";
            this.lbl_TreatGroupEdit.Size = new System.Drawing.Size(136, 18);
            this.lbl_TreatGroupEdit.TabIndex = 7;
            this.lbl_TreatGroupEdit.Text = "Treatment Group";
            // 
            // cb_TreatTypeEdit
            // 
            this.cb_TreatTypeEdit.FormattingEnabled = true;
            this.cb_TreatTypeEdit.Items.AddRange(new object[] {
            "Hairdressing",
            "Hand and Feet Treats",
            "Eye Treatments",
            "Facial Treatments",
            "Waxing",
            "Body Treatments"});
            this.cb_TreatTypeEdit.Location = new System.Drawing.Point(209, 184);
            this.cb_TreatTypeEdit.Name = "cb_TreatTypeEdit";
            this.cb_TreatTypeEdit.Size = new System.Drawing.Size(192, 21);
            this.cb_TreatTypeEdit.TabIndex = 34;
            // 
            // uc_Treatments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tab_Treatments);
            this.Name = "uc_Treatments";
            this.Size = new System.Drawing.Size(958, 611);
            this.Load += new System.EventHandler(this.uc_Treatments_Load);
            this.tab_Treatments.ResumeLayout(false);
            this.tp_Treatments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Treatments)).EndInit();
            this.tp_AddTreat.ResumeLayout(false);
            this.pnl_AddUser.ResumeLayout(false);
            this.pnl_AddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTreat)).EndInit();
            this.tp_EditTreatment.ResumeLayout(false);
            this.pnl_EditUser.ResumeLayout(false);
            this.pnl_EditUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EditTreatment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Treatments;
        private System.Windows.Forms.TabPage tp_Treatments;
        private System.Windows.Forms.DataGridView dgv_Treatments;
        private System.Windows.Forms.TabPage tp_AddTreat;
        private System.Windows.Forms.Panel pnl_AddUser;
        private System.Windows.Forms.PictureBox picTreat;
        private System.Windows.Forms.TextBox txt_TreatName;
        private System.Windows.Forms.Button btn_AddTreat;
        private System.Windows.Forms.Label lbl_TreatNo;
        private System.Windows.Forms.Label lbl_TreatNoText;
        private System.Windows.Forms.TextBox txt_TreatPrice;
        private System.Windows.Forms.Label lbl_TreatName;
        private System.Windows.Forms.Label lbl_TreatType;
        private System.Windows.Forms.Label lbl_TreatGroup;
        private System.Windows.Forms.Label lbl_TreatPrice;
        private System.Windows.Forms.TabPage tp_EditTreatment;
        private System.Windows.Forms.Panel pnl_EditUser;
        private System.Windows.Forms.PictureBox pic_EditTreatment;
        private System.Windows.Forms.Button btn_EditTreat;
        private System.Windows.Forms.ComboBox cb_TreatGroup;
        private System.Windows.Forms.Label lbl_EditTreatNoText;
        private System.Windows.Forms.Label lbl_TreatGroupEdit;
        private System.Windows.Forms.Label lbl_EditTreat;
        private System.Windows.Forms.TextBox txt_TreatNameEdit;
        private System.Windows.Forms.TextBox txt_TreatPriceEdit;
        private System.Windows.Forms.Label lbl_TreatNameEdit;
        private System.Windows.Forms.Label lbl_TreatTypeEdit;
        private System.Windows.Forms.Label lbl_TreatPriceEdit;
        private System.Windows.Forms.ComboBox cb_TreatGroupEdit;
        private System.Windows.Forms.ComboBox cb_TreatType;
        private System.Windows.Forms.ComboBox cb_TreatTypeEdit;
    }
}
