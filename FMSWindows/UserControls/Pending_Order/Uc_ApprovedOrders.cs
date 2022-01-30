using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FMSWindows.Models;
using FMSWindows.Models.Constants;
using FMSWindows.Services;
using Siticone.Desktop.UI.WinForms;

namespace FMSWindows.UserControls.Pending_Order
{
    public partial class Uc_ApprovedOrders : UserControl
    {
        public static Uc_ApprovedOrders Instance;
        private string _orderValue;

        public Uc_ApprovedOrders()
        {
            InitializeComponent();
            if (Instance == null)
            {
                Instance = this;
            }
        }

        private void Uc_ApprovedOrders_Load(object sender, EventArgs e)
        {
            SetDgwProperties();
          

        }

        private async void AddDeliveryNo()
        {
            try
            {
                OrderService orderService = new OrderService();

                var response = await orderService.AddDeliveryNo(_orderValue, deliveryTxtBox.Text);

                SiticoneMessageDialog siticoneMessageDialog = new SiticoneMessageDialog();
                if (response.Success)
                {
                    siticoneMessageDialog.Style = MessageDialogStyle.Light;
                    siticoneMessageDialog.Text = response.Message;
                    siticoneMessageDialog.Show();
                    GetApprovedOrders();
                }
                else
                {
                    siticoneMessageDialog.Style = MessageDialogStyle.Light;
                    siticoneMessageDialog.Text = response.Message;
                    siticoneMessageDialog.Show();
                }

            }
            catch (WebException e)
            {

                throw;
            }
        }

        private void SetDgwProperties()
        {
            approvedOrderDgw.ColumnHeadersVisible = true;
            approvedOrderDgw.ColumnHeadersHeight = 20;
            approvedOrderDgw.ReadOnly = true;
            approvedOrderDgw.AllowUserToAddRows = false;

            foreach (DataGridViewColumn column in approvedOrderDgw.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

        }

        public async void GetApprovedOrders()
        {
            try
            {
                approvedOrderDgw.Columns.Clear();
                OrderService orderService = new OrderService();
                var response = await orderService.GetUserOrders();
                List<OrderDetail> orderDetail = new List<OrderDetail>();
                orderDetail = response.Data.Where(d => d.Status == 3).ToList();
                if (orderDetail.Count <= 0)
                {
                    emptyPicture.Visible = true;
                    return;
                }
                emptyPicture.Visible = false;
                //Burada manuel yaptım verileri manipüle etmek istiyordum
                approvedOrderDgw.Columns.Clear();
                approvedOrderDgw.Columns.Add("Id", "Id");
                approvedOrderDgw.Columns.Add("Product Id", "Product Id");
                approvedOrderDgw.Columns.Add("Product Name", "Product Name");
                approvedOrderDgw.Columns.Add("Price", "Price");
                approvedOrderDgw.Columns.Add("Customer Name", "Customer Name");
                approvedOrderDgw.Columns.Add("Delivery City", "City");
                approvedOrderDgw.Columns.Add("Delivery District", "District");
                approvedOrderDgw.Columns.Add("Delivery Address", "Address");
                approvedOrderDgw.Columns.Add("Date", "Date");
                approvedOrderDgw.Columns.Add("Status", "Status");


                approvedOrderDgw.Rows.Add(orderDetail.Count);
         
                for (int i = 0; i < orderDetail.Count; i++)
                {
                    for (int j = 0; j < approvedOrderDgw.Rows.Count; j++)
                    {
                        approvedOrderDgw.Rows[j].Cells[0].Value = orderDetail[j].Id;
                        approvedOrderDgw.Rows[j].Cells[1].Value = orderDetail[j].ProductId;
                        approvedOrderDgw.Rows[j].Cells[2].Value = orderDetail[j].ProductName.ToUpper();
                        approvedOrderDgw.Rows[j].Cells[3].Value = orderDetail[j].Price;
                        approvedOrderDgw.Rows[j].Cells[4].Value = orderDetail[j].CustomerName.ToUpper();
                        approvedOrderDgw.Rows[j].Cells[5].Value = Cities.cities[orderDetail[j].DeliveryCity].ToUpper();
                        approvedOrderDgw.Rows[j].Cells[6].Value = orderDetail[j].DeliveryDistrict.ToUpper();
                        approvedOrderDgw.Rows[j].Cells[7].Value = orderDetail[j].DeliveryAddress.ToUpper();
                        approvedOrderDgw.Rows[j].Cells[8].Value = orderDetail[j].BoughtDate;
                        approvedOrderDgw.Rows[j].Cells[9].Value = Status.status[orderDetail[j].Status].ToUpper();
                    }
                }


            }
            catch (Exception e)
            {
               MessageBox.Show(e.ToString());
            }
        }

        private void approvedOrderDgw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (approvedOrderDgw.CurrentRow != null && approvedOrderDgw.CurrentRow.Selected)
            {
                if (approvedOrderDgw.Rows[e.RowIndex].Cells[0].Value != null)
                    _orderValue = approvedOrderDgw.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void deliveryTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            //Burada kullanıcı doğru hata mesajları ile yönlendirmek çok önemli
            if (String.IsNullOrEmpty(_orderValue) || String.IsNullOrEmpty(deliveryTxtBox.Text))
            {
                SiticoneMessageDialog siticoneMessageDialog = new SiticoneMessageDialog();
                siticoneMessageDialog.Text = "Please select a cell and then enter the delivery number.";
                siticoneMessageDialog.Style = MessageDialogStyle.Default;
                siticoneMessageDialog.Show();
                return;
            }

            AddDeliveryNo();
        }
    }
}
