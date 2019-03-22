using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairBeautyNWRC
{
    public partial class uc_Cust_Btn : UserControl
    {
        public uc_Cust_Btn()
        {
            InitializeComponent();
        }
        // Keep track of whether the button is pressed.
        private bool ClickMeButtonIsPressed = false;   // for better control
        private void btn_Cus_Sched_MouseDown(object sender, MouseEventArgs e)
        {
                ClickMeButtonIsPressed = true;
                btn_Cus_Sched.Image = Properties.Resources.Round_Button_caldown;
        }

        private void btn_Cus_Sched_MouseUp(object sender, MouseEventArgs e)
        {
            ClickMeButtonIsPressed = false;
            btn_Cus_Sched.Image = Properties.Resources.Round_Button_calup;
        }

        private void btn_cust_Home_MouseUp(object sender, MouseEventArgs e)
        {
            ClickMeButtonIsPressed = false;
            btn_cust_Home.Image = Properties.Resources.Round_Button_HomeUp;
        }

        private void btn_cust_Home_MouseDown(object sender, MouseEventArgs e)
        {
            ClickMeButtonIsPressed = true;
            btn_cust_Home.Image = Properties.Resources.Round_Button_HomeDown;
        }

        private void btn_cust_Clients_MouseUp(object sender, MouseEventArgs e)
        {
            ClickMeButtonIsPressed = false;
            btn_cust_Clients.Image = Properties.Resources.Round_Button_clientsup;
        }

        private void btn_cust_Clients_MouseDown(object sender, MouseEventArgs e)
        {
            ClickMeButtonIsPressed = true;
            btn_cust_Clients.Image = Properties.Resources.Round_Button_clientsdown;
        }

        private void btn_cust_Sales_MouseDown(object sender, MouseEventArgs e)
        {
            ClickMeButtonIsPressed = true;
            btn_cust_Sales.Image = Properties.Resources.Round_Button_salesdown;
        }

        private void btn_cust_Sales_MouseUp(object sender, MouseEventArgs e)
        {
            ClickMeButtonIsPressed = false;
            btn_cust_Sales.Image = Properties.Resources.Round_Button_salesup;
        }

        private void btn_cust_Stock_MouseUp(object sender, MouseEventArgs e)
        {
            ClickMeButtonIsPressed = false;
            btn_cust_Stock.Image = Properties.Resources.Round_Button_stockup;
        }

        private void btn_cust_Stock_MouseDown(object sender, MouseEventArgs e)
        {
            ClickMeButtonIsPressed = true;
            btn_cust_Stock.Image = Properties.Resources.Round_Button_stockdown;
        }

        private void btn_cust_User_MouseDown(object sender, MouseEventArgs e)
        {
            ClickMeButtonIsPressed = false;
            btn_cust_User.Image = Properties.Resources.Round_Button_userdown;
        }

        private void btn_cust_User_MouseUp(object sender, MouseEventArgs e)
        {
            ClickMeButtonIsPressed = true;
            btn_cust_User.Image = Properties.Resources.Round_Button_userup;
        }

        private void btn_cust_reports_MouseUp(object sender, MouseEventArgs e)
        {
            ClickMeButtonIsPressed = true;
            btn_cust_reports.Image = Properties.Resources.Round_Button_reportup;
        }

        private void btn_cust_reports_MouseDown(object sender, MouseEventArgs e)
        {
            ClickMeButtonIsPressed = false;
            btn_cust_reports.Image = Properties.Resources.Round_Button_reportdown;
        }

        private void btn_cust_reports_MouseHover(object sender, EventArgs e)
        {
            ClickMeButtonIsPressed = false;
            btn_cust_reports.Image = Properties.Resources.Round_Button_reporthigh;
        }

        private void btn_cust_reports_MouseLeave(object sender, EventArgs e)
        {
            ClickMeButtonIsPressed = false;
            btn_cust_reports.Image = Properties.Resources.Round_Button_reportup;
        }
    }
}
