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
    public partial class uc_Clients : UserControl
    {
        
        SqlDataAdapter daClient;
        DataSet dsNWRC_HairBeauty = new DataSet();
        SqlCommandBuilder cmdBClient;
        DataRow drclient;
        String connStr, sqlClient;
        int selectedTab = 0;
        bool clientSelected = false;
        int clientNoselected = 0;
        private System.Windows.Forms.ErrorProvider errP;

        public uc_Clients()
        {
            InitializeComponent();
        }

        private void uc_Clients_Load(object sender, EventArgs e)
        {
   
            // TODO: This line of code loads data into the 'nWRC_HairBeautyDataSet.Client' table. You can move, or remove it, as needed.
            //  this.clientTableAdapter.Fill(this.nWRC_HairBeautyDataSet.Client);

            errP = new ErrorProvider();

            connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";
            //connStr = @"Data Source = .; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";

            sqlClient = @"SELECT * from Client";
            daClient = new SqlDataAdapter(sqlClient, connStr);
            cmdBClient = new SqlCommandBuilder(daClient);
            daClient.FillSchema(dsNWRC_HairBeauty, SchemaType.Source, "Client");
            daClient.Fill(dsNWRC_HairBeauty, "Client");
            dgv_Clients.DataSource = dsNWRC_HairBeauty.Tables["Client"];
            
            //// Resize the DatagridView columns to fit the newly loaded content
            dgv_Clients.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            tab_Client.TabPages[0].CausesValidation = true;
            tab_Client.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tab_Client.TabPages[2].CausesValidation = true;
            tab_Client.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);

            tab_Client.SelectedIndex = 1;
            tab_Client.SelectedIndex = 0;

            // Set Font Size 
            dgv_Clients.Font = new Font("Times", 10);

            // Keep certian Columns a set size
            dgv_Clients.Columns[0].Width = 75;
            dgv_Clients.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv_Clients.Columns[1].Width = 40;
            dgv_Clients.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv_Clients.Columns[7].Width = 70;
            dgv_Clients.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv_Clients.Columns[11].Width = 60;
            dgv_Clients.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            //Fill Columns to panel view
            dgv_Clients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btn_AddClient_Click(object sender, EventArgs e)
        {
            MyClient myClient = new MyClient();
            bool ok = true;
            errP.Clear();

            try
            {
                myClient.ClientNo = Convert.ToInt32(lbl_ClientNoText.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lbl_ClientNoText, MyEx.tostring());
            }

            try
            {
                myClient.Title = cmb_Title.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmb_Title, MyEx.tostring());
            }

            try
            {
                myClient.Surname = txt_Surname.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txt_Surname, MyEx.tostring());
            }

            try
            {
                myClient.Forename = txt_Forename.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txt_Forename, MyEx.tostring());
            }

            try
            {
                myClient.Street = richTxt_Street.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(richTxt_Street, MyEx.tostring());
            }

            try
            {
                myClient.Town = txt_Town.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txt_Town, MyEx.tostring());
            }

            try
            {
                myClient.County = txt_County.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txt_County, MyEx.tostring());
            }

            try
            {
                myClient.Postcode = txt_Postcode.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txt_Postcode, MyEx.tostring());
            }

            try
            {
                myClient.Country = txt_Country.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txt_Country, MyEx.tostring());
            }

            try
            {
                myClient.TelNo = txt_Telephone.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txt_Telephone, MyEx.tostring());
            }

            try
            {
                myClient.Email = txt_Email.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txt_Email, MyEx.tostring());
            }

            try
            {
                if (chk_Skin.Checked)
                {
                    myClient.SkinTest = "Yes";
                }
                else
                {
                    myClient.SkinTest = "No";
                }
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(chk_Skin, MyEx.tostring());
            }

            try
            {
                if (ok)
                {
                    drclient = dsNWRC_HairBeauty.Tables["Client"].NewRow();
                    drclient["ClientNo"] = myClient.ClientNo;
                    drclient["Title"] = myClient.Title;
                    drclient["Surname"] = myClient.Surname;
                    drclient["Forename"] = myClient.Forename;
                    drclient["Street"] = myClient.Street;
                    drclient["Town"] = myClient.Town;
                    drclient["County"] = myClient.County;
                    drclient["PostCode"] = myClient.Postcode;
                    drclient["Country"] = myClient.Country;
                    drclient["TelNo"] = myClient.TelNo;
                    drclient["Email"] = myClient.Email;
                    drclient["SkinTest"] = myClient.SkinTest;

                    dsNWRC_HairBeauty.Tables["Client"].Rows.Add(drclient);
                    daClient.Update(dsNWRC_HairBeauty, "Client");

                    MessageBox.Show("New Customer " + lbl_ClientNoText.Text + " added !!!");

                    if (MessageBox.Show("Do you wish to add another Client?", "Add Client", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber(dsNWRC_HairBeauty.Tables["Client"].Rows.Count);
                    }
                    else
                    {
                        tab_Client.SelectedIndex = 0;
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
            cmb_Title.SelectedIndex = -1;
            txt_Forename.Clear();
            txt_Surname.Clear();
            richTxt_Street.Clear();
            txt_Town.Clear();
            txt_County.Clear();
            txt_Postcode.Clear();
            txt_Country.Clear();
            txt_Telephone.Clear();
            txt_Email.Clear();
            chk_Skin.Checked = false;
        }

        private void getNumber(int noRows)
        {
            drclient = dsNWRC_HairBeauty.Tables["Client"].Rows[noRows - 1];
            lbl_ClientNoText.Text = (int.Parse(drclient["ClientNo"].ToString()) + 1).ToString();
        }

        private void tab_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tab_Client.SelectedIndex;

            tab_Client.TabPages[tab_Client.SelectedIndex].Focus();
            tab_Client.TabPages[tab_Client.SelectedIndex].CausesValidation = true;

            switch (tab_Client.SelectedIndex)
            {
                case 0: // View Client Tab
                    {
                        dsNWRC_HairBeauty.Tables["Client"].Clear();
                        daClient.Fill(dsNWRC_HairBeauty, "Client");
                        break;
                    }
                case 1:     // Add Client Tab
                    {
                        int noRows = dsNWRC_HairBeauty.Tables["Client"].Rows.Count;
                        if (noRows == 0)
                            lbl_ClientNoText.Text = "10000";
                        else
                        {
                            getNumber(noRows);
                        }
                        errP.Clear();
                        clearAddForm();
                        break;
                    }
                case 2:     // Edit Client Tab
                    {
                        if (clientNoselected == 0)
                        {
                            tab_Client.SelectedIndex = 0;
                            break;
                        }
                        else
                        {
                            lbl_ClientNo_EditText.Text = clientNoselected.ToString();

                            drclient = dsNWRC_HairBeauty.Tables["Client"].Rows.Find(lbl_ClientNo_EditText.Text);
                            if (drclient["Title"].ToString() == "Mr")
                                cmb_Title_Edit.SelectedIndex = 0;
                            if (drclient["Title"].ToString() == "Mrs")
                                cmb_Title_Edit.SelectedIndex = 1;
                            if (drclient["Title"].ToString() == "Miss")
                                cmb_Title_Edit.SelectedIndex = 2;
                            if (drclient["Title"].ToString() == "Ms")
                                cmb_Title_Edit.SelectedIndex = 3;
                            if (drclient["Title"].ToString() == "Dr")
                                cmb_Title_Edit.SelectedIndex = 4;

                            txt_Forename_Edit.Text = drclient["Forename"].ToString();
                            txt_Surname_Edit.Text = drclient["Surname"].ToString();
                            rt_Street_Edit.Text = drclient["Street"].ToString();
                            txt_Town_Edit.Text = drclient["Town"].ToString();
                            txt_County_Edit.Text = drclient["County"].ToString();
                            txt_Postcode_Edit.Text = drclient["Postcode"].ToString();
                            txt_Country_Edit.Text = drclient["Country"].ToString();
                            txt_TelNo_Edit.Text = drclient["TelNo"].ToString();
                            txt_Email_Edit.Text = drclient["Email"].ToString();

                            if (drclient["SkinTest"].ToString() == "YES")
                            {
                                chk_Skin_Edit.Checked = true;
                            }
                            else
                            {
                                chk_Skin_Edit.Checked = false;
                            }
                            break;
                        }

                    }
            }
        }

        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgv_Clients.SelectedRows.Count == 0)
            {
                clientSelected = false;
                clientNoselected = 0;
            }
            else if (dgv_Clients.SelectedRows.Count == 1)
            {
                clientSelected = true;
                clientNoselected = Convert.ToInt32(dgv_Clients.SelectedRows[0].Cells[0].Value);
            }
        }
        void EditTabValidate(object sender, CancelEventArgs e)
        {
            if (clientSelected == false && clientNoselected == 0)
            {

                // Reset Tab to main and show message to select customer
            }
            else if (dgv_Clients.SelectedRows.Count == 1)
            {
                clientSelected = true;
                clientNoselected = Convert.ToInt32(dgv_Clients.SelectedRows[0].Cells[0].Value);
            }
        }

        private void btn_EditClient_Click(object sender, EventArgs e)
        {
            if (btn_EditClient.Text == "Edit Client")
            {
                cmb_Title_Edit.Enabled = true;
                txt_Forename_Edit.Enabled = true;
                txt_Surname_Edit.Enabled = true;
                rt_Street_Edit.Enabled = true;
                txt_Town_Edit.Enabled = true;
                txt_County_Edit.Enabled = true;
                txt_Postcode_Edit.Enabled = true;
                txt_Country_Edit.Enabled = true;
                txt_TelNo_Edit.Enabled = true;
                txt_Email_Edit.Enabled = true;
                chk_Skin_Edit.Enabled = true;

                btn_EditClient.Text = "Save Client";
            }
            else
            {
                MyClient myClient = new MyClient();
                bool ok = true;
                errP.Clear();


                try
                {
                    myClient.ClientNo = Convert.ToInt32(lbl_ClientNo_EditText.Text.Trim());
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(lbl_ClientNo_EditText, MyEx.ToString());
                }
                try
                {
                    myClient.Title = cmb_Title_Edit.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(cmb_Title_Edit, MyEx.tostring());
                }

                try
                {
                    myClient.Surname = txt_Surname_Edit.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txt_Surname_Edit, MyEx.tostring());
                }

                try
                {
                    myClient.Forename = txt_Forename_Edit.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txt_Forename_Edit, MyEx.tostring());
                }

                try
                {
                    myClient.Street = rt_Street_Edit.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(rt_Street_Edit, MyEx.tostring());
                }

                try
                {
                    myClient.Town = txt_Town_Edit.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txt_Town_Edit, MyEx.tostring());
                }

                try
                {
                    myClient.County = txt_County_Edit.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txt_County_Edit, MyEx.tostring());
                }

                try
                {
                    myClient.Postcode = txt_Postcode_Edit.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txt_Postcode_Edit, MyEx.tostring());
                }

                try
                {
                    myClient.Country = txt_Country_Edit.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txt_Country_Edit, MyEx.tostring());
                }

                try
                {
                    myClient.TelNo = txt_TelNo_Edit.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txt_TelNo_Edit, MyEx.tostring());
                }

                try
                {
                    myClient.Email = txt_Email_Edit.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txt_Email_Edit, MyEx.tostring());
                }

                try
                {
                    if (chk_Skin_Edit.Checked)
                    {
                        myClient.SkinTest = "Yes";
                    }
                    else
                    {
                        myClient.SkinTest = "No";
                    }
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(chk_Skin_Edit, MyEx.tostring());
                }
                try
                {
                    if (ok)
                    {
                        drclient.BeginEdit();

                        // drclient["ClientNo"] = myClient.ClientNo;
                        drclient["Title"] = myClient.Title;
                        drclient["Surname"] = myClient.Surname;
                        drclient["Forename"] = myClient.Forename;
                        drclient["Street"] = myClient.Street;
                        drclient["Town"] = myClient.Town;
                        drclient["County"] = myClient.County;
                        drclient["PostCode"] = myClient.Postcode;
                        drclient["Country"] = myClient.Country;
                        drclient["TelNo"] = myClient.TelNo;
                        drclient["Email"] = myClient.Email;
                        drclient["SkinTest"] = myClient.SkinTest;

                        drclient.EndEdit();
                        daClient.Update(dsNWRC_HairBeauty, "Client");

                        MessageBox.Show("Customer " + lbl_ClientNo_EditText.Text + " Details have been Updated !!!");

                        cmb_Title_Edit.Enabled = false;
                        txt_Forename_Edit.Enabled = false;
                        txt_Surname_Edit.Enabled = false;
                        rt_Street_Edit.Enabled = false;
                        txt_Town_Edit.Enabled = false;
                        txt_County_Edit.Enabled = false;
                        txt_Postcode_Edit.Enabled = false;
                        txt_Country_Edit.Enabled = false;
                        txt_TelNo_Edit.Enabled = false;
                        txt_Email_Edit.Enabled = false;
                        chk_Skin_Edit.Enabled = false;

                        btn_EditClient.Text = "Edit Client";
                        tab_Client.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Display_Del_Click(object sender, EventArgs e)
        {
            if (dgv_Clients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Client from the list", "Select client");
            }
            else
            {
                drclient = dsNWRC_HairBeauty.Tables["Client"].Rows.Find(dgv_Clients.SelectedRows[0].Cells[0].Value);

                string tempName = drclient["Forename"].ToString() + " " + drclient["Surname"].ToString() + "\'s";

                if (MessageBox.Show("Are you sure you want to delete " + tempName + " details?", "Delete Client", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drclient.Delete();
                    daClient.Update(dsNWRC_HairBeauty, "Client");
                }
            }
        }

        private void btn_Display_Add_Click(object sender, EventArgs e)
        {
            tab_Client.SelectedIndex = 1;
        }

        private void btn_Display_Edit_Click(object sender, EventArgs e)
        {
            tab_Client.SelectedIndex = 2;
        }

        private void txtChanged(object sender, EventArgs e)         // Testing Generic Length Checker
        {
            if (ActiveControl == txt_Forename || ActiveControl == txt_Surname || ActiveControl == txt_Forename_Edit || ActiveControl == txt_Surname_Edit)
            {
                if (!(MyValidation.validLength(ActiveControl.Text, 2, 30)))
                {
                    ActiveControl.BackColor = Color.LightGray;
                    errP.SetError(ActiveControl, "Needs to have between 2 and 20 letters");
                }
                else
                {
                    ActiveControl.BackColor = Color.White;
                    errP.Clear();
                }
            }

            if (ActiveControl == txt_Postcode || ActiveControl == txt_Postcode_Edit)
            {
                if (!(MyValidation.postcodeChk(ActiveControl.Text)))
                {
                    ActiveControl.BackColor = Color.LightGray;
                    errP.SetError(ActiveControl, "Must Be [a-z][a-z][0-9][0-9][SPACE][0-9][a-z][a-z]");
                }
                else
                {
                    ActiveControl.BackColor = Color.White;
                    errP.Clear();
                }
            }

            if (ActiveControl == txt_Email || ActiveControl == txt_Email_Edit)
            {
                if (!(MyValidation.validEmail(ActiveControl.Text)))
                {
                    ActiveControl.BackColor = Color.LightGray;
                    errP.SetError(ActiveControl, "Must Be a valid email address like 'text@text.text' ");
                }
                else
                {
                    ActiveControl.BackColor = Color.White;
                    errP.Clear();
                }
            }

        }

    }
}
