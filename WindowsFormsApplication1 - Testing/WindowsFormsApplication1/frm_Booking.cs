using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HairBeautyNWRC
{
    public partial class frm_Booking : Form
    {
        SqlDataAdapter daClient, daClient2;
        DataSet dsNWRC_HairBeauty = new DataSet();
        SqlCommandBuilder cmdBClient;
        String connStr, sqlClient, sqlClient2;
        DataRow drclient;
        private bool newClient = false;
        private System.Windows.Forms.ErrorProvider errP;

        public static List<String> bookList;


        public frm_Booking()
        {
            InitializeComponent();
            bookList = new List<String>();
        }
        private void frm_Booking_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                frm_Home.BookNo = (int.Parse(frm_Home.BookNo.ToString()) - 1).ToString();
        }

        private void frm_Booking_Load(object sender, EventArgs e)
        {
            errP = new ErrorProvider();

            //connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";
            connStr = @"Data Source = .; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";

            sqlClient = @"SELECT * from Client";
            daClient = new SqlDataAdapter(sqlClient, connStr);
            cmdBClient = new SqlCommandBuilder(daClient);
            daClient.FillSchema(dsNWRC_HairBeauty, SchemaType.Source, "Client");
            daClient.Fill(dsNWRC_HairBeauty, "Client");

            lbl_BookText.Text = frm_Home.BookNo.ToString();

            // Make name textbox active 
            this.ActiveControl = txt_FindName;
            lbl_NoClient.Text = "That client is not registered on the system.\nPlease Register using the button below";
            btn_AddNewClient.Visible = true;
        }

        private void btn_AddNewClient_Click(object sender, EventArgs e)
        {
            btn_CancelBook.Visible = true;
            newClient = true;
            clearForm();

            //enable Form Entries
            formEnable(true);

            btn_Multibook.Text = "Save Client";

            int noRows = dsNWRC_HairBeauty.Tables["Client"].Rows.Count;

            if (noRows == 0)
                lbl_ClientNoTextBook.Text = "10000";
            else
            {
                getNumber(noRows);
            }
            errP.Clear();
        }

        private void getNumber(int noRows)
        {
            drclient = dsNWRC_HairBeauty.Tables["Client"].Rows[noRows - 1];
            lbl_ClientNoTextBook.Text = (int.Parse(drclient["ClientNo"].ToString()) + 1).ToString();
        }

        private void btn_Multibook_Click(object sender, EventArgs e)
        {
           
            if (lbl_ClientNoTextBook.Text != "")
            {
                
                drclient = dsNWRC_HairBeauty.Tables["Client"].Rows.Find(lbl_ClientNoTextBook.Text);

                if (btn_Multibook.Text == "Edit Client")
                {
                    //enable Form Entries
                    formEnable(true);
                    btn_CancelBook.Visible = true;
                    btn_Multibook.Text = "Save Client";
                }
                else
                {
                    
                        MyClient myClient = new MyClient();
                        bool ok = true;
                        errP.Clear();

                        try
                        { myClient.ClientNo = Convert.ToInt32(lbl_ClientNoTextBook.Text.Trim()); }
                        catch (MyException MyEx)
                        {
                            ok = false;
                            errP.SetError(lbl_ClientNoTextBook, MyEx.ToString());
                        }

                        try
                        { myClient.Title = cmb_TitleBook.Text.Trim(); }
                        catch (MyException MyEx)
                        {
                            ok = false;
                            errP.SetError(cmb_TitleBook, MyEx.tostring());
                        }

                        try
                        { myClient.Surname = txt_SurnameBook.Text.Trim(); }
                        catch (MyException MyEx)
                        {
                            ok = false;
                            errP.SetError(txt_SurnameBook, MyEx.tostring());
                        }

                        try
                        { myClient.Forename = txt_ForenameBook.Text.Trim(); }
                        catch (MyException MyEx)
                        {
                            ok = false;
                            errP.SetError(txt_ForenameBook, MyEx.tostring());
                        }

                        try
                        { myClient.Street = rt_StreetBook.Text.Trim(); }
                        catch (MyException MyEx)
                        {
                            ok = false;
                            errP.SetError(rt_StreetBook, MyEx.tostring());
                        }

                        try
                        { myClient.Town = txt_TownBook.Text.Trim(); }
                        catch (MyException MyEx)
                        {
                            ok = false;
                            errP.SetError(txt_TownBook, MyEx.tostring());
                        }

                        try
                        { myClient.County = txt_CountyBook.Text.Trim(); }
                        catch (MyException MyEx)
                        {
                            ok = false;
                            errP.SetError(txt_CountyBook, MyEx.tostring());
                        }

                        try
                        { myClient.Postcode = txt_PostcodeBook.Text.Trim(); }
                        catch (MyException MyEx)
                        {
                            ok = false;
                            errP.SetError(txt_PostcodeBook, MyEx.tostring());
                        }

                        try
                        { myClient.Country = txt_CountryBook.Text.Trim(); }
                        catch (MyException MyEx)
                        {
                            ok = false;
                            errP.SetError(txt_CountryBook, MyEx.tostring());
                        }

                        try
                        { myClient.TelNo = txt_TelephoneBook.Text.Trim(); }
                        catch (MyException MyEx)
                        {
                            ok = false;
                            errP.SetError(txt_TelephoneBook, MyEx.tostring());
                        }

                        try
                        { myClient.Email = txt_EmailBook.Text.Trim(); }
                        catch (MyException MyEx)
                        {
                            ok = false;
                            errP.SetError(txt_EmailBook, MyEx.tostring());
                        }

                        try
                        {
                            if (chk_SkinBook.Checked)
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
                            errP.SetError(chk_SkinBook, MyEx.tostring());
                        }
                    if (newClient)
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

                        MessageBox.Show("New Customer " + lbl_ClientNoTextBook.Text + " added !!!");
                    }
                    else
                    {

                        try
                        {
                            if (ok)
                            {
                                drclient.BeginEdit();
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

                                MessageBox.Show("Customer " + lbl_ClientNoTextBook.Text + " Details have been Updated !!!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                        }
                        
                    }
                    //Disable Form entries
                    formEnable(false);
                    btn_CancelBook.Visible = false;
                    btn_Multibook.Text = "Edit Client";
                }
            }
        
        }

        private void btn_CancelBook_Click(object sender, EventArgs e)
        {
            formEnable(false);
            btn_CancelBook.Visible = false;
            btn_Multibook.Text = "Edit Client";
            clearForm();
            txt_FindName.Text = "";
            newClient = false;
        }

        private void lb_AvailClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedName = lb_AvailClients.GetItemText(lb_AvailClients.SelectedItem);
            string[] name = selectedName.Split(' ');
            string forename = name[0];
            string surname = name[1];
            txt_FindName.Text = selectedName;
            lb_AvailClients.Visible = false;
            lbl_NoClient.Visible = false;
            btn_AddNewClient.Visible = false;
            newClient = false;

            sqlClient2 = @"SELECT * FROM Client WHERE Forename ='" + forename + "' AND Surname = '" + surname + "'";
            daClient2 = new SqlDataAdapter(sqlClient2, connStr);
            DataTable dt2 = new DataTable();
            daClient2.Fill(dt2);
            drclient = dt2.Rows[0];

            if (drclient["Title"].ToString() == "Mr")
                cmb_TitleBook.SelectedIndex = 0;
            if (drclient["Title"].ToString() == "Mrs")
                cmb_TitleBook.SelectedIndex = 1;
            if (drclient["Title"].ToString() == "Miss")
                cmb_TitleBook.SelectedIndex = 2;
            if (drclient["Title"].ToString() == "Ms")
                cmb_TitleBook.SelectedIndex = 3;
            if (drclient["Title"].ToString() == "Dr")
                cmb_TitleBook.SelectedIndex = 4;

            lbl_ClientNoTextBook.Text = drclient["ClientNo"].ToString();
            txt_ForenameBook.Text = drclient["Forename"].ToString();
            txt_SurnameBook.Text = drclient["Surname"].ToString();
            rt_StreetBook.Text = drclient["Street"].ToString();
            txt_TownBook.Text = drclient["Town"].ToString();
            txt_CountyBook.Text = drclient["County"].ToString();
            txt_PostcodeBook.Text = drclient["Postcode"].ToString();
            txt_CountryBook.Text = drclient["Country"].ToString();
            txt_TelephoneBook.Text = drclient["TelNo"].ToString();
            txt_EmailBook.Text = drclient["Email"].ToString();

            if (drclient["SkinTest"].ToString() == "YES")
            {
                chk_SkinBook.Checked = true;
            }
            else
            {
                chk_SkinBook.Checked = false;
            }
        }

        private void txt_FindSur_TextChanged(object sender, EventArgs e)
        {

            if (txt_FindName.Text == "")
            {
                lb_AvailClients.Visible = false;
                lb_AvailClients.Items.Clear();
            }
            else
            {
                lb_AvailClients.Height = 17;
                lb_AvailClients.Visible = true;
                lb_AvailClients.Items.Clear();
                lb_AvailClients.BackColor = Color.White;
                foreach (DataRow dr in dsNWRC_HairBeauty.Tables["Client"].Rows)
                {
                    String searchInput = MyValidation.firstlettertoUpper(txt_FindName.Text);

                    if (dr["Forename"].ToString().StartsWith(searchInput)) /// changed search from surname to forename
                    {
                        if (!(lb_AvailClients.Items.Contains(dr["Surname"].ToString())))
                            lb_AvailClients.Items.Add(dr["Forename"].ToString() + " " + dr["Surname"].ToString());
                    }
                }
                // Make textbox the size of all clients only
                lb_AvailClients.Height = lb_AvailClients.Height * lb_AvailClients.Items.Count;
            }
            if (lb_AvailClients.Items.Count == 0)
            {
                lbl_NoClient.Visible = true;
                btn_AddNewClient.Visible = true;
            }
            else
            {
                lbl_NoClient.Visible = false;
                btn_AddNewClient.Visible = false;
            }
        }


        private void btn_MakeBook_Click(object sender, EventArgs e)
        {
 
            bookList.Add(lbl_BookText.Text.ToString());
            bookList.Add(lbl_ClientNoTextBook.Text);
            bookList.Add(cmb_TitleBook.Text);
            bookList.Add(txt_ForenameBook.Text);
            bookList.Add(txt_SurnameBook.Text);
            bookList.Add(cb_Treatment.Text);
            bookList.Add(cb_1.Checked.ToString());
            bookList.Add(cb_2.Checked.ToString());
            bookList.Add(cb_3.Checked.ToString());
            bookList.Add(cb_4.Checked.ToString());
            bookList.Add(cb_5.Checked.ToString());
            bookList.Add(cb_6.Checked.ToString());
            bookList.Add(cb_7.Checked.ToString());
            bookList.Add(cb_8.Checked.ToString());
            bookList.Add(cb_9.Checked.ToString());
            bookList.Add(cb_10.Checked.ToString());
            bookList.Add(cb_11.Checked.ToString());
            bookList.Add(cb_12.Checked.ToString());
            bookList.Add(cb_13.Checked.ToString());
            bookList.Add(cb_14.Checked.ToString());
            bookList.Add(cb_15.Checked.ToString());
            bookList.Add(cb_16.Checked.ToString());
            bookList.Add(cb_17.Checked.ToString());
            bookList.Add(cb_18.Checked.ToString());
            bookList.Add(cb_19.Checked.ToString());
            bookList.Add(cb_20.Checked.ToString());

            this.Dispose();
        }

        private void formEnable(bool result)
        {
            cmb_TitleBook.Enabled = result;
            txt_ForenameBook.Enabled = result;
            txt_SurnameBook.Enabled = result;
            rt_StreetBook.Enabled = result;
            txt_TownBook.Enabled = result;
            txt_CountyBook.Enabled = result;
            txt_PostcodeBook.Enabled = result;
            txt_CountryBook.Enabled = result;
            txt_TelephoneBook.Enabled = result;
            txt_EmailBook.Enabled = result;
            chk_SkinBook.Enabled = result;
        }
        private void clearForm()
        {
            lbl_ClientNoTextBook.Text = "";
            cmb_TitleBook.SelectedIndex = -1;
            txt_ForenameBook.Clear();
            txt_SurnameBook.Clear();
            rt_StreetBook.Clear();
            txt_TownBook.Clear();
            txt_CountyBook.Clear();
            txt_PostcodeBook.Clear();
            txt_CountryBook.Clear();
            txt_TelephoneBook.Clear();
            txt_EmailBook.Clear();
            chk_SkinBook.Checked = false;
        }
    }
}
