namespace HairBeautyNWRC
{
    partial class uc_Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Users));
            this.tab_User = new System.Windows.Forms.TabControl();
            this.tp_User = new System.Windows.Forms.TabPage();
            this.dgv_Users = new System.Windows.Forms.DataGridView();
            this.tp_AddUser = new System.Windows.Forms.TabPage();
            this.pnl_AddUser = new System.Windows.Forms.Panel();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.txt_UserForename = new System.Windows.Forms.TextBox();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.chk_Super = new System.Windows.Forms.CheckBox();
            this.lbl_UserNo = new System.Windows.Forms.Label();
            this.lbl_UserNoText = new System.Windows.Forms.Label();
            this.txt_UserEmail = new System.Windows.Forms.TextBox();
            this.lbl_UserForename = new System.Windows.Forms.Label();
            this.lbl_UserSurname = new System.Windows.Forms.Label();
            this.txt_UserPass = new System.Windows.Forms.TextBox();
            this.txt_UserLevel = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_UserLevel = new System.Windows.Forms.Label();
            this.txt_UserSurname = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Super = new System.Windows.Forms.Label();
            this.lbl_UserEmail = new System.Windows.Forms.Label();
            this.tp_EditUser = new System.Windows.Forms.TabPage();
            this.pnl_EditUser = new System.Windows.Forms.Panel();
            this.pic_EditUser = new System.Windows.Forms.PictureBox();
            this.txt_EditForname = new System.Windows.Forms.TextBox();
            this.btn_EditUser = new System.Windows.Forms.Button();
            this.chk_EditSuper = new System.Windows.Forms.CheckBox();
            this.lbl_UserEdit = new System.Windows.Forms.Label();
            this.lbl_EditUserNoText = new System.Windows.Forms.Label();
            this.txt_EditEmail = new System.Windows.Forms.TextBox();
            this.lbl_EditForename = new System.Windows.Forms.Label();
            this.lbl_EditSurname = new System.Windows.Forms.Label();
            this.txt_EditPassword = new System.Windows.Forms.TextBox();
            this.txt_EditLEvel = new System.Windows.Forms.TextBox();
            this.lbl_UsernameEdit = new System.Windows.Forms.Label();
            this.txt_EditUsername = new System.Windows.Forms.TextBox();
            this.lbl_EditLevel = new System.Windows.Forms.Label();
            this.txt_EditSurname = new System.Windows.Forms.TextBox();
            this.lbl_EditPassword = new System.Windows.Forms.Label();
            this.lbl_EditSuper = new System.Windows.Forms.Label();
            this.lbl_EditEmail = new System.Windows.Forms.Label();
            this.tab_User.SuspendLayout();
            this.tp_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
            this.tp_AddUser.SuspendLayout();
            this.pnl_AddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.tp_EditUser.SuspendLayout();
            this.pnl_EditUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EditUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_User
            // 
            this.tab_User.Controls.Add(this.tp_User);
            this.tab_User.Controls.Add(this.tp_AddUser);
            this.tab_User.Controls.Add(this.tp_EditUser);
            this.tab_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_User.Location = new System.Drawing.Point(0, 0);
            this.tab_User.Name = "tab_User";
            this.tab_User.SelectedIndex = 0;
            this.tab_User.Size = new System.Drawing.Size(853, 560);
            this.tab_User.TabIndex = 4;
            this.tab_User.Tag = "";
            this.tab_User.SelectedIndexChanged += new System.EventHandler(this.tab_User_SelectedIndexChanged);
            // 
            // tp_User
            // 
            this.tp_User.BackColor = System.Drawing.Color.DarkGray;
            this.tp_User.Controls.Add(this.dgv_Users);
            this.tp_User.Location = new System.Drawing.Point(4, 22);
            this.tp_User.Name = "tp_User";
            this.tp_User.Padding = new System.Windows.Forms.Padding(3);
            this.tp_User.Size = new System.Drawing.Size(845, 534);
            this.tp_User.TabIndex = 0;
            this.tp_User.Text = "User List";
            // 
            // dgv_Users
            // 
            this.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Users.Location = new System.Drawing.Point(3, 3);
            this.dgv_Users.Name = "dgv_Users";
            this.dgv_Users.RowTemplate.Height = 40;
            this.dgv_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Users.Size = new System.Drawing.Size(839, 528);
            this.dgv_Users.TabIndex = 0;
            // 
            // tp_AddUser
            // 
            this.tp_AddUser.BackColor = System.Drawing.Color.PaleVioletRed;
            this.tp_AddUser.Controls.Add(this.pnl_AddUser);
            this.tp_AddUser.Location = new System.Drawing.Point(4, 22);
            this.tp_AddUser.Name = "tp_AddUser";
            this.tp_AddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tp_AddUser.Size = new System.Drawing.Size(845, 534);
            this.tp_AddUser.TabIndex = 1;
            this.tp_AddUser.Text = "Add User";
            // 
            // pnl_AddUser
            // 
            this.pnl_AddUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_AddUser.Controls.Add(this.picUser);
            this.pnl_AddUser.Controls.Add(this.txt_UserForename);
            this.pnl_AddUser.Controls.Add(this.btn_AddUser);
            this.pnl_AddUser.Controls.Add(this.chk_Super);
            this.pnl_AddUser.Controls.Add(this.lbl_UserNo);
            this.pnl_AddUser.Controls.Add(this.lbl_UserNoText);
            this.pnl_AddUser.Controls.Add(this.txt_UserEmail);
            this.pnl_AddUser.Controls.Add(this.lbl_UserForename);
            this.pnl_AddUser.Controls.Add(this.lbl_UserSurname);
            this.pnl_AddUser.Controls.Add(this.txt_UserPass);
            this.pnl_AddUser.Controls.Add(this.txt_UserLevel);
            this.pnl_AddUser.Controls.Add(this.lbl_Username);
            this.pnl_AddUser.Controls.Add(this.txt_Username);
            this.pnl_AddUser.Controls.Add(this.lbl_UserLevel);
            this.pnl_AddUser.Controls.Add(this.txt_UserSurname);
            this.pnl_AddUser.Controls.Add(this.lbl_Password);
            this.pnl_AddUser.Controls.Add(this.lbl_Super);
            this.pnl_AddUser.Controls.Add(this.lbl_UserEmail);
            this.pnl_AddUser.Location = new System.Drawing.Point(22, 22);
            this.pnl_AddUser.Name = "pnl_AddUser";
            this.pnl_AddUser.Size = new System.Drawing.Size(801, 489);
            this.pnl_AddUser.TabIndex = 25;
            // 
            // picUser
            // 
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(535, 43);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(205, 203);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 25;
            this.picUser.TabStop = false;
            // 
            // txt_UserForename
            // 
            this.txt_UserForename.BackColor = System.Drawing.Color.MistyRose;
            this.txt_UserForename.Location = new System.Drawing.Point(210, 202);
            this.txt_UserForename.Name = "txt_UserForename";
            this.txt_UserForename.Size = new System.Drawing.Size(192, 20);
            this.txt_UserForename.TabIndex = 15;
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.BackColor = System.Drawing.Color.Plum;
            this.btn_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddUser.Location = new System.Drawing.Point(561, 362);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(153, 64);
            this.btn_AddUser.TabIndex = 0;
            this.btn_AddUser.Text = "Add New User";
            this.btn_AddUser.UseVisualStyleBackColor = false;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // chk_Super
            // 
            this.chk_Super.AutoSize = true;
            this.chk_Super.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chk_Super.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Super.Location = new System.Drawing.Point(210, 385);
            this.chk_Super.Name = "chk_Super";
            this.chk_Super.Size = new System.Drawing.Size(54, 21);
            this.chk_Super.TabIndex = 24;
            this.chk_Super.Text = "Yes";
            this.chk_Super.UseVisualStyleBackColor = false;
            this.chk_Super.CheckedChanged += new System.EventHandler(this.chk_Super_CheckedChanged);
            // 
            // lbl_UserNo
            // 
            this.lbl_UserNo.AutoSize = true;
            this.lbl_UserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserNo.Location = new System.Drawing.Point(52, 123);
            this.lbl_UserNo.Name = "lbl_UserNo";
            this.lbl_UserNo.Size = new System.Drawing.Size(115, 18);
            this.lbl_UserNo.TabIndex = 1;
            this.lbl_UserNo.Text = "User number: ";
            // 
            // lbl_UserNoText
            // 
            this.lbl_UserNoText.AutoSize = true;
            this.lbl_UserNoText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_UserNoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserNoText.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbl_UserNoText.Location = new System.Drawing.Point(214, 127);
            this.lbl_UserNoText.Name = "lbl_UserNoText";
            this.lbl_UserNoText.Size = new System.Drawing.Size(48, 16);
            this.lbl_UserNoText.TabIndex = 2;
            this.lbl_UserNoText.Text = "********";
            // 
            // txt_UserEmail
            // 
            this.txt_UserEmail.BackColor = System.Drawing.Color.MistyRose;
            this.txt_UserEmail.Location = new System.Drawing.Point(210, 277);
            this.txt_UserEmail.Name = "txt_UserEmail";
            this.txt_UserEmail.Size = new System.Drawing.Size(192, 20);
            this.txt_UserEmail.TabIndex = 22;
            // 
            // lbl_UserForename
            // 
            this.lbl_UserForename.AutoSize = true;
            this.lbl_UserForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserForename.Location = new System.Drawing.Point(42, 202);
            this.lbl_UserForename.Name = "lbl_UserForename";
            this.lbl_UserForename.Size = new System.Drawing.Size(125, 18);
            this.lbl_UserForename.TabIndex = 3;
            this.lbl_UserForename.Text = "User Forename";
            // 
            // lbl_UserSurname
            // 
            this.lbl_UserSurname.AutoSize = true;
            this.lbl_UserSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserSurname.Location = new System.Drawing.Point(51, 242);
            this.lbl_UserSurname.Name = "lbl_UserSurname";
            this.lbl_UserSurname.Size = new System.Drawing.Size(116, 18);
            this.lbl_UserSurname.TabIndex = 4;
            this.lbl_UserSurname.Text = "User Surname";
            // 
            // txt_UserPass
            // 
            this.txt_UserPass.BackColor = System.Drawing.Color.MistyRose;
            this.txt_UserPass.Location = new System.Drawing.Point(210, 348);
            this.txt_UserPass.Name = "txt_UserPass";
            this.txt_UserPass.Size = new System.Drawing.Size(116, 20);
            this.txt_UserPass.TabIndex = 19;
            // 
            // txt_UserLevel
            // 
            this.txt_UserLevel.BackColor = System.Drawing.Color.MistyRose;
            this.txt_UserLevel.Enabled = false;
            this.txt_UserLevel.Location = new System.Drawing.Point(210, 313);
            this.txt_UserLevel.Name = "txt_UserLevel";
            this.txt_UserLevel.Size = new System.Drawing.Size(80, 20);
            this.txt_UserLevel.TabIndex = 18;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(82, 167);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(85, 18);
            this.lbl_Username.TabIndex = 7;
            this.lbl_Username.Text = "Username";
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.MistyRose;
            this.txt_Username.Location = new System.Drawing.Point(210, 167);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(192, 20);
            this.txt_Username.TabIndex = 17;
            // 
            // lbl_UserLevel
            // 
            this.lbl_UserLevel.AutoSize = true;
            this.lbl_UserLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserLevel.Location = new System.Drawing.Point(79, 312);
            this.lbl_UserLevel.Name = "lbl_UserLevel";
            this.lbl_UserLevel.Size = new System.Drawing.Size(88, 18);
            this.lbl_UserLevel.TabIndex = 8;
            this.lbl_UserLevel.Text = "User Level";
            // 
            // txt_UserSurname
            // 
            this.txt_UserSurname.BackColor = System.Drawing.Color.MistyRose;
            this.txt_UserSurname.Location = new System.Drawing.Point(210, 242);
            this.txt_UserSurname.Name = "txt_UserSurname";
            this.txt_UserSurname.Size = new System.Drawing.Size(192, 20);
            this.txt_UserSurname.TabIndex = 16;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(84, 349);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(83, 18);
            this.lbl_Password.TabIndex = 9;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Super
            // 
            this.lbl_Super.AutoSize = true;
            this.lbl_Super.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Super.Location = new System.Drawing.Point(74, 384);
            this.lbl_Super.Name = "lbl_Super";
            this.lbl_Super.Size = new System.Drawing.Size(93, 18);
            this.lbl_Super.TabIndex = 13;
            this.lbl_Super.Text = "Super User";
            // 
            // lbl_UserEmail
            // 
            this.lbl_UserEmail.AutoSize = true;
            this.lbl_UserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserEmail.Location = new System.Drawing.Point(76, 279);
            this.lbl_UserEmail.Name = "lbl_UserEmail";
            this.lbl_UserEmail.Size = new System.Drawing.Size(91, 18);
            this.lbl_UserEmail.TabIndex = 12;
            this.lbl_UserEmail.Text = "User Email";
            // 
            // tp_EditUser
            // 
            this.tp_EditUser.BackColor = System.Drawing.Color.LightBlue;
            this.tp_EditUser.Controls.Add(this.pnl_EditUser);
            this.tp_EditUser.Location = new System.Drawing.Point(4, 22);
            this.tp_EditUser.Name = "tp_EditUser";
            this.tp_EditUser.Padding = new System.Windows.Forms.Padding(3);
            this.tp_EditUser.Size = new System.Drawing.Size(845, 534);
            this.tp_EditUser.TabIndex = 2;
            this.tp_EditUser.Text = "Edit User";
            // 
            // pnl_EditUser
            // 
            this.pnl_EditUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_EditUser.Controls.Add(this.pic_EditUser);
            this.pnl_EditUser.Controls.Add(this.txt_EditForname);
            this.pnl_EditUser.Controls.Add(this.btn_EditUser);
            this.pnl_EditUser.Controls.Add(this.chk_EditSuper);
            this.pnl_EditUser.Controls.Add(this.lbl_UserEdit);
            this.pnl_EditUser.Controls.Add(this.lbl_EditUserNoText);
            this.pnl_EditUser.Controls.Add(this.txt_EditEmail);
            this.pnl_EditUser.Controls.Add(this.lbl_EditForename);
            this.pnl_EditUser.Controls.Add(this.lbl_EditSurname);
            this.pnl_EditUser.Controls.Add(this.txt_EditPassword);
            this.pnl_EditUser.Controls.Add(this.txt_EditLEvel);
            this.pnl_EditUser.Controls.Add(this.lbl_UsernameEdit);
            this.pnl_EditUser.Controls.Add(this.txt_EditUsername);
            this.pnl_EditUser.Controls.Add(this.lbl_EditLevel);
            this.pnl_EditUser.Controls.Add(this.txt_EditSurname);
            this.pnl_EditUser.Controls.Add(this.lbl_EditPassword);
            this.pnl_EditUser.Controls.Add(this.lbl_EditSuper);
            this.pnl_EditUser.Controls.Add(this.lbl_EditEmail);
            this.pnl_EditUser.Location = new System.Drawing.Point(28, 23);
            this.pnl_EditUser.Name = "pnl_EditUser";
            this.pnl_EditUser.Size = new System.Drawing.Size(801, 489);
            this.pnl_EditUser.TabIndex = 26;
            // 
            // pic_EditUser
            // 
            this.pic_EditUser.Image = ((System.Drawing.Image)(resources.GetObject("pic_EditUser.Image")));
            this.pic_EditUser.Location = new System.Drawing.Point(525, 43);
            this.pic_EditUser.Name = "pic_EditUser";
            this.pic_EditUser.Size = new System.Drawing.Size(205, 200);
            this.pic_EditUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_EditUser.TabIndex = 25;
            this.pic_EditUser.TabStop = false;
            // 
            // txt_EditForname
            // 
            this.txt_EditForname.BackColor = System.Drawing.Color.Lavender;
            this.txt_EditForname.Location = new System.Drawing.Point(202, 202);
            this.txt_EditForname.Name = "txt_EditForname";
            this.txt_EditForname.Size = new System.Drawing.Size(192, 20);
            this.txt_EditForname.TabIndex = 15;
            // 
            // btn_EditUser
            // 
            this.btn_EditUser.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_EditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditUser.Location = new System.Drawing.Point(558, 362);
            this.btn_EditUser.Name = "btn_EditUser";
            this.btn_EditUser.Size = new System.Drawing.Size(153, 64);
            this.btn_EditUser.TabIndex = 0;
            this.btn_EditUser.Text = "Edit User";
            this.btn_EditUser.UseVisualStyleBackColor = false;
            // 
            // chk_EditSuper
            // 
            this.chk_EditSuper.AutoSize = true;
            this.chk_EditSuper.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chk_EditSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_EditSuper.Location = new System.Drawing.Point(202, 385);
            this.chk_EditSuper.Name = "chk_EditSuper";
            this.chk_EditSuper.Size = new System.Drawing.Size(54, 21);
            this.chk_EditSuper.TabIndex = 24;
            this.chk_EditSuper.Text = "Yes";
            this.chk_EditSuper.UseVisualStyleBackColor = false;
            // 
            // lbl_UserEdit
            // 
            this.lbl_UserEdit.AutoSize = true;
            this.lbl_UserEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserEdit.Location = new System.Drawing.Point(52, 124);
            this.lbl_UserEdit.Name = "lbl_UserEdit";
            this.lbl_UserEdit.Size = new System.Drawing.Size(115, 18);
            this.lbl_UserEdit.TabIndex = 1;
            this.lbl_UserEdit.Text = "User number: ";
            // 
            // lbl_EditUserNoText
            // 
            this.lbl_EditUserNoText.AutoSize = true;
            this.lbl_EditUserNoText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_EditUserNoText.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbl_EditUserNoText.Location = new System.Drawing.Point(206, 129);
            this.lbl_EditUserNoText.Name = "lbl_EditUserNoText";
            this.lbl_EditUserNoText.Size = new System.Drawing.Size(0, 13);
            this.lbl_EditUserNoText.TabIndex = 2;
            // 
            // txt_EditEmail
            // 
            this.txt_EditEmail.BackColor = System.Drawing.Color.Lavender;
            this.txt_EditEmail.Location = new System.Drawing.Point(202, 277);
            this.txt_EditEmail.Name = "txt_EditEmail";
            this.txt_EditEmail.Size = new System.Drawing.Size(192, 20);
            this.txt_EditEmail.TabIndex = 22;
            // 
            // lbl_EditForename
            // 
            this.lbl_EditForename.AutoSize = true;
            this.lbl_EditForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EditForename.Location = new System.Drawing.Point(42, 202);
            this.lbl_EditForename.Name = "lbl_EditForename";
            this.lbl_EditForename.Size = new System.Drawing.Size(125, 18);
            this.lbl_EditForename.TabIndex = 3;
            this.lbl_EditForename.Text = "User Forename";
            // 
            // lbl_EditSurname
            // 
            this.lbl_EditSurname.AutoSize = true;
            this.lbl_EditSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EditSurname.Location = new System.Drawing.Point(51, 242);
            this.lbl_EditSurname.Name = "lbl_EditSurname";
            this.lbl_EditSurname.Size = new System.Drawing.Size(116, 18);
            this.lbl_EditSurname.TabIndex = 4;
            this.lbl_EditSurname.Text = "User Surname";
            // 
            // txt_EditPassword
            // 
            this.txt_EditPassword.BackColor = System.Drawing.Color.Lavender;
            this.txt_EditPassword.Location = new System.Drawing.Point(202, 348);
            this.txt_EditPassword.Name = "txt_EditPassword";
            this.txt_EditPassword.Size = new System.Drawing.Size(116, 20);
            this.txt_EditPassword.TabIndex = 19;
            // 
            // txt_EditLEvel
            // 
            this.txt_EditLEvel.BackColor = System.Drawing.Color.Lavender;
            this.txt_EditLEvel.Enabled = false;
            this.txt_EditLEvel.Location = new System.Drawing.Point(202, 313);
            this.txt_EditLEvel.Name = "txt_EditLEvel";
            this.txt_EditLEvel.Size = new System.Drawing.Size(80, 20);
            this.txt_EditLEvel.TabIndex = 18;
            // 
            // lbl_UsernameEdit
            // 
            this.lbl_UsernameEdit.AutoSize = true;
            this.lbl_UsernameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UsernameEdit.Location = new System.Drawing.Point(82, 167);
            this.lbl_UsernameEdit.Name = "lbl_UsernameEdit";
            this.lbl_UsernameEdit.Size = new System.Drawing.Size(85, 18);
            this.lbl_UsernameEdit.TabIndex = 7;
            this.lbl_UsernameEdit.Text = "Username";
            // 
            // txt_EditUsername
            // 
            this.txt_EditUsername.BackColor = System.Drawing.Color.Lavender;
            this.txt_EditUsername.Location = new System.Drawing.Point(202, 167);
            this.txt_EditUsername.Name = "txt_EditUsername";
            this.txt_EditUsername.Size = new System.Drawing.Size(192, 20);
            this.txt_EditUsername.TabIndex = 17;
            // 
            // lbl_EditLevel
            // 
            this.lbl_EditLevel.AutoSize = true;
            this.lbl_EditLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EditLevel.Location = new System.Drawing.Point(79, 312);
            this.lbl_EditLevel.Name = "lbl_EditLevel";
            this.lbl_EditLevel.Size = new System.Drawing.Size(88, 18);
            this.lbl_EditLevel.TabIndex = 8;
            this.lbl_EditLevel.Text = "User Level";
            // 
            // txt_EditSurname
            // 
            this.txt_EditSurname.BackColor = System.Drawing.Color.Lavender;
            this.txt_EditSurname.Location = new System.Drawing.Point(202, 242);
            this.txt_EditSurname.Name = "txt_EditSurname";
            this.txt_EditSurname.Size = new System.Drawing.Size(192, 20);
            this.txt_EditSurname.TabIndex = 16;
            // 
            // lbl_EditPassword
            // 
            this.lbl_EditPassword.AutoSize = true;
            this.lbl_EditPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EditPassword.Location = new System.Drawing.Point(84, 349);
            this.lbl_EditPassword.Name = "lbl_EditPassword";
            this.lbl_EditPassword.Size = new System.Drawing.Size(83, 18);
            this.lbl_EditPassword.TabIndex = 9;
            this.lbl_EditPassword.Text = "Password";
            // 
            // lbl_EditSuper
            // 
            this.lbl_EditSuper.AutoSize = true;
            this.lbl_EditSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EditSuper.Location = new System.Drawing.Point(74, 384);
            this.lbl_EditSuper.Name = "lbl_EditSuper";
            this.lbl_EditSuper.Size = new System.Drawing.Size(93, 18);
            this.lbl_EditSuper.TabIndex = 13;
            this.lbl_EditSuper.Text = "Super User";
            // 
            // lbl_EditEmail
            // 
            this.lbl_EditEmail.AutoSize = true;
            this.lbl_EditEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EditEmail.Location = new System.Drawing.Point(76, 279);
            this.lbl_EditEmail.Name = "lbl_EditEmail";
            this.lbl_EditEmail.Size = new System.Drawing.Size(91, 18);
            this.lbl_EditEmail.TabIndex = 12;
            this.lbl_EditEmail.Text = "User Email";
            // 
            // uc_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.tab_User);
            this.Name = "uc_Users";
            this.Size = new System.Drawing.Size(853, 560);
            this.Load += new System.EventHandler(this.uc_Users_Load);
            this.tab_User.ResumeLayout(false);
            this.tp_User.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            this.tp_AddUser.ResumeLayout(false);
            this.pnl_AddUser.ResumeLayout(false);
            this.pnl_AddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.tp_EditUser.ResumeLayout(false);
            this.pnl_EditUser.ResumeLayout(false);
            this.pnl_EditUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EditUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_User;
        private System.Windows.Forms.TabPage tp_User;
        private System.Windows.Forms.DataGridView dgv_Users;
        private System.Windows.Forms.TabPage tp_AddUser;
        private System.Windows.Forms.Panel pnl_AddUser;
        private System.Windows.Forms.TextBox txt_UserForename;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.Label lbl_UserNo;
        private System.Windows.Forms.Label lbl_UserNoText;
        private System.Windows.Forms.TextBox txt_UserEmail;
        private System.Windows.Forms.Label lbl_UserForename;
        private System.Windows.Forms.Label lbl_UserSurname;
        private System.Windows.Forms.TextBox txt_UserPass;
        private System.Windows.Forms.TextBox txt_UserLevel;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_UserLevel;
        private System.Windows.Forms.TextBox txt_UserSurname;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_UserEmail;
        private System.Windows.Forms.TabPage tp_EditUser;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.CheckBox chk_Super;
        private System.Windows.Forms.Label lbl_Super;
        private System.Windows.Forms.Panel pnl_EditUser;
        private System.Windows.Forms.PictureBox pic_EditUser;
        private System.Windows.Forms.TextBox txt_EditForname;
        private System.Windows.Forms.Button btn_EditUser;
        private System.Windows.Forms.CheckBox chk_EditSuper;
        private System.Windows.Forms.Label lbl_UserEdit;
        private System.Windows.Forms.Label lbl_EditUserNoText;
        private System.Windows.Forms.TextBox txt_EditEmail;
        private System.Windows.Forms.Label lbl_EditForename;
        private System.Windows.Forms.Label lbl_EditSurname;
        private System.Windows.Forms.TextBox txt_EditPassword;
        private System.Windows.Forms.TextBox txt_EditLEvel;
        private System.Windows.Forms.Label lbl_UsernameEdit;
        private System.Windows.Forms.TextBox txt_EditUsername;
        private System.Windows.Forms.Label lbl_EditLevel;
        private System.Windows.Forms.TextBox txt_EditSurname;
        private System.Windows.Forms.Label lbl_EditPassword;
        private System.Windows.Forms.Label lbl_EditSuper;
        private System.Windows.Forms.Label lbl_EditEmail;
    }
}
