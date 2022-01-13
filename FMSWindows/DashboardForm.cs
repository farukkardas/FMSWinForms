using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FMSWindows.UserControls.Customer;
using FMSWindows.UserControls.Dashboard;
using FMSWindows.UserControls.Pending_Order;
using Siticone.Desktop.UI.WinForms;

namespace FMSWindows
{
    public partial class DashboardForm : Form
    {
        public static DashboardForm Instance;
        public DashboardForm()
        {
            if (Instance == null)
            {
                Instance = this;
            }
         
            InitializeComponent();
            this.CenterToScreen();
        }

        private void siticoneGradientCircleButton1_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

 

        private void siticoneGradientCircleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dashboardPanelButton_Click(object sender, EventArgs e)
        {
            uc_Dashboard.BringToFront();
            Uc_Dashboard.Instance.GetUserDetails();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Uc_Customer.Instance.GetCustomerDetails();
            uc_Customer.BringToFront();
        }

        private void listProductButton_Click(object sender, EventArgs e)
        {
            uc_ListProduct1.BringToFront();
        }

        private void pendingOrdersButton_Click(object sender, EventArgs e)
        {
            Uc_PendingOrders.Instance.GetPendingOrders();
            uc_PendingOrders1.BringToFront();
        }

        private void salesDataButton_Click(object sender, EventArgs e)
        {
            uc_SalesData1.BringToFront();
        }

        private void animalsPanelButton_Click(object sender, EventArgs e)
        {
            uc_Animals1.BringToFront();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            Uc_ApprovedOrders.Instance.GetApprovedOrders();
            uc_ApprovedOrders1.BringToFront();
            
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            SiticoneMessageDialog siticoneMessage = new SiticoneMessageDialog();
            siticoneMessage.Style = MessageDialogStyle.Dark;
            siticoneMessage.Buttons = MessageDialogButtons.OKCancel;
            DialogResult res = siticoneMessage.Show("Do you want to logout?");
            if (res == DialogResult.OK)
            {
                Program.Jwt = "";
                Program.SecurityKey = "";
                Program.Id = 0;
                this.Hide();
                Form1.Instance.Show();
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            Uc_Dashboard.Instance.GetUserDetails();
            this.MinimumSize = this.Size;
            

        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            Uc_DeliveryOrders.Instance.GetDeliveryOrders();
            uc_DeliveryOrders1.BringToFront();
        }

      
    }
}
