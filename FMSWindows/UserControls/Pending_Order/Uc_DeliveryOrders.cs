﻿using System;
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
    public partial class Uc_DeliveryOrders : UserControl
    {
        public static Uc_DeliveryOrders Instance;
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
            deliveryDgw.ReadOnly = true;
            deliveryDgw.AllowUserToAddRows = false;

        }

        private void SetDgwProperties()
        {
            deliveryDgw.ColumnHeadersVisible = true;
            deliveryDgw.ColumnHeadersHeight = 20;

            foreach (DataGridViewColumn column in deliveryDgw.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

        }

        public async void GetDeliveryOrders()
        {
            try
            {
                OrderService orderService = new OrderService();

                var response = await orderService.GetCustomerDetails();

                List<OrderDetail> orderDetail = new List<OrderDetail>();

                orderDetail = response.Data.Where(d => d.Status == 5).ToList();
                //Burada manuel yaptım verileri manipüle etmek istiyordum
                deliveryDgw.Columns.Clear();
                deliveryDgw.Columns.Add("Id", "Id");
                deliveryDgw.Columns.Add("ProductId", "ProductId");
                deliveryDgw.Columns.Add("ProductName", "ProductName");
                deliveryDgw.Columns.Add("Price", "Price");
                deliveryDgw.Columns.Add("CustomerName", "CustomerName");
                deliveryDgw.Columns.Add("DeliveryCity", "DeliveryCity");
                deliveryDgw.Columns.Add("DeliveryDistrict", "DeliveryDistrict");
                deliveryDgw.Columns.Add("DeliveryAddress", "DeliveryAddress");
                deliveryDgw.Columns.Add("BoughtDate", "BoughtDate");
                deliveryDgw.Columns.Add("DeliveryNo", "DeliveryNo");
                deliveryDgw.Columns.Add("Status", "Status");

                deliveryDgw.Rows.Add(orderDetail.Count);
                for (int i = 0; i < orderDetail.Count; i++)
                {
                    for (int j = 0; j < deliveryDgw.Rows.Count; j++)
                    {
                        deliveryDgw.Rows[j].Cells[0].Value = orderDetail[j].Id;
                        deliveryDgw.Rows[j].Cells[1].Value = orderDetail[j].ProductId;
                        deliveryDgw.Rows[j].Cells[2].Value = orderDetail[j].ProductName.ToUpper();
                        deliveryDgw.Rows[j].Cells[3].Value = orderDetail[j].Price;
                        deliveryDgw.Rows[j].Cells[4].Value = orderDetail[j].CustomerName.ToUpper();
                        deliveryDgw.Rows[j].Cells[5].Value = Cities.cities[orderDetail[j].DeliveryCity].ToUpper();
                        deliveryDgw.Rows[j].Cells[6].Value = orderDetail[j].DeliveryDistrict.ToUpper();
                        deliveryDgw.Rows[j].Cells[7].Value = orderDetail[j].DeliveryAddress.ToUpper();
                        deliveryDgw.Rows[j].Cells[8].Value = orderDetail[j].BoughtDate;
                        deliveryDgw.Rows[j].Cells[9].Value = orderDetail[j].DeliveryNo;
                        deliveryDgw.Rows[j].Cells[10].Value = Status.status[orderDetail[j].Status].ToUpper();
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