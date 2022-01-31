using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FMSWindows.Models;
using FMSWindows.Models.Constants;
using FMSWindows.Services.Abstract;

namespace FMSWindows.UserControls.Pending_Order
{
    public partial class Uc_DeliveryOrders : UserControl
    {
        public static Uc_DeliveryOrders Instance;
        List<OrderDetail> _orderDetail;
        IOrder _orderDal;
        public Uc_DeliveryOrders()
        {
            InitializeComponent();
          

            if (Instance == null)
            {
                Instance = this;
            }
        }

        private void Uc_DeliveryOrders_Load(object sender, EventArgs e)
        {
                SetDgwProperties();
        }

        private void SetDgwProperties()
        {
            deliveryDgw.ColumnHeadersVisible = true;
            deliveryDgw.ColumnHeadersHeight = 20;
            deliveryDgw.ReadOnly = true;
            deliveryDgw.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in deliveryDgw.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

        }

        public async void GetDeliveryOrders()
        {
            try
            {
                _orderDal = (IOrder)Program.ServiceProvider.GetService(typeof(IOrder));
                var response = await _orderDal.GetUserOrders();


                _orderDetail =  response.Data.Where(o => o.Status == 5).ToList();
                if (_orderDetail.Count <= 0)
                {
                    emptyPicture.Visible = true;
                    return;
                }
                emptyPicture.Visible = false;

                //Burada manuel yaptım verileri manipüle etmek istiyordum
                deliveryDgw.Columns.Clear();
                deliveryDgw.Columns.Add("Id", "Id");
                deliveryDgw.Columns.Add("Product Id", "Product Id");
                deliveryDgw.Columns.Add("Product Name", "Product Name");
                deliveryDgw.Columns.Add("Price", "Price");
                deliveryDgw.Columns.Add("Customer Name", "Customer Name");
                deliveryDgw.Columns.Add("City", "City");
                deliveryDgw.Columns.Add("District", "District");
                deliveryDgw.Columns.Add("Address", "Delivery Address");
                deliveryDgw.Columns.Add("BoughtDate", "Bought Date");
                deliveryDgw.Columns.Add("Delivery No", "Delivery No");
                deliveryDgw.Columns.Add("Status", "Status");

                deliveryDgw.Rows.Add(_orderDetail.Count);
                for (int i = 0; i < _orderDetail.Count; i++)
                {
                    for (int j = 0; j < deliveryDgw.Rows.Count; j++)
                    {
                        deliveryDgw.Rows[j].Cells[0].Value = _orderDetail[j].Id;
                        deliveryDgw.Rows[j].Cells[1].Value = _orderDetail[j].ProductId;
                        deliveryDgw.Rows[j].Cells[2].Value = _orderDetail[j].ProductName.ToUpper();
                        deliveryDgw.Rows[j].Cells[3].Value = _orderDetail[j].Price;
                        deliveryDgw.Rows[j].Cells[4].Value = _orderDetail[j].CustomerName.ToUpper();
                        deliveryDgw.Rows[j].Cells[5].Value = Cities.cities[_orderDetail[j].DeliveryCity].ToUpper();
                        deliveryDgw.Rows[j].Cells[6].Value = _orderDetail[j].DeliveryDistrict.ToUpper();
                        deliveryDgw.Rows[j].Cells[7].Value = _orderDetail[j].DeliveryAddress.ToUpper();
                        deliveryDgw.Rows[j].Cells[8].Value = _orderDetail[j].BoughtDate;
                        deliveryDgw.Rows[j].Cells[9].Value = _orderDetail[j].DeliveryNo;
                        deliveryDgw.Rows[j].Cells[10].Value = Status.status[_orderDetail[j].Status].ToUpper();
                    }
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }
        }

        private async void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(siticoneTextBox1.Text))
            {
                GetDeliveryOrders();
            }

            try
            {

                _orderDal = (IOrder)Program.ServiceProvider.GetService(typeof(IOrder));

                var response = await _orderDal.GetUserOrders();

                _orderDetail = new List<OrderDetail>();


                _orderDetail = response.Data.Where(o => o.Status == 5).Where(o => o.Id.ToString().Contains(siticoneTextBox1.Text) || o.ProductId.ToString().Contains(siticoneTextBox1.Text)).ToList();

                if (_orderDetail.Count <= 0)
                {
                    return;
                }

                deliveryDgw.Columns.Clear();
                deliveryDgw.Columns.Add("Id", "Id");
                deliveryDgw.Columns.Add("ProductId", "Product Id");
                deliveryDgw.Columns.Add("ProductName", "Product Name");
                deliveryDgw.Columns.Add("Price", "Price");
                deliveryDgw.Columns.Add("CustomerName", "Customer Name");
                deliveryDgw.Columns.Add("City", "City");
                deliveryDgw.Columns.Add("District", "District");
                deliveryDgw.Columns.Add("Address", "Delivery Address");
                deliveryDgw.Columns.Add("BoughtDate", "Bought Date");
                deliveryDgw.Columns.Add("DeliveryNo", "Delivery No");
                deliveryDgw.Columns.Add("Status", "Status");

                deliveryDgw.Rows.Add(_orderDetail.Count);
                for (int i = 0; i < _orderDetail.Count; i++)
                {
                    for (int j = 0; j < deliveryDgw.Rows.Count; j++)
                    {
                        deliveryDgw.Rows[j].Cells[0].Value = _orderDetail[j].Id;
                        deliveryDgw.Rows[j].Cells[1].Value = _orderDetail[j].ProductId;
                        deliveryDgw.Rows[j].Cells[2].Value = _orderDetail[j].ProductName.ToUpper();
                        deliveryDgw.Rows[j].Cells[3].Value = _orderDetail[j].Price;
                        deliveryDgw.Rows[j].Cells[4].Value = _orderDetail[j].CustomerName.ToUpper();
                        deliveryDgw.Rows[j].Cells[5].Value = Cities.cities[_orderDetail[j].DeliveryCity].ToUpper();
                        deliveryDgw.Rows[j].Cells[6].Value = _orderDetail[j].DeliveryDistrict.ToUpper();
                        deliveryDgw.Rows[j].Cells[7].Value = _orderDetail[j].DeliveryAddress.ToUpper();
                        deliveryDgw.Rows[j].Cells[8].Value = _orderDetail[j].BoughtDate;
                        deliveryDgw.Rows[j].Cells[9].Value = _orderDetail[j].DeliveryNo;
                        deliveryDgw.Rows[j].Cells[10].Value = Status.status[_orderDetail[j].Status].ToUpper();
                    }
                }


            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }


        }
    }
}
