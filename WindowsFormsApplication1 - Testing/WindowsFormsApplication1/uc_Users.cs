using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HairBeautyNWRC
{
    public partial class uc_Users : UserControl
    {
        SqlDataAdapter daUser;
        DataSet dsNWRC_HairBeauty = new DataSet();
        SqlCommandBuilder cmdBUser;
        DataRow drUser;
        String connStr, sqlUser;
        int selectedTab = 0;
        bool userSelected = false;
        int userNoselected = 0;
        private System.Windows.Forms.ErrorProvider errP;

        public uc_Users()
        {
            InitializeComponent();
        }
        private void uc_Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nWRC_HairBeautyDataSet.Client' table. You can move, or remove it, as needed.
            //  this.clientTableAdapter.Fill(this.nWRC_HairBeautyDataSet.Client);

            errP = new ErrorProvider();

            connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";
            //connStr = @"Data Source = .; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";

            sqlUser = @"SELECT * from UserLogin";
            daUser = new SqlDataAdapter(sqlUser, connStr);
            cmdBUser = new SqlCommandBuilder(daUser);
            daUser.FillSchema(dsNWRC_HairBeauty, SchemaType.Source, "UserLogin");
            daUser.Fill(dsNWRC_HairBeauty, "UserLogin");
            dgv_Users.DataSource = dsNWRC_HairBeauty.Tables["UserLogin"];

            //// Resize the DatagridView columns to fit the newly loaded content
            dgv_Users.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            tab_User.TabPages[0].CausesValidation = true;
            tab_User.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tab_User.TabPages[2].CausesValidation = true;
            tab_User.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);

            tab_User.SelectedIndex = 1;
            tab_User.SelectedIndex = 0;

            // Set Font Size 
            dgv_Users.Font = new Font("Times", 10);

            // Keep certian Columns a set size
           /* dgv_Users.Columns[0].Width = 75;
            dgv_Users.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv_Users.Columns[1].Width = 40;
            dgv_Users.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv_Users.Columns[7].Width = 70;
            dgv_Users.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv_Users.Columns[11].Width = 60;
            dgv_Users.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;*/

            //Fill Columns to panel view
            dgv_Users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            pnl_AddUser.Width = (frm_Home.screenWidth/2);
            pnl_AddUser.Height = (frm_Home.screenHeight / 2);
            pnl_AddUser.Location = new Point((frm_Home.screenWidth/2)-(pnl_AddUser.Width/2), tp_AddUser.Height/2);
        }
        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            MyUser myUser = new MyUser();
            bool ok = true;
            errP.Clear();

            try
            {
                myUser.UserID = Convert.ToInt32(lbl_UserNoText.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lbl_UserNoText, MyEx.tostring());
            }

            try
            {
                myUser.Username = txt_Username.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txt_Username, MyEx.tostring());
            }

            try
            {
                myUser.UserForename = txt_UserForename.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txt_UserForename, MyEx.tostring());
            }

            try
            {
                myUser.UserSurname = txt_UserSurname.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txt_UserSurname, MyEx.tostring());
            }

            try
            {
               myUser.UserLevel = txt_UserLevel.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txt_UserLevel, MyEx.tostring());
            }

            try
            {
                myUser.UserPassword = txt_UserPass.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txt_UserPass, MyEx.tostring());
            }
            
            try
            {
                myUser.UserEmail = txt_UserEmail.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txt_UserEmail, MyEx.tostring());
            }

            try
            {
                if (chk_Super.Checked)
                {
                    myUser.Super = "Y";
                }
                else
                {
                    myUser.Super = "N";
                }
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(chk_Super, MyEx.tostring());
            }

            try
            {
                if (ok)
                {
                    drUser = dsNWRC_HairBeauty.Tables["UserLogin"].NewRow();
                    drUser["UserID"] = myUser.UserID;
                    drUser["Username"] = myUser.Username;
                    drUser["UserSurname"] = myUser.UserSurname;
                    drUser["UserForename"] = myUser.UserForename;
                    drUser["UserEmail"] = myUser.UserEmail;
                    drUser["UserLevel"] = myUser.UserLevel;
                    drUser["Passkey"] = myUser.UserPassword;
                    drUser["Super"] = myUser.Super;
                    

                    dsNWRC_HairBeauty.Tables["UserLogin"].Rows.Add(drUser);
                    daUser.Update(dsNWRC_HairBeauty, "UserLogin");

                    MessageBox.Show("New User " + lbl_UserNoText.Text + " added !!!");

                    if (MessageBox.Show("Do you wish to add another User?", "Add User", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber(dsNWRC_HairBeauty.Tables["UserLogin"].Rows.Count);
                    }
                    else
                    {
                        tab_User.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }
        void clearAddForm()
        {
           
            txt_Username.Clear();
            txt_UserForename.Clear();
            txt_UserSurname.Clear();
            txt_UserEmail.Clear();
            txt_UserLevel.Text = "Limited";
            txt_UserPass.Clear();
            chk_Super.Checked = false;
        }
        private void getNumber(int noRows)
        {
            drUser = dsNWRC_HairBeauty.Tables["UserLogin"].Rows[noRows - 1];
            lbl_UserNoText.Text = (int.Parse(drUser["UserID"].ToString()) + 1).ToString();
        }

        private void tab_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tab_User.SelectedIndex;

            tab_User.TabPages[tab_User.SelectedIndex].Focus();
            tab_User.TabPages[tab_User.SelectedIndex].CausesValidation = true;

            switch (tab_User.SelectedIndex)
            {
                case 0: // View Client Tab
                    {
                        dsNWRC_HairBeauty.Tables["UserLogin"].Clear();
                        daUser.Fill(dsNWRC_HairBeauty, "UserLogin");
                        break;
                    }
                case 1:     // Add Client Tab
                    {
                        int noRows = dsNWRC_HairBeauty.Tables["UserLogin"].Rows.Count;
                        if (noRows == 0)
                            lbl_UserNoText.Text = "10000";
                        else
                        {
                            getNumber(noRows);
                        }
                        errP.Clear();
                        clearAddForm();
                        break;
                    }
            }
        }

        private void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgv_Users.SelectedRows.Count == 0)
            {
                userSelected = false;
                userNoselected = 0;
            }
            else if (dgv_Users.SelectedRows.Count == 1)
            {
                userSelected = true;
                userNoselected = Convert.ToInt32(dgv_Users.SelectedRows[0].Cells[0].Value);
            }
        }

        private void chk_Super_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Super.Checked == true)
                txt_UserLevel.Text = "Full";
            else
                txt_UserLevel.Text = "Limited";
        }

        private void EditTabValidate(object sender, CancelEventArgs e)
        {
            if (userSelected == false && userNoselected == 0)
            {

                // Reset Tab to main and show message to select customer
            }
            else if (dgv_Users.SelectedRows.Count == 1)
            {
                userSelected = true;
                userNoselected = Convert.ToInt32(dgv_Users.SelectedRows[0].Cells[0].Value);
            }
        }
    }
}
