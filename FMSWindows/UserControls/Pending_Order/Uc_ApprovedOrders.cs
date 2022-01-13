using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FMSWindows.Models;
using FMSWindows.Models.Constants;
using FMSWindows.Services;

namespace FMSWindows.UserControls.Pending_Order
{
    public partial class Uc_ApprovedOrders : UserControl
    {
        public static Uc_ApprovedOrders Instance;
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
            approvedOrderDgw.ReadOnly = true;
            approvedOrderDgw.AllowUserToAddRows = false;

        }

        private void SetDgwProperties()
        {
            approvedOrderDgw.ColumnHeadersVisible = true;
            approvedOrderDgw.ColumnHeadersHeight = 20;

            foreach (DataGridViewColumn column in approvedOrderDgw.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

        }

        public async void GetApprovedOrders()
        {
            try
            {
                OrderService orderService = new OrderService();

                var response = await orderService.GetCustomerDetails();

                List<OrderDetail> orderDetail = new List<OrderDetail>();

                orderDetail = response.Data.Where(d => d.Status == 3).ToList();
                //Burada manuel yaptım verileri manipüle etmek istiyordum
                approvedOrderDgw.Columns.Clear();
                approvedOrderDgw.Columns.Add("Id", "Id");
                approvedOrderDgw.Columns.Add("ProductId", "ProductId");
                approvedOrderDgw.Columns.Add("ProductName", "ProductName");
                approvedOrderDgw.Columns.Add("Price", "Price");
                approvedOrderDgw.Columns.Add("CustomerName", "CustomerName");
                approvedOrderDgw.Columns.Add("DeliveryCity", "DeliveryCity");
                approvedOrderDgw.Columns.Add("DeliveryDistrict", "DeliveryDistrict");
                approvedOrderDgw.Columns.Add("DeliveryAddress", "DeliveryAddress");
                approvedOrderDgw.Columns.Add("BoughtDate", "BoughtDate");
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
                        approvedOrderDgw.Rows[j].Cells[9].Value = "APPROVED";
                    }
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
