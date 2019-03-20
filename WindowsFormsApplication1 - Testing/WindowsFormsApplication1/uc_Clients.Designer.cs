namespace HairBeautyNWRC
{
    partial class uc_Clients
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
            this.components = new System.ComponentModel.Container();
            this.tab_Client = new System.Windows.Forms.TabControl();
            this.tp_Client = new System.Windows.Forms.TabPage();
            this.dgv_Clients = new System.Windows.Forms.DataGridView();
            this.tp_AddClient = new System.Windows.Forms.TabPage();
            this.pnl_Addclient = new System.Windows.Forms.Panel();
            this.cmb_Title = new System.Windows.Forms.ComboBox();
            this.txt_Forename = new System.Windows.Forms.TextBox();
            this.btn_AddClient = new System.Windows.Forms.Button();
            this.chk_Skin = new System.Windows.Forms.CheckBox();
            this.lbl_ClientNo = new System.Windows.Forms.Label();
            this.richTxt_Street = new System.Windows.Forms.RichTextBox();
            this.lbl_ClientNoText = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_forename = new System.Windows.Forms.Label();
            this.txt_Telephone = new System.Windows.Forms.TextBox();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.lbl_Street = new System.Windows.Forms.Label();
            this.txt_Postcode = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txt_County = new System.Windows.Forms.TextBox();
            this.lbl_Town = new System.Windows.Forms.Label();
            this.txt_Town = new System.Windows.Forms.TextBox();
            this.lbl_County = new System.Windows.Forms.Label();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.lbl_Postcode = new System.Windows.Forms.Label();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_TelNo = new System.Windows.Forms.Label();
            this.lbl_SkinTest = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.tp_EditClient = new System.Windows.Forms.TabPage();
            this.pnl_Editclient = new System.Windows.Forms.Panel();
            this.cmb_Title_Edit = new System.Windows.Forms.ComboBox();
            this.txt_Forename_Edit = new System.Windows.Forms.TextBox();
            this.btn_EditClient = new System.Windows.Forms.Button();
            this.chk_Skin_Edit = new System.Windows.Forms.CheckBox();
            this.lbl_ClientNo_Edit = new System.Windows.Forms.Label();
            this.rt_Street_Edit = new System.Windows.Forms.RichTextBox();
            this.lbl_ClientNo_EditText = new System.Windows.Forms.Label();
            this.txt_Email_Edit = new System.Windows.Forms.TextBox();
            this.lbl_Forename_Edit = new System.Windows.Forms.Label();
            this.txt_TelNo_Edit = new System.Windows.Forms.TextBox();
            this.lbl_Surname_Edit = new System.Windows.Forms.Label();
            this.txt_Country_Edit = new System.Windows.Forms.TextBox();
            this.lbl_Street_Edit = new System.Windows.Forms.Label();
            this.txt_Postcode_Edit = new System.Windows.Forms.TextBox();
            this.lbl_Title_Edit = new System.Windows.Forms.Label();
            this.txt_County_Edit = new System.Windows.Forms.TextBox();
            this.lbl_Town_Edit = new System.Windows.Forms.Label();
            this.txt_Town_Edit = new System.Windows.Forms.TextBox();
            this.lbl_County_Edit = new System.Windows.Forms.Label();
            this.txt_Surname_Edit = new System.Windows.Forms.TextBox();
            this.lbl_Postcode_Edit = new System.Windows.Forms.Label();
            this.lbl_Country_Edit = new System.Windows.Forms.Label();
            this.lbl_TelNo_Edit = new System.Windows.Forms.Label();
            this.lbl_Skin_Edit = new System.Windows.Forms.Label();
            this.lbl_Email_Edit = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_Display_Edit = new System.Windows.Forms.Button();
            this.btn_Display_Add = new System.Windows.Forms.Button();
            this.btn_Display_Delete = new System.Windows.Forms.Button();
            this.pnl_Test = new System.Windows.Forms.Panel();
            this.tab_Client.SuspendLayout();
            this.tp_Client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clients)).BeginInit();
            this.tp_AddClient.SuspendLayout();
            this.pnl_Addclient.SuspendLayout();
            this.tp_EditClient.SuspendLayout();
            this.pnl_Editclient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnl_Test.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Client
            // 
            this.tab_Client.Controls.Add(this.tp_Client);
            this.tab_Client.Controls.Add(this.tp_AddClient);
            this.tab_Client.Controls.Add(this.tp_EditClient);
            this.tab_Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Client.Location = new System.Drawing.Point(0, 0);
            this.tab_Client.Name = "tab_Client";
            this.tab_Client.SelectedIndex = 0;
            this.tab_Client.Size = new System.Drawing.Size(853, 587);
            this.tab_Client.TabIndex = 3;
            this.tab_Client.Tag = "";
            this.tab_Client.SelectedIndexChanged += new System.EventHandler(this.tab_Client_SelectedIndexChanged);
            // 
            // tp_Client
            // 
            this.tp_Client.BackColor = System.Drawing.Color.DarkGray;
            this.tp_Client.Controls.Add(this.dgv_Clients);
            this.tp_Client.Location = new System.Drawing.Point(4, 22);
            this.tp_Client.Name = "tp_Client";
            this.tp_Client.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Client.Size = new System.Drawing.Size(845, 561);
            this.tp_Client.TabIndex = 0;
            this.tp_Client.Text = "Client ist";
            // 
            // dgv_Clients
            // 
            this.dgv_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Clients.Location = new System.Drawing.Point(3, 3);
            this.dgv_Clients.Name = "dgv_Clients";
            this.dgv_Clients.RowTemplate.Height = 40;
            this.dgv_Clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Clients.Size = new System.Drawing.Size(839, 555);
            this.dgv_Clients.TabIndex = 0;
            // 
            // tp_AddClient
            // 
            this.tp_AddClient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tp_AddClient.Controls.Add(this.pnl_Addclient);
            this.tp_AddClient.Location = new System.Drawing.Point(4, 22);
            this.tp_AddClient.Name = "tp_AddClient";
            this.tp_AddClient.Padding = new System.Windows.Forms.Padding(3);
            this.tp_AddClient.Size = new System.Drawing.Size(845, 561);
            this.tp_AddClient.TabIndex = 1;
            this.tp_AddClient.Text = "Add Client";
            // 
            // pnl_Addclient
            // 
            this.pnl_Addclient.Controls.Add(this.cmb_Title);
            this.pnl_Addclient.Controls.Add(this.txt_Forename);
            this.pnl_Addclient.Controls.Add(this.btn_AddClient);
            this.pnl_Addclient.Controls.Add(this.chk_Skin);
            this.pnl_Addclient.Controls.Add(this.lbl_ClientNo);
            this.pnl_Addclient.Controls.Add(this.richTxt_Street);
            this.pnl_Addclient.Controls.Add(this.lbl_ClientNoText);
            this.pnl_Addclient.Controls.Add(this.txt_Email);
            this.pnl_Addclient.Controls.Add(this.lbl_forename);
            this.pnl_Addclient.Controls.Add(this.txt_Telephone);
            this.pnl_Addclient.Controls.Add(this.lbl_Surname);
            this.pnl_Addclient.Controls.Add(this.txt_Country);
            this.pnl_Addclient.Controls.Add(this.lbl_Street);
            this.pnl_Addclient.Controls.Add(this.txt_Postcode);
            this.pnl_Addclient.Controls.Add(this.lbl_Title);
            this.pnl_Addclient.Controls.Add(this.txt_County);
            this.pnl_Addclient.Controls.Add(this.lbl_Town);
            this.pnl_Addclient.Controls.Add(this.txt_Town);
            this.pnl_Addclient.Controls.Add(this.lbl_County);
            this.pnl_Addclient.Controls.Add(this.txt_Surname);
            this.pnl_Addclient.Controls.Add(this.lbl_Postcode);
            this.pnl_Addclient.Controls.Add(this.lbl_Country);
            this.pnl_Addclient.Controls.Add(this.lbl_TelNo);
            this.pnl_Addclient.Controls.Add(this.lbl_SkinTest);
            this.pnl_Addclient.Controls.Add(this.lbl_Email);
            this.pnl_Addclient.Location = new System.Drawing.Point(147, 51);
            this.pnl_Addclient.Name = "pnl_Addclient";
            this.pnl_Addclient.Size = new System.Drawing.Size(647, 489);
            this.pnl_Addclient.TabIndex = 25;
            // 
            // cmb_Title
            // 
            this.cmb_Title.FormattingEnabled = true;
            this.cmb_Title.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Miss",
            "Ms",
            "Dr"});
            this.cmb_Title.Location = new System.Drawing.Point(166, 56);
            this.cmb_Title.Name = "cmb_Title";
            this.cmb_Title.Size = new System.Drawing.Size(54, 21);
            this.cmb_Title.TabIndex = 28;
            // 
            // txt_Forename
            // 
            this.txt_Forename.Location = new System.Drawing.Point(166, 84);
            this.txt_Forename.Name = "txt_Forename";
            this.txt_Forename.Size = new System.Drawing.Size(192, 20);
            this.txt_Forename.TabIndex = 15;
            this.txt_Forename.TextChanged += new System.EventHandler(this.txtChanged);
            // 
            // btn_AddClient
            // 
            this.btn_AddClient.Location = new System.Drawing.Point(474, 402);
            this.btn_AddClient.Name = "btn_AddClient";
            this.btn_AddClient.Size = new System.Drawing.Size(153, 64);
            this.btn_AddClient.TabIndex = 0;
            this.btn_AddClient.Text = "Add New Client";
            this.btn_AddClient.UseVisualStyleBackColor = true;
            this.btn_AddClient.Click += new System.EventHandler(this.btn_AddClient_Click);
            // 
            // chk_Skin
            // 
            this.chk_Skin.AutoSize = true;
            this.chk_Skin.Location = new System.Drawing.Point(166, 449);
            this.chk_Skin.Name = "chk_Skin";
            this.chk_Skin.Size = new System.Drawing.Size(44, 17);
            this.chk_Skin.TabIndex = 24;
            this.chk_Skin.Text = "Yes";
            this.chk_Skin.UseVisualStyleBackColor = true;
            // 
            // lbl_ClientNo
            // 
            this.lbl_ClientNo.AutoSize = true;
            this.lbl_ClientNo.Location = new System.Drawing.Point(53, 25);
            this.lbl_ClientNo.Name = "lbl_ClientNo";
            this.lbl_ClientNo.Size = new System.Drawing.Size(77, 13);
            this.lbl_ClientNo.TabIndex = 1;
            this.lbl_ClientNo.Text = "Client number: ";
            // 
            // richTxt_Street
            // 
            this.richTxt_Street.Location = new System.Drawing.Point(166, 150);
            this.richTxt_Street.Name = "richTxt_Street";
            this.richTxt_Street.Size = new System.Drawing.Size(192, 57);
            this.richTxt_Street.TabIndex = 23;
            this.richTxt_Street.Text = "";
            // 
            // lbl_ClientNoText
            // 
            this.lbl_ClientNoText.AutoSize = true;
            this.lbl_ClientNoText.Location = new System.Drawing.Point(172, 25);
            this.lbl_ClientNoText.Name = "lbl_ClientNoText";
            this.lbl_ClientNoText.Size = new System.Drawing.Size(0, 13);
            this.lbl_ClientNoText.TabIndex = 2;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(166, 406);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(192, 20);
            this.txt_Email.TabIndex = 22;
            this.txt_Email.TextChanged += new System.EventHandler(this.txtChanged);
            // 
            // lbl_forename
            // 
            this.lbl_forename.AutoSize = true;
            this.lbl_forename.Location = new System.Drawing.Point(53, 91);
            this.lbl_forename.Name = "lbl_forename";
            this.lbl_forename.Size = new System.Drawing.Size(54, 13);
            this.lbl_forename.TabIndex = 3;
            this.lbl_forename.Text = "Forename";
            // 
            // txt_Telephone
            // 
            this.txt_Telephone.Location = new System.Drawing.Point(166, 362);
            this.txt_Telephone.Name = "txt_Telephone";
            this.txt_Telephone.Size = new System.Drawing.Size(192, 20);
            this.txt_Telephone.TabIndex = 21;
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(53, 124);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(49, 13);
            this.lbl_Surname.TabIndex = 4;
            this.lbl_Surname.Text = "Surname";
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(166, 325);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(116, 20);
            this.txt_Country.TabIndex = 20;
            // 
            // lbl_Street
            // 
            this.lbl_Street.AutoSize = true;
            this.lbl_Street.Location = new System.Drawing.Point(53, 153);
            this.lbl_Street.Name = "lbl_Street";
            this.lbl_Street.Size = new System.Drawing.Size(76, 13);
            this.lbl_Street.TabIndex = 5;
            this.lbl_Street.Text = "Street Address";
            // 
            // txt_Postcode
            // 
            this.txt_Postcode.Location = new System.Drawing.Point(166, 292);
            this.txt_Postcode.Name = "txt_Postcode";
            this.txt_Postcode.Size = new System.Drawing.Size(116, 20);
            this.txt_Postcode.TabIndex = 19;
            this.txt_Postcode.TextChanged += new System.EventHandler(this.txtChanged);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(53, 59);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(27, 13);
            this.lbl_Title.TabIndex = 6;
            this.lbl_Title.Text = "Title";
            // 
            // txt_County
            // 
            this.txt_County.Location = new System.Drawing.Point(166, 254);
            this.txt_County.Name = "txt_County";
            this.txt_County.Size = new System.Drawing.Size(116, 20);
            this.txt_County.TabIndex = 18;
            // 
            // lbl_Town
            // 
            this.lbl_Town.AutoSize = true;
            this.lbl_Town.Location = new System.Drawing.Point(53, 227);
            this.lbl_Town.Name = "lbl_Town";
            this.lbl_Town.Size = new System.Drawing.Size(34, 13);
            this.lbl_Town.TabIndex = 7;
            this.lbl_Town.Text = "Town";
            // 
            // txt_Town
            // 
            this.txt_Town.Location = new System.Drawing.Point(166, 220);
            this.txt_Town.Name = "txt_Town";
            this.txt_Town.Size = new System.Drawing.Size(192, 20);
            this.txt_Town.TabIndex = 17;
            // 
            // lbl_County
            // 
            this.lbl_County.AutoSize = true;
            this.lbl_County.Location = new System.Drawing.Point(53, 257);
            this.lbl_County.Name = "lbl_County";
            this.lbl_County.Size = new System.Drawing.Size(40, 13);
            this.lbl_County.TabIndex = 8;
            this.lbl_County.Text = "County";
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(166, 117);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(192, 20);
            this.txt_Surname.TabIndex = 16;
            this.txt_Surname.TextChanged += new System.EventHandler(this.txtChanged);
            // 
            // lbl_Postcode
            // 
            this.lbl_Postcode.AutoSize = true;
            this.lbl_Postcode.Location = new System.Drawing.Point(53, 299);
            this.lbl_Postcode.Name = "lbl_Postcode";
            this.lbl_Postcode.Size = new System.Drawing.Size(52, 13);
            this.lbl_Postcode.TabIndex = 9;
            this.lbl_Postcode.Text = "Postcode";
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Location = new System.Drawing.Point(53, 332);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(43, 13);
            this.lbl_Country.TabIndex = 10;
            this.lbl_Country.Text = "Country";
            // 
            // lbl_TelNo
            // 
            this.lbl_TelNo.AutoSize = true;
            this.lbl_TelNo.Location = new System.Drawing.Point(53, 369);
            this.lbl_TelNo.Name = "lbl_TelNo";
            this.lbl_TelNo.Size = new System.Drawing.Size(98, 13);
            this.lbl_TelNo.TabIndex = 11;
            this.lbl_TelNo.Text = "Telephone Number";
            // 
            // lbl_SkinTest
            // 
            this.lbl_SkinTest.AutoSize = true;
            this.lbl_SkinTest.Location = new System.Drawing.Point(53, 449);
            this.lbl_SkinTest.Name = "lbl_SkinTest";
            this.lbl_SkinTest.Size = new System.Drawing.Size(99, 13);
            this.lbl_SkinTest.TabIndex = 13;
            this.lbl_SkinTest.Text = "Skin Test Complete";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(53, 406);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 12;
            this.lbl_Email.Text = "Email";
            // 
            // tp_EditClient
            // 
            this.tp_EditClient.BackColor = System.Drawing.Color.Tan;
            this.tp_EditClient.Controls.Add(this.pnl_Editclient);
            this.tp_EditClient.Location = new System.Drawing.Point(4, 22);
            this.tp_EditClient.Name = "tp_EditClient";
            this.tp_EditClient.Padding = new System.Windows.Forms.Padding(3);
            this.tp_EditClient.Size = new System.Drawing.Size(845, 561);
            this.tp_EditClient.TabIndex = 2;
            this.tp_EditClient.Text = "Edit Client";
            // 
            // pnl_Editclient
            // 
            this.pnl_Editclient.Controls.Add(this.cmb_Title_Edit);
            this.pnl_Editclient.Controls.Add(this.txt_Forename_Edit);
            this.pnl_Editclient.Controls.Add(this.btn_EditClient);
            this.pnl_Editclient.Controls.Add(this.chk_Skin_Edit);
            this.pnl_Editclient.Controls.Add(this.lbl_ClientNo_Edit);
            this.pnl_Editclient.Controls.Add(this.rt_Street_Edit);
            this.pnl_Editclient.Controls.Add(this.lbl_ClientNo_EditText);
            this.pnl_Editclient.Controls.Add(this.txt_Email_Edit);
            this.pnl_Editclient.Controls.Add(this.lbl_Forename_Edit);
            this.pnl_Editclient.Controls.Add(this.txt_TelNo_Edit);
            this.pnl_Editclient.Controls.Add(this.lbl_Surname_Edit);
            this.pnl_Editclient.Controls.Add(this.txt_Country_Edit);
            this.pnl_Editclient.Controls.Add(this.lbl_Street_Edit);
            this.pnl_Editclient.Controls.Add(this.txt_Postcode_Edit);
            this.pnl_Editclient.Controls.Add(this.lbl_Title_Edit);
            this.pnl_Editclient.Controls.Add(this.txt_County_Edit);
            this.pnl_Editclient.Controls.Add(this.lbl_Town_Edit);
            this.pnl_Editclient.Controls.Add(this.txt_Town_Edit);
            this.pnl_Editclient.Controls.Add(this.lbl_County_Edit);
            this.pnl_Editclient.Controls.Add(this.txt_Surname_Edit);
            this.pnl_Editclient.Controls.Add(this.lbl_Postcode_Edit);
            this.pnl_Editclient.Controls.Add(this.lbl_Country_Edit);
            this.pnl_Editclient.Controls.Add(this.lbl_TelNo_Edit);
            this.pnl_Editclient.Controls.Add(this.lbl_Skin_Edit);
            this.pnl_Editclient.Controls.Add(this.lbl_Email_Edit);
            this.pnl_Editclient.Location = new System.Drawing.Point(117, 41);
            this.pnl_Editclient.Name = "pnl_Editclient";
            this.pnl_Editclient.Size = new System.Drawing.Size(647, 489);
            this.pnl_Editclient.TabIndex = 26;
            // 
            // cmb_Title_Edit
            // 
            this.cmb_Title_Edit.Enabled = false;
            this.cmb_Title_Edit.FormattingEnabled = true;
            this.cmb_Title_Edit.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Miss",
            "Ms",
            "Dr"});
            this.cmb_Title_Edit.Location = new System.Drawing.Point(166, 51);
            this.cmb_Title_Edit.Name = "cmb_Title_Edit";
            this.cmb_Title_Edit.Size = new System.Drawing.Size(54, 21);
            this.cmb_Title_Edit.TabIndex = 27;
            // 
            // txt_Forename_Edit
            // 
            this.txt_Forename_Edit.Enabled = false;
            this.txt_Forename_Edit.Location = new System.Drawing.Point(166, 84);
            this.txt_Forename_Edit.Name = "txt_Forename_Edit";
            this.txt_Forename_Edit.Size = new System.Drawing.Size(192, 20);
            this.txt_Forename_Edit.TabIndex = 15;
            this.txt_Forename_Edit.TextChanged += new System.EventHandler(this.txtChanged);
            // 
            // btn_EditClient
            // 
            this.btn_EditClient.Location = new System.Drawing.Point(474, 402);
            this.btn_EditClient.Name = "btn_EditClient";
            this.btn_EditClient.Size = new System.Drawing.Size(153, 64);
            this.btn_EditClient.TabIndex = 0;
            this.btn_EditClient.Text = "Edit Client";
            this.btn_EditClient.UseVisualStyleBackColor = true;
            this.btn_EditClient.Click += new System.EventHandler(this.btn_EditClient_Click);
            // 
            // chk_Skin_Edit
            // 
            this.chk_Skin_Edit.AutoSize = true;
            this.chk_Skin_Edit.Enabled = false;
            this.chk_Skin_Edit.Location = new System.Drawing.Point(166, 449);
            this.chk_Skin_Edit.Name = "chk_Skin_Edit";
            this.chk_Skin_Edit.Size = new System.Drawing.Size(44, 17);
            this.chk_Skin_Edit.TabIndex = 24;
            this.chk_Skin_Edit.Text = "Yes";
            this.chk_Skin_Edit.UseVisualStyleBackColor = true;
            // 
            // lbl_ClientNo_Edit
            // 
            this.lbl_ClientNo_Edit.AutoSize = true;
            this.lbl_ClientNo_Edit.Location = new System.Drawing.Point(53, 25);
            this.lbl_ClientNo_Edit.Name = "lbl_ClientNo_Edit";
            this.lbl_ClientNo_Edit.Size = new System.Drawing.Size(77, 13);
            this.lbl_ClientNo_Edit.TabIndex = 1;
            this.lbl_ClientNo_Edit.Text = "Client number: ";
            // 
            // rt_Street_Edit
            // 
            this.rt_Street_Edit.Enabled = false;
            this.rt_Street_Edit.Location = new System.Drawing.Point(166, 150);
            this.rt_Street_Edit.Name = "rt_Street_Edit";
            this.rt_Street_Edit.Size = new System.Drawing.Size(192, 57);
            this.rt_Street_Edit.TabIndex = 23;
            this.rt_Street_Edit.Text = "";
            // 
            // lbl_ClientNo_EditText
            // 
            this.lbl_ClientNo_EditText.AutoSize = true;
            this.lbl_ClientNo_EditText.Enabled = false;
            this.lbl_ClientNo_EditText.Location = new System.Drawing.Point(172, 25);
            this.lbl_ClientNo_EditText.Name = "lbl_ClientNo_EditText";
            this.lbl_ClientNo_EditText.Size = new System.Drawing.Size(0, 13);
            this.lbl_ClientNo_EditText.TabIndex = 2;
            // 
            // txt_Email_Edit
            // 
            this.txt_Email_Edit.Enabled = false;
            this.txt_Email_Edit.Location = new System.Drawing.Point(166, 406);
            this.txt_Email_Edit.Name = "txt_Email_Edit";
            this.txt_Email_Edit.Size = new System.Drawing.Size(192, 20);
            this.txt_Email_Edit.TabIndex = 22;
            this.txt_Email_Edit.TextChanged += new System.EventHandler(this.txtChanged);
            // 
            // lbl_Forename_Edit
            // 
            this.lbl_Forename_Edit.AutoSize = true;
            this.lbl_Forename_Edit.Location = new System.Drawing.Point(53, 91);
            this.lbl_Forename_Edit.Name = "lbl_Forename_Edit";
            this.lbl_Forename_Edit.Size = new System.Drawing.Size(54, 13);
            this.lbl_Forename_Edit.TabIndex = 3;
            this.lbl_Forename_Edit.Text = "Forename";
            // 
            // txt_TelNo_Edit
            // 
            this.txt_TelNo_Edit.Enabled = false;
            this.txt_TelNo_Edit.Location = new System.Drawing.Point(166, 362);
            this.txt_TelNo_Edit.Name = "txt_TelNo_Edit";
            this.txt_TelNo_Edit.Size = new System.Drawing.Size(192, 20);
            this.txt_TelNo_Edit.TabIndex = 21;
            // 
            // lbl_Surname_Edit
            // 
            this.lbl_Surname_Edit.AutoSize = true;
            this.lbl_Surname_Edit.Location = new System.Drawing.Point(53, 124);
            this.lbl_Surname_Edit.Name = "lbl_Surname_Edit";
            this.lbl_Surname_Edit.Size = new System.Drawing.Size(49, 13);
            this.lbl_Surname_Edit.TabIndex = 4;
            this.lbl_Surname_Edit.Text = "Surname";
            // 
            // txt_Country_Edit
            // 
            this.txt_Country_Edit.Enabled = false;
            this.txt_Country_Edit.Location = new System.Drawing.Point(166, 325);
            this.txt_Country_Edit.Name = "txt_Country_Edit";
            this.txt_Country_Edit.Size = new System.Drawing.Size(116, 20);
            this.txt_Country_Edit.TabIndex = 20;
            // 
            // lbl_Street_Edit
            // 
            this.lbl_Street_Edit.AutoSize = true;
            this.lbl_Street_Edit.Location = new System.Drawing.Point(53, 153);
            this.lbl_Street_Edit.Name = "lbl_Street_Edit";
            this.lbl_Street_Edit.Size = new System.Drawing.Size(76, 13);
            this.lbl_Street_Edit.TabIndex = 5;
            this.lbl_Street_Edit.Text = "Street Address";
            // 
            // txt_Postcode_Edit
            // 
            this.txt_Postcode_Edit.Enabled = false;
            this.txt_Postcode_Edit.Location = new System.Drawing.Point(166, 292);
            this.txt_Postcode_Edit.Name = "txt_Postcode_Edit";
            this.txt_Postcode_Edit.Size = new System.Drawing.Size(116, 20);
            this.txt_Postcode_Edit.TabIndex = 19;
            this.txt_Postcode_Edit.TextChanged += new System.EventHandler(this.txtChanged);
            // 
            // lbl_Title_Edit
            // 
            this.lbl_Title_Edit.AutoSize = true;
            this.lbl_Title_Edit.Location = new System.Drawing.Point(53, 59);
            this.lbl_Title_Edit.Name = "lbl_Title_Edit";
            this.lbl_Title_Edit.Size = new System.Drawing.Size(27, 13);
            this.lbl_Title_Edit.TabIndex = 6;
            this.lbl_Title_Edit.Text = "Title";
            // 
            // txt_County_Edit
            // 
            this.txt_County_Edit.Enabled = false;
            this.txt_County_Edit.Location = new System.Drawing.Point(166, 254);
            this.txt_County_Edit.Name = "txt_County_Edit";
            this.txt_County_Edit.Size = new System.Drawing.Size(116, 20);
            this.txt_County_Edit.TabIndex = 18;
            // 
            // lbl_Town_Edit
            // 
            this.lbl_Town_Edit.AutoSize = true;
            this.lbl_Town_Edit.Location = new System.Drawing.Point(53, 227);
            this.lbl_Town_Edit.Name = "lbl_Town_Edit";
            this.lbl_Town_Edit.Size = new System.Drawing.Size(34, 13);
            this.lbl_Town_Edit.TabIndex = 7;
            this.lbl_Town_Edit.Text = "Town";
            // 
            // txt_Town_Edit
            // 
            this.txt_Town_Edit.Enabled = false;
            this.txt_Town_Edit.Location = new System.Drawing.Point(166, 220);
            this.txt_Town_Edit.Name = "txt_Town_Edit";
            this.txt_Town_Edit.Size = new System.Drawing.Size(192, 20);
            this.txt_Town_Edit.TabIndex = 17;
            // 
            // lbl_County_Edit
            // 
            this.lbl_County_Edit.AutoSize = true;
            this.lbl_County_Edit.Location = new System.Drawing.Point(53, 257);
            this.lbl_County_Edit.Name = "lbl_County_Edit";
            this.lbl_County_Edit.Size = new System.Drawing.Size(40, 13);
            this.lbl_County_Edit.TabIndex = 8;
            this.lbl_County_Edit.Text = "County";
            // 
            // txt_Surname_Edit
            // 
            this.txt_Surname_Edit.Enabled = false;
            this.txt_Surname_Edit.Location = new System.Drawing.Point(166, 117);
            this.txt_Surname_Edit.Name = "txt_Surname_Edit";
            this.txt_Surname_Edit.Size = new System.Drawing.Size(192, 20);
            this.txt_Surname_Edit.TabIndex = 16;
            this.txt_Surname_Edit.TextChanged += new System.EventHandler(this.txtChanged);
            // 
            // lbl_Postcode_Edit
            // 
            this.lbl_Postcode_Edit.AutoSize = true;
            this.lbl_Postcode_Edit.Location = new System.Drawing.Point(53, 299);
            this.lbl_Postcode_Edit.Name = "lbl_Postcode_Edit";
            this.lbl_Postcode_Edit.Size = new System.Drawing.Size(52, 13);
            this.lbl_Postcode_Edit.TabIndex = 9;
            this.lbl_Postcode_Edit.Text = "Postcode";
            // 
            // lbl_Country_Edit
            // 
            this.lbl_Country_Edit.AutoSize = true;
            this.lbl_Country_Edit.Location = new System.Drawing.Point(53, 332);
            this.lbl_Country_Edit.Name = "lbl_Country_Edit";
            this.lbl_Country_Edit.Size = new System.Drawing.Size(43, 13);
            this.lbl_Country_Edit.TabIndex = 10;
            this.lbl_Country_Edit.Text = "Country";
            // 
            // lbl_TelNo_Edit
            // 
            this.lbl_TelNo_Edit.AutoSize = true;
            this.lbl_TelNo_Edit.Enabled = false;
            this.lbl_TelNo_Edit.Location = new System.Drawing.Point(53, 369);
            this.lbl_TelNo_Edit.Name = "lbl_TelNo_Edit";
            this.lbl_TelNo_Edit.Size = new System.Drawing.Size(98, 13);
            this.lbl_TelNo_Edit.TabIndex = 11;
            this.lbl_TelNo_Edit.Text = "Telephone Number";
            // 
            // lbl_Skin_Edit
            // 
            this.lbl_Skin_Edit.AutoSize = true;
            this.lbl_Skin_Edit.Location = new System.Drawing.Point(53, 449);
            this.lbl_Skin_Edit.Name = "lbl_Skin_Edit";
            this.lbl_Skin_Edit.Size = new System.Drawing.Size(99, 13);
            this.lbl_Skin_Edit.TabIndex = 13;
            this.lbl_Skin_Edit.Text = "Skin Test Complete";
            // 
            // lbl_Email_Edit
            // 
            this.lbl_Email_Edit.AutoSize = true;
            this.lbl_Email_Edit.Location = new System.Drawing.Point(53, 406);
            this.lbl_Email_Edit.Name = "lbl_Email_Edit";
            this.lbl_Email_Edit.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email_Edit.TabIndex = 12;
            this.lbl_Email_Edit.Text = "Email";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_Display_Edit
            // 
            this.btn_Display_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Display_Edit.Location = new System.Drawing.Point(865, 394);
            this.btn_Display_Edit.Name = "btn_Display_Edit";
            this.btn_Display_Edit.Size = new System.Drawing.Size(140, 65);
            this.btn_Display_Edit.TabIndex = 6;
            this.btn_Display_Edit.Text = "Edit Client";
            this.btn_Display_Edit.UseVisualStyleBackColor = true;
            this.btn_Display_Edit.Click += new System.EventHandler(this.btn_Display_Edit_Click);
            // 
            // btn_Display_Add
            // 
            this.btn_Display_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Display_Add.Location = new System.Drawing.Point(862, 305);
            this.btn_Display_Add.Name = "btn_Display_Add";
            this.btn_Display_Add.Size = new System.Drawing.Size(140, 65);
            this.btn_Display_Add.TabIndex = 5;
            this.btn_Display_Add.Text = "Add Client";
            this.btn_Display_Add.UseVisualStyleBackColor = true;
            this.btn_Display_Add.Click += new System.EventHandler(this.btn_Display_Add_Click);
            // 
            // btn_Display_Delete
            // 
            this.btn_Display_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Display_Delete.Location = new System.Drawing.Point(862, 480);
            this.btn_Display_Delete.Name = "btn_Display_Delete";
            this.btn_Display_Delete.Size = new System.Drawing.Size(140, 65);
            this.btn_Display_Delete.TabIndex = 4;
            this.btn_Display_Delete.Text = "Delete";
            this.btn_Display_Delete.UseVisualStyleBackColor = true;
            this.btn_Display_Delete.Click += new System.EventHandler(this.btn_Display_Del_Click);
            // 
            // pnl_Test
            // 
            this.pnl_Test.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Test.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnl_Test.Controls.Add(this.tab_Client);
            this.pnl_Test.Location = new System.Drawing.Point(3, 3);
            this.pnl_Test.Name = "pnl_Test";
            this.pnl_Test.Size = new System.Drawing.Size(853, 587);
            this.pnl_Test.TabIndex = 1;
            // 
            // uc_Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnl_Test);
            this.Controls.Add(this.btn_Display_Edit);
            this.Controls.Add(this.btn_Display_Add);
            this.Controls.Add(this.btn_Display_Delete);
            this.Name = "uc_Clients";
            this.Size = new System.Drawing.Size(1037, 620);
            this.Load += new System.EventHandler(this.uc_Clients_Load);
            this.tab_Client.ResumeLayout(false);
            this.tp_Client.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clients)).EndInit();
            this.tp_AddClient.ResumeLayout(false);
            this.pnl_Addclient.ResumeLayout(false);
            this.pnl_Addclient.PerformLayout();
            this.tp_EditClient.ResumeLayout(false);
            this.pnl_Editclient.ResumeLayout(false);
            this.pnl_Editclient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnl_Test.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Client;
        private System.Windows.Forms.TabPage tp_Client;
        private System.Windows.Forms.DataGridView dgv_Clients;
        private System.Windows.Forms.TabPage tp_AddClient;
        private System.Windows.Forms.Panel pnl_Addclient;
        private System.Windows.Forms.ComboBox cmb_Title;
        private System.Windows.Forms.TextBox txt_Forename;
        private System.Windows.Forms.Button btn_AddClient;
        private System.Windows.Forms.CheckBox chk_Skin;
        private System.Windows.Forms.Label lbl_ClientNo;
        private System.Windows.Forms.RichTextBox richTxt_Street;
        private System.Windows.Forms.Label lbl_ClientNoText;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_forename;
        private System.Windows.Forms.TextBox txt_Telephone;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.TextBox txt_Country;
        private System.Windows.Forms.Label lbl_Street;
        private System.Windows.Forms.TextBox txt_Postcode;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txt_County;
        private System.Windows.Forms.Label lbl_Town;
        private System.Windows.Forms.TextBox txt_Town;
        private System.Windows.Forms.Label lbl_County;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.Label lbl_Postcode;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_TelNo;
        private System.Windows.Forms.Label lbl_SkinTest;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TabPage tp_EditClient;
        private System.Windows.Forms.Panel pnl_Editclient;
        private System.Windows.Forms.ComboBox cmb_Title_Edit;
        private System.Windows.Forms.TextBox txt_Forename_Edit;
        private System.Windows.Forms.Button btn_EditClient;
        private System.Windows.Forms.CheckBox chk_Skin_Edit;
        private System.Windows.Forms.Label lbl_ClientNo_Edit;
        private System.Windows.Forms.RichTextBox rt_Street_Edit;
        private System.Windows.Forms.Label lbl_ClientNo_EditText;
        private System.Windows.Forms.TextBox txt_Email_Edit;
        private System.Windows.Forms.Label lbl_Forename_Edit;
        private System.Windows.Forms.TextBox txt_TelNo_Edit;
        private System.Windows.Forms.Label lbl_Surname_Edit;
        private System.Windows.Forms.TextBox txt_Country_Edit;
        private System.Windows.Forms.Label lbl_Street_Edit;
        private System.Windows.Forms.TextBox txt_Postcode_Edit;
        private System.Windows.Forms.Label lbl_Title_Edit;
        private System.Windows.Forms.TextBox txt_County_Edit;
        private System.Windows.Forms.Label lbl_Town_Edit;
        private System.Windows.Forms.TextBox txt_Town_Edit;
        private System.Windows.Forms.Label lbl_County_Edit;
        private System.Windows.Forms.TextBox txt_Surname_Edit;
        private System.Windows.Forms.Label lbl_Postcode_Edit;
        private System.Windows.Forms.Label lbl_Country_Edit;
        private System.Windows.Forms.Label lbl_TelNo_Edit;
        private System.Windows.Forms.Label lbl_Skin_Edit;
        private System.Windows.Forms.Label lbl_Email_Edit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_Display_Edit;
        private System.Windows.Forms.Button btn_Display_Add;
        private System.Windows.Forms.Button btn_Display_Delete;
        private System.Windows.Forms.Panel pnl_Test;
    }
}
