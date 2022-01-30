using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExampleCode;
using FMSWindows.Models;
using FMSWindows.Models.Constants;
using FMSWindows.Services;
using FMSWindows.Services.Abstract;
using Siticone.Desktop.UI.WinForms;

namespace FMSWindows.UserControls.Pending_Order
{
    public partial class Uc_PendingOrders : UserControl
    {
        public static Uc_PendingOrders Instance;
        List<OrderDetail> orderDetail;
        private string _orderValue;
        IOrder orderDal;
        public Uc_PendingOrders()
        {
            InitializeComponent();
            if (Instance == null)
            {
                Instance = this;
            }
        
        }

        private void Uc_PendingOrders_Load(object sender, EventArgs e)
        {
            SetDgwProperties();
            
        }

        private void SetDgwProperties()
        {
            orderDgw.ColumnHeadersVisible = true;
            orderDgw.ColumnHeadersHeight = 20;
            orderDgw.ReadOnly = true;
            orderDgw.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in orderDgw.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

        }


        public async void GetPendingOrders()
        {
            try
            {

                orderDal = (IOrder)Program.ServiceProvider.GetService(typeof(IOrder));

                var response = await orderDal.GetUserOrders();
               
                orderDetail = new List<OrderDetail>();

                orderDetail = response.Data.Where(d => d.Status == 2).ToList();


                if (orderDetail.Count <= 0)
                {
                    orderDgw.Columns.Clear();
                    emptyPicture.Visible = true;
                    return;
                }

                emptyPicture.Visible = false;
                //Burada manuel yaptım verileri manipüle etmek istiyordum
                orderDgw.Columns.Clear();
                orderDgw.Columns.Add("Id", "Id");
                orderDgw.Columns.Add("Product Id", "Product Id");
                orderDgw.Columns.Add("Product Name", "Product Name");
                orderDgw.Columns.Add("Price", "Price");
                orderDgw.Columns.Add("Customer Name", "Customer Name");
                orderDgw.Columns.Add("Delivery City", "Delivery City");
                orderDgw.Columns.Add("Delivery District", "Delivery District");
                orderDgw.Columns.Add("Delivery Address", "Delivery Address");
                orderDgw.Columns.Add("Bought Date", "Bought Date");
                orderDgw.Columns.Add("Status", "Status");

                orderDgw.Rows.Add(orderDetail.Count);
                for (int i = 0; i < orderDetail.Count; i++)
                {
                    for (int j = 0; j < orderDgw.Rows.Count; j++)
                    {
                        orderDgw.Rows[j].Cells[0].Value = orderDetail[j].Id;
                        orderDgw.Rows[j].Cells[1].Value = orderDetail[j].ProductId;
                        orderDgw.Rows[j].Cells[2].Value = orderDetail[j].ProductName.ToUpper();
                        orderDgw.Rows[j].Cells[3].Value = orderDetail[j].Price;
                        orderDgw.Rows[j].Cells[4].Value = orderDetail[j].CustomerName.ToUpper();
                        orderDgw.Rows[j].Cells[5].Value = Cities.cities[orderDetail[j].DeliveryCity].ToUpper();
                        orderDgw.Rows[j].Cells[6].Value = orderDetail[j].DeliveryDistrict.ToUpper();
                        orderDgw.Rows[j].Cells[7].Value = orderDetail[j].DeliveryAddress.ToUpper();
                        orderDgw.Rows[j].Cells[8].Value = orderDetail[j].BoughtDate;
                        orderDgw.Rows[j].Cells[9].Value = "PENDING";
                    }
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void orderDgw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (orderDgw.CurrentRow != null && orderDgw.CurrentRow.Selected)
            {
                if (orderDgw.Rows[e.RowIndex].Cells[0].Value != null)
                    _orderValue = orderDgw.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private async void siticoneButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(_orderValue))
                {
                    SiticoneMessageDialog messageDialog = new SiticoneMessageDialog();
                    messageDialog.Text = "Please select a row!";
                    messageDialog.Show();
                    return;
                }
                var response = await orderDal.ApproveOrder(_orderValue);
                GetPendingOrders();
                SiticoneMessageDialog siticoneMessageDialog = new SiticoneMessageDialog();
                siticoneMessageDialog.Text = response.Message;
            }
            catch (Exception exception)
            {
                SiticoneMessageDialog siticoneMessageDialog = new SiticoneMessageDialog();
                siticoneMessageDialog.Text = $"Error when approve product : {exception}";
                
            }
        }

        private async void siticoneButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(_orderValue))
                {
                    SiticoneMessageDialog messageDialog = new SiticoneMessageDialog();
                    messageDialog.Text = "Please select a row!";
                    messageDialog.Show();
                    return;
                }

                var response = await orderDal.CancelOrder(_orderValue);
                SiticoneMessageDialog siticoneMessageDialog = new SiticoneMessageDialog();
                siticoneMessageDialog.Text = response.Message;
                siticoneMessageDialog.Show();
                GetPendingOrders();


            }
            catch (Exception exception)
            {
                SiticoneMessageDialog siticoneMessageDialog = new SiticoneMessageDialog();
                siticoneMessageDialog.Text = $"Error when approve cancelling product : {exception}";
            }
           

        }
    }
}
