using FMSWindows.Models;
using FMSWindows.Models.Constants;
using FMSWindows.Services.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMSWindows.UserControls.Sales_Data
{
    public partial class Uc_SalesData : UserControl
    {
        public static Uc_SalesData Instance;
        public Uc_SalesData()
        {
            InitializeComponent();
        }

        private void Uc_SalesData_Load(object sender, EventArgs e)
        {
            if(Instance == null)
            {
               Instance = this;
            }
            SetDgwProperties();
        }

        private void SetDgwProperties()
        {
            saleDataDgw.ColumnHeadersVisible = true;
            saleDataDgw.ColumnHeadersHeight = 20;
            saleDataDgw.ReadOnly = true;
            saleDataDgw.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in saleDataDgw.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

        }

        public async void GetSalesData()
        {
            IOrder _orderService;
            _orderService = (IOrder)Program.ServiceProvider.GetService(typeof(IOrder));

            try
            {
                saleDataDgw.Columns.Clear();

                var response = await _orderService.GetUserOrders();
                List<OrderDetail> salesData = new List<OrderDetail>();
                salesData = response.Data.Where(d => d.Status == 6).ToList();


                if (salesData.Count <= 0)
                {
                    emptyPicture.Visible = true;
                    return;
                }

                profitText.Text = salesData.Sum(d=> d.Price).ToString() + " TL";
                totalSaleText.Text = salesData.Count.ToString() +" Pieces";
      

                emptyPicture.Visible = false;

                saleDataDgw.Columns.Add("Id", "Id");
                saleDataDgw.Columns.Add("Product Id", "Product Id");
                saleDataDgw.Columns.Add("Product Name", "Product Name");
                saleDataDgw.Columns.Add("Price", "Price");
                saleDataDgw.Columns.Add("Customer Name", "Customer Name");
                saleDataDgw.Columns.Add("Delivery City", "Delivery City");
                saleDataDgw.Columns.Add("Delivery District", "Delivery District");
                saleDataDgw.Columns.Add("Delivery Address", "Delivery Address");
                saleDataDgw.Columns.Add("Bought Date", "Bought Date");
                saleDataDgw.Columns.Add("Status", "Status");

                saleDataDgw.Rows.Add(salesData.Count);
                for (int i = 0; i < salesData.Count; i++)
                {
                    for (int j = 0; j < saleDataDgw.Rows.Count; j++)
                    {
                        saleDataDgw.Rows[j].Cells[0].Value = salesData[j].Id;
                        saleDataDgw.Rows[j].Cells[1].Value = salesData[j].ProductId;
                        saleDataDgw.Rows[j].Cells[2].Value = salesData[j].ProductName.ToUpper();
                        saleDataDgw.Rows[j].Cells[3].Value = salesData[j].Price;
                        saleDataDgw.Rows[j].Cells[4].Value = salesData[j].CustomerName.ToUpper();
                        saleDataDgw.Rows[j].Cells[5].Value = Cities.cities[salesData[j].DeliveryCity].ToUpper();
                        saleDataDgw.Rows[j].Cells[6].Value = salesData[j].DeliveryDistrict.ToUpper();
                        saleDataDgw.Rows[j].Cells[7].Value = salesData[j].DeliveryAddress.ToUpper();
                        saleDataDgw.Rows[j].Cells[8].Value = salesData[j].BoughtDate;
                        saleDataDgw.Rows[j].Cells[9].Value = "SUCCESS";
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            GetSalesData();
        }
    }
}
