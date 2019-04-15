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
        SqlDataAdapter daClient, daClient2, daTreat, daTreat2;
        DataSet dsNWRC_HairBeauty = new DataSet();
        SqlCommandBuilder cmdBClient, cmdBTreat;
        String connStr, sqlClient, sqlClient2, sqlTreat, sqlTreat2;
        DataRow drclient, drTreat;
        string treatNo = "";

        private bool newClient = false;
        private System.Windows.Forms.ErrorProvider errP;

        public static List<String> bookList;


        public frm_Booking()
        {
            InitializeComponent();
            bookList = new List<String>();
            lbl_salonInfo.Text = frm_Home.salon;
            lbl_SalonNoInfo.Text = frm_Home.salonNo;
        }
        private void frm_Booking_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                frm_Home.BookNo = (int.Parse(frm_Home.BookNo.ToString()) - 1).ToString();

        }

        private void frm_Booking_Load(object sender, EventArgs e)
        {
            errP = new ErrorProvider();

            connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";
            //connStr = @"Data Source = .; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";


            sqlClient = @"SELECT * from Client";
            daClient = new SqlDataAdapter(sqlClient, connStr);
            cmdBClient = new SqlCommandBuilder(daClient);
            daClient.FillSchema(dsNWRC_HairBeauty, SchemaType.Source, "Client");
            daClient.Fill(dsNWRC_HairBeauty, "Client");

            sqlTreat = @"SELECT * from Treatments";
            daTreat = new SqlDataAdapter(sqlTreat, connStr);
            cmdBTreat = new SqlCommandBuilder(daTreat);
            daTreat.FillSchema(dsNWRC_HairBeauty, SchemaType.Source, "Treatments");
            daTreat.Fill(dsNWRC_HairBeauty, "Treatments");

           

            foreach (DataRow dr in dsNWRC_HairBeauty.Tables["Treatments"].Rows)
            {
                if (frm_Home.salon == "Hair")
                {
                    if (dr["TreatType"].ToString() == "Hairdressing")
                        cb_Treatment.Items.Add(dr["TreatName"].ToString());
                }
            }

            if (frm_Home.salon == "Beauty")
            {
                cb_Treatment.Items.Add("**************** Hand and Feet Treats ****************");
                foreach (DataRow dr in dsNWRC_HairBeauty.Tables["Treatments"].Rows)
                {
                    if (dr["TreatType"].ToString() == "Hand and Feet Treats")
                    {
                        cb_Treatment.Items.Add(dr["TreatName"].ToString());
                    }
                }
                cb_Treatment.Items.Add("");
                cb_Treatment.Items.Add("**************** Eye Treatments ****************");
                foreach (DataRow dr in dsNWRC_HairBeauty.Tables["Treatments"].Rows)
                {
                    if (dr["TreatType"].ToString() == "Eye Treatments")
                        cb_Treatment.Items.Add(dr["TreatName"].ToString());
                }
                cb_Treatment.Items.Add("");
                cb_Treatment.Items.Add("**************** Facial Treatments ****************");
                foreach (DataRow dr in dsNWRC_HairBeauty.Tables["Treatments"].Rows)
                {
                    if (dr["TreatType"].ToString() == "Facial Treatments")
                        cb_Treatment.Items.Add(dr["TreatName"].ToString());
                }
                cb_Treatment.Items.Add("");
                cb_Treatment.Items.Add("**************** Body Treatments ****************");
                foreach (DataRow dr in dsNWRC_HairBeauty.Tables["Treatments"].Rows)
                {
                    if (dr["TreatType"].ToString() == "Body Treatments")
                        cb_Treatment.Items.Add(dr["TreatName"].ToString());
                }
                cb_Treatment.Items.Add("");
                cb_Treatment.Items.Add("**************** Waxing ****************");
                foreach (DataRow dr in dsNWRC_HairBeauty.Tables["Treatments"].Rows)
                {
                    if (dr["TreatType"].ToString() == "Waxing")
                        cb_Treatment.Items.Add(dr["TreatName"].ToString());
                }
            }

            lbl_BookText.Text = frm_Home.BookNo.ToString();

            // Make name textbox active 
            this.ActiveControl = txt_FindName;
            lbl_NoClient.Text = "That client is not registered on the system.\nPlease Register using the button below";
            btn_AddNewClient.Visible = true;

            if (bookList.Count > 0)
            {
                btn_DelBook.Visible = true;
                btn_DelAllBook.Visible = true;

                lbl_BookText.Text = bookList[0].ToString();
                txt_FindName.Text = bookList[1].ToString();
                populateClient(txt_FindName.Text);

                foreach (DataRow dr in dsNWRC_HairBeauty.Tables["Treatments"].Rows)
                {
                    if (dr["TreatmentNo"].ToString() == bookList[2].ToString())
                    {
                        cb_Treatment.SelectedItem = (dr["TreatName"].ToString());
                        break;
                    }
                }
                if (bookList[4] == "True")
                    cb_1.Checked = true;
                if (bookList[5] == "True")
                    cb_2.Checked = true;
                if (bookList[6] == "True")
                    cb_3.Checked = true;
                if (bookList[7] == "True")
                    cb_4.Checked = true;
                if (bookList[8] == "True")
                    cb_5.Checked = true;
                if (bookList[9] == "True")
                    cb_6.Checked = true;
                if (bookList[10] == "True")
                    cb_7.Checked = true;
                if (bookList[11] == "True")
                    cb_8.Checked = true;
                if (bookList[12] == "True")
                    cb_9.Checked = true;
                if (bookList[13] == "True")
                    cb_10.Checked = true;
                if (bookList[14] == "True")
                    cb_11.Checked = true;
                if (bookList[15] == "True")
                    cb_12.Checked = true;
                if (bookList[16] == "True")
                    cb_13.Checked = true;
                if (bookList[17] == "True")
                    cb_14.Checked = true;
                if (bookList[18] == "True")
                    cb_15.Checked = true;
                if (bookList[19] == "True")
                    cb_16.Checked = true;
                if (bookList[20] == "True")
                    cb_17.Checked = true;
                if (bookList[21] == "True")
                    cb_18.Checked = true;
                if (bookList[22] == "True")
                    cb_19.Checked = true;
                if (bookList[23] == "True")
                    cb_20.Checked = true;
                bookList.Clear();

            }

        }
        // **************** Add & Edit client Code *****************************
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
        //************************** End of Add/Edit client Code ************************

        private void cb_Treatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectTreat = cb_Treatment.SelectedItem.ToString();
                sqlTreat2 = @"SELECT * FROM Treatments WHERE TreatName ='" + selectTreat + "'";
                daTreat2 = new SqlDataAdapter(sqlTreat2, connStr);
                DataTable treatdt = new DataTable();
                daTreat2.Fill(treatdt);
                drTreat = treatdt.Rows[0];
                tb_Price.Text = decimal.Parse(drTreat["Price"].ToString()).ToString("#,0.00");
                treatNo = drTreat[0].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select a Treatment", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            populateClient(selectedName);
        }

        private void populateClient(string selectedName)
        {
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
            // -- Set bool to true initially
            uc_Schedule.canMakeBook = true;
            int totalcells = 0;

            bookList.Add(lbl_BookText.Text.ToString());
            bookList.Add(lbl_ClientNoTextBook.Text);
            bookList.Add(cmb_TitleBook.Text);
            bookList.Add(txt_ForenameBook.Text);
            bookList.Add(txt_SurnameBook.Text);
            bookList.Add(treatNo);
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

            for (int i = 25; i > 5; i--)
            {
                if (bookList[i].ToString() == "False")
                {
                    totalcells++;
                }
                else
                    break;
            }

            int infield = (uc_Schedule.rowindex + 19) - totalcells;

            if (infield <= 48)
            {
                //uc_Schedule.canMakeBook = true; - only need to set to true once delete this if it works 
                this.Dispose();
            }
            else
            {
                bookList.Clear();
                MessageBox.Show("You cannot make this booking We close at 9pm !!");
                uc_Schedule.canMakeBook = false;
            }
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

        private void btn_DelBook_Click(object sender, EventArgs e)
        {
            DialogResult deleteResult = MessageBox.Show("Do You wish to delete this booking for " + txt_FindName.Text + " ? ", "Delete Current Booking", MessageBoxButtons.YesNo);
            if (deleteResult == DialogResult.Yes)
            {
                uc_Schedule.deleteRecord = true;
                uc_Schedule.canMakeBook = false;
                this.Dispose();
            }
        }

    }
}






