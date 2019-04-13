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
    public partial class uc_Treatments : UserControl
    {
        SqlDataAdapter daTreat;
        DataSet dsNWRC_HairBeauty = new DataSet();
        SqlCommandBuilder cmdBTreat;
        DataRow drTreat;
        String connStr, sqlTreat;
        int selectedTab = 0;
        bool TreatSelected = false;
        int TreatNoselected = 0;
        private System.Windows.Forms.ErrorProvider errP;

        public uc_Treatments()
        {
            InitializeComponent();
        }

        private void uc_Treatments_Load(object sender, EventArgs e)
        {
            errP = new ErrorProvider();

            connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";
            //connStr = @"Data Source = .; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";

            sqlTreat = @"SELECT * from Treatments";
            daTreat = new SqlDataAdapter(sqlTreat, connStr);
            cmdBTreat = new SqlCommandBuilder(daTreat);
            daTreat.FillSchema(dsNWRC_HairBeauty, SchemaType.Source, "Treatments");
            daTreat.Fill(dsNWRC_HairBeauty, "Treatments");
            dgv_Treatments.DataSource = dsNWRC_HairBeauty.Tables["Treatments"];

            //// Resize the DatagridView columns to fit the newly loaded content
            dgv_Treatments.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            tab_Treatments.TabPages[0].CausesValidation = true;
            tab_Treatments.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tab_Treatments.TabPages[2].CausesValidation = true;
            tab_Treatments.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);

            tab_Treatments.SelectedIndex = 1;
            tab_Treatments.SelectedIndex = 0;

            // Set Font Size 
            dgv_Treatments.Font = new Font("Times", 10);

            //Fill Columns to panel view
            
            dgv_Treatments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Treatments.Columns[0].Width = 60;
            dgv_Treatments.Columns[1].Width = 75;
            dgv_Treatments.Columns[3].Width = 100;
            dgv_Treatments.Columns[4].Width = 50;
            dgv_Treatments.Columns[4].DefaultCellStyle.Format = "£0.00##";

        }

        private void btn_AddTreat_Click(object sender, EventArgs e)
        {
            MyTreatment myTreat = new MyTreatment();
            bool ok = true;
            errP.Clear();

            try
            {
                myTreat.TreatmentNo = Convert.ToInt32(lbl_TreatNoText.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lbl_TreatNoText, MyEx.tostring());
            }

            try
            {
                myTreat.TreatGroup = cb_TreatGroup.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cb_TreatGroup, MyEx.tostring());
            }

            try
            {
                myTreat.TreatName = txt_TreatName.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txt_TreatName, MyEx.tostring());
            }

            try
            {
                myTreat.TreatType = cb_TreatType.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cb_TreatType, MyEx.tostring());
            }

            try
            {
                myTreat.TreatPrice = Convert.ToDecimal(txt_TreatPrice.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txt_TreatPrice, MyEx.tostring());
            }

            try
            {
                if (ok)
                {
                    drTreat = dsNWRC_HairBeauty.Tables["Treatments"].NewRow();
                    drTreat["TreatmentNo"] = myTreat.TreatmentNo;
                    drTreat["TreatGroup"] = myTreat.TreatGroup;
                    drTreat["TreatName"] = myTreat.TreatName;
                    drTreat["TreatType"] = myTreat.TreatType;
                    drTreat["Price"] = myTreat.TreatPrice;

                    dsNWRC_HairBeauty.Tables["Treatments"].Rows.Add(drTreat);
                    daTreat.Update(dsNWRC_HairBeauty, "Treatments");

                    MessageBox.Show("New User " + lbl_TreatNoText.Text + " added !!!");

                    if (MessageBox.Show("Do you wish to add another Treatment?", "Add Treatment", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber(dsNWRC_HairBeauty.Tables["Treatments"].Rows.Count);
                    }
                    else
                    {
                        tab_Treatments.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void AddTabValidate(object sender, CancelEventArgs e)
        {

        }

        private void EditTabValidate(object sender, CancelEventArgs e)
        {
            if (TreatSelected == false && TreatNoselected == 0)
            {

                // Reset Tab to main and show message to select customer
            }
            else if (dgv_Treatments.SelectedRows.Count == 1)
            {
                TreatSelected = true;
                TreatNoselected = Convert.ToInt32(dgv_Treatments.SelectedRows[0].Cells[0].Value);
            }
        }

        void clearAddForm()
        {
            txt_TreatName.Clear();
            txt_TreatPrice.Clear();
            cb_TreatGroup.SelectedIndex = -1;
            cb_TreatType.SelectedIndex = -1;
        }

        private void getNumber(int noRows)
        {
            drTreat = dsNWRC_HairBeauty.Tables["Treatments"].Rows[noRows - 1];
            lbl_TreatNoText.Text = (int.Parse(drTreat["TreatmentNo"].ToString()) + 1).ToString();
        }

        private void cb_TreatGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_TreatGroup.SelectedItem.ToString() == "Hair")
            {
                cb_TreatType.SelectedItem = "Hairdressing";
                cb_TreatType.Enabled = false;
            }
            else
            {
                cb_TreatType.Enabled = true;
                cb_TreatType.SelectedIndex = -1;
            }
        }

        private void tab_Treatments_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tab_Treatments.SelectedIndex;

            tab_Treatments.TabPages[tab_Treatments.SelectedIndex].Focus();
            tab_Treatments.TabPages[tab_Treatments.SelectedIndex].CausesValidation = true;

            switch (tab_Treatments.SelectedIndex)
            {
                case 0: // View Client Tab
                    {
                        dsNWRC_HairBeauty.Tables["Treatments"].Clear();
                        daTreat.Fill(dsNWRC_HairBeauty, "Treatments");
                        break;
                    }
                case 1:     // Add Client Tab
                    {
                        int noRows = dsNWRC_HairBeauty.Tables["Treatments"].Rows.Count;
                        if (noRows == 0)
                            lbl_TreatNoText.Text = "100";
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
    }
}
