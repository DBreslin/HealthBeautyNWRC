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
    public partial class frm_Login : Form
    {
        SqlDataAdapter daUserPass;
        DataSet dsNWRC_HairBeauty = new DataSet();
        SqlCommandBuilder cmdBUser;
        String connStr, sqlUserPass;

        private System.Windows.Forms.ErrorProvider errP;
        bool clicked = false;

        public frm_Login()
        {
            InitializeComponent();
            this.FormClosing += login_closing;
        }
        private void login_closing(Object sender, FormClosingEventArgs e)
        {
            if (!(clicked))
            {
                Application.Exit();
            }
            else
            {
               clicked = false;
               e.Cancel = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            errP = new ErrorProvider();

            //connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";
            connStr = @"Data Source = .; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";

            sqlUserPass = @"SELECT * from UserLogin";
            daUserPass = new SqlDataAdapter(sqlUserPass, connStr);
            cmdBUser = new SqlCommandBuilder(daUserPass);
             daUserPass.FillSchema(dsNWRC_HairBeauty, SchemaType.Source, "UserLogin");
            daUserPass.Fill(dsNWRC_HairBeauty, "UserLogin");

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            clicked = true;
            bool userOk = false;
            bool passOk = false;
            lblInfo.Text = "";
            errP.Clear();

            
            foreach (DataRow dr in dsNWRC_HairBeauty.Tables["UserLogin"].Rows)

            {
                if (dr["Username"].ToString() == tb_Username.Text)
                {
                    userOk = true;

                    if (dr["PassKey"].ToString() == tb_Password.Text)
                    {
                        passOk = true;
                        break;
                    }                 
                }
            }

            if ((passOk) && (userOk))
            {
                lblInfo.ForeColor = Color.Green;
                lblInfo.Text = "Login Complete";
                this.Dispose(); // Clears resources instead of leaving them with close 
            }
            else if ((userOk))
            {
                lblInfo.ForeColor = Color.OrangeRed;
                lblInfo.Text = "Invalid Password Please Check and Try again";
            }
            else
            {
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "Invalid Username Please Check and Try again";
            }
        }

    }
}
