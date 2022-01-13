﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FMSWindows.Services;
using FMSWindows.UserControls.Pending_Order;
using Siticone.Desktop.UI.WinForms;

namespace FMSWindows.UserControls.Dashboard
{
    public partial class Uc_Dashboard : UserControl
    {
        public static Uc_Dashboard Instance;
        public Uc_Dashboard()
        {
            InitializeComponent();
            if (Instance == null)
            {
                Instance = this;
            }
        }

        public async void GetUserDetails()
        {
            try
            {
                UserService userService = new UserService();
                var response = await userService.GetUserDetails();
                chart1.DataSource = response.Data;

                saleAmountLabel.Text = response.Data.SuccessfulSales.ToString() + @" Piece";
                canceledLabel.Text = response.Data.CanceledOrders.ToString() + @" Piece";
                pendingLabel.Text = response.Data.PendingOrders.ToString() + @" Piece";
                deliveryLabel.Text = response.Data.DeliveryOrders.ToString() + @" Piece";
                approvedLabel.Text = response.Data.ApprovedOrders.ToString() + @" Piece";

                chart1.Series["Animals"].Points.Clear();
                chart1.Series["Animals"].Points.AddXY("Cow", response.Data.CowCount);
                chart1.Series["Animals"].Points.AddXY("Sheep", response.Data.SheepCount);
                chart1.Series["Animals"].Points.AddXY("Calf", response.Data.CalfCount);
                chart1.Series["Animals"].Points.AddXY("Bull", response.Data.BullCount);
                chart1.Series["Animals"].Points.AddXY("Total", response.Data.AnimalCount);
               
            }
            catch (Exception e)
            {
                SiticoneMessageDialog messageDialog = new SiticoneMessageDialog();
                messageDialog.Style = MessageDialogStyle.Default;
                messageDialog.Icon = MessageDialogIcon.Error;
                messageDialog.Show("Error when trying to get user details!");
                
            }
        }

        private void Uc_Dashboard_Load(object sender, EventArgs e)
        {
            saleAmountLabel.BackColor = Color.Transparent;
            
        }

        private void siticoneCustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        
        private void siticoneCustomGradientPanel2_DoubleClick(object sender, EventArgs e)
        {
            Uc_PendingOrders.Instance.GetPendingOrders();
            Uc_PendingOrders.Instance.BringToFront();
        }

        private void siticoneCustomGradientPanel2_MouseEnter(object sender, EventArgs e)
        {
            siticoneCustomGradientPanel2.Size = new Size(320,135);
            siticoneCustomGradientPanel2.FillColor = Color.Gray;
            siticoneCustomGradientPanel2.FillColor3 = Color.Gray;
        }

        private void siticoneCustomGradientPanel2_MouseLeave(object sender, EventArgs e)
        {
            siticoneCustomGradientPanel2.Size = new Size(300, 126);
            siticoneCustomGradientPanel2.FillColor = Color.DarkOrange;
            siticoneCustomGradientPanel2.FillColor3 = Color.DarkOrange;
        }

        private void siticoneCustomGradientPanel1_MouseEnter(object sender, EventArgs e)
        {
            siticoneCustomGradientPanel1.Size = new Size(320, 135);
            siticoneCustomGradientPanel1.FillColor = Color.Gray;
            siticoneCustomGradientPanel1.FillColor3 = Color.Gray;
        }

        private void siticoneCustomGradientPanel1_MouseLeave(object sender, EventArgs e)
        {
            siticoneCustomGradientPanel1.Size = new Size(300, 126);
            siticoneCustomGradientPanel1.FillColor = Color.LimeGreen;
            siticoneCustomGradientPanel1.FillColor3 = Color.LimeGreen;
        }

        private void siticoneCustomGradientPanel3_MouseEnter(object sender, EventArgs e)
        {
            siticoneCustomGradientPanel3.Size = new Size(320, 135);
            siticoneCustomGradientPanel3.FillColor = Color.Gray;
            siticoneCustomGradientPanel3.FillColor3 = Color.Gray;
        }

        private void siticoneCustomGradientPanel3_MouseLeave(object sender, EventArgs e)
        {
            siticoneCustomGradientPanel3.Size = new Size(300, 126);
            siticoneCustomGradientPanel3.FillColor = Color.Red;
            siticoneCustomGradientPanel3.FillColor3 = Color.Red;
        }

        private void siticoneCustomGradientPanel5_MouseEnter(object sender, EventArgs e)
        {
            siticoneCustomGradientPanel5.Size = new Size(320, 135);
            siticoneCustomGradientPanel5.FillColor = Color.Gray;
            siticoneCustomGradientPanel5.FillColor3 = Color.Gray;
        }

        private void siticoneCustomGradientPanel5_MouseLeave(object sender, EventArgs e)
        {
            siticoneCustomGradientPanel5.Size = new Size(300, 126);
            siticoneCustomGradientPanel5.FillColor = Color.Tan;
            siticoneCustomGradientPanel5.FillColor3 = Color.Maroon;
        }

        private void siticoneCustomGradientPanel4_MouseEnter(object sender, EventArgs e)
        {
            siticoneCustomGradientPanel4.Size = new Size(320, 135);
            siticoneCustomGradientPanel4.FillColor = Color.Gray;
            siticoneCustomGradientPanel4.FillColor3 = Color.Gray;
        }

        private void siticoneCustomGradientPanel4_MouseLeave(object sender, EventArgs e)
        {
            siticoneCustomGradientPanel4.Size = new Size(300, 126);
            siticoneCustomGradientPanel4.FillColor = Color.RoyalBlue;
            siticoneCustomGradientPanel4.FillColor3 = Color.RoyalBlue;
        }

        private void siticoneCustomGradientPanel5_DoubleClick(object sender, EventArgs e)
        {
            Uc_DeliveryOrders.Instance.GetDeliveryOrders();
            Uc_DeliveryOrders.Instance.BringToFront();
        }

        private void siticoneCustomGradientPanel4_DoubleClick(object sender, EventArgs e)
        {
            Uc_ApprovedOrders.Instance.GetApprovedOrders();
            Uc_ApprovedOrders.Instance.BringToFront();
        }
    }
}