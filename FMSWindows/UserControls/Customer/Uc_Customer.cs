using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExampleCode;
using FMSWindows.Models;
using FMSWindows.Services;
using Siticone.Desktop.UI.WinForms;

namespace FMSWindows.UserControls.Customer
{
    public partial class Uc_Customer : UserControl
    {
        public static Uc_Customer Instance;
        public Uc_Customer()
        {
            InitializeComponent();
            if (Instance == null)
            {
                Instance = this;
            }
        }

        private void Uc_Customer_Load(object sender, EventArgs e)
        {
            SetDgwProperties();
            customerDgw.ReadOnly = true;
            customerDgw.AllowUserToAddRows = false;

        }

        public async void GetCustomerDetails()
        {

            try
            {
              
                CustomerService customerService = new CustomerService();
                var response = await customerService.GetCustomerDetails();
                List<CustomerDetail> customerDetails = new List<CustomerDetail>();
                foreach (CustomerDetail customerDetail in response.Data)
                {
                    customerDetails.Add(customerDetail);
                }
                customerDgw.DataSource = new SortableBindingList<CustomerDetail>(customerDetails);
            }
            catch (Exception e)
            {
                SiticoneMessageDialog messageDialog = new SiticoneMessageDialog();
                messageDialog.Style = MessageDialogStyle.Default;
                messageDialog.Show("Error when trying to get customers!");
            }
          




            //Manuel binding

            // customerDgw.Rows.Add(response.Data.Length - 1);
            //for (int i = 0; i < response.Data.Length; i++)
            //{
            //    for (int j = 0; j < customerDgw.Rows.Count; j++)
            //    {
            //        customerDgw.Rows[j].Cells[0].Value = response.Data[j].Id;
            //        customerDgw.Rows[j].Cells[1].Value = response.Data[j].FirstName;
            //        customerDgw.Rows[j].Cells[2].Value = response.Data[j].LastName;
            //        customerDgw.Rows[j].Cells[3].Value = response.Data[j].Address;
            //        customerDgw.Rows[j].Cells[4].Value = response.Data[j].OwnerId;
            //        customerDgw.Rows[j].Cells[5].Value = response.Data[j].PhoneNumber;
            //        customerDgw.Rows[j].Cells[6].Value = response.Data[j].TotalSalesAmount;
            //    }
            //}

        }

        private void SetDgwProperties()
        {
            customerDgw.ColumnHeadersVisible = true;
            customerDgw.ColumnHeadersHeight = 20;

            foreach (DataGridViewColumn column in customerDgw.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

        }


        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            GetCustomerDetails();
        }

        private void customerDgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
