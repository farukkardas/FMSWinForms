using FMSWindows.Models;
using FMSWindows.Models.Constants;
using FMSWindows.Models.Entities;
using FMSWindows.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMSWindows.UserControls.List_Product
{
    public partial class Uc_ListProduct : UserControl
    {
        public static Uc_ListProduct Instance;
        public Uc_ListProduct()
        {
            InitializeComponent();
            if (Instance == null)
            {
                Instance = this;
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            uc_AddProduct1.Visible = !uc_AddProduct1.Visible;
            listProductDgw.Visible = !listProductDgw.Visible;
        }

        private void Uc_ListProduct_Load(object sender, EventArgs e)
        {
            SetDgwProperties();

            uc_AddProduct1.Visible = false;

        }

        private void SetDgwProperties()
        {
            listProductDgw.ColumnHeadersVisible = true;
            listProductDgw.ColumnHeadersHeight = 20;
            listProductDgw.ReadOnly = true;
            listProductDgw.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in listProductDgw.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

        }

        public async void GetProducts()
        {
            try
            {
                listProductDgw.Columns.Clear();
                ProductSaleService productSaleService = new ProductSaleService();
                var response = await productSaleService.GetUserProducts();


                if (response.Data.Length <= 0)
                {
                    emptyPicture.Visible = true;
                    return;
                }

                emptyPicture.Visible = false;
                //Burada manuel yaptım verileri manipüle etmek istiyordum

                listProductDgw.Columns.Add("Id", "Id");
                listProductDgw.Columns.Add("Name", "Name");
                listProductDgw.Columns.Add("Category", "Product Name");
                listProductDgw.Columns.Add("Price", "Price");
                listProductDgw.Columns.Add("Description", "Description");
                listProductDgw.Columns.Add("SellerId", "Seller Id");
                listProductDgw.Columns.Add("Entry Date", "Entry Date");


                listProductDgw.Rows.Add(response.Data.Length);
                for (int i = 0; i < response.Data.Length; i++)
                {
                    for (int j = 0; j < listProductDgw.Rows.Count; j++)
                    {
                        listProductDgw.Rows[j].Cells[0].Value = response.Data[j].Id;
                        listProductDgw.Rows[j].Cells[1].Value = response.Data[j].Name.ToUpper();
                        listProductDgw.Rows[j].Cells[2].Value = Categories.categories[response.Data[j].CategoryId].ToUpper();
                        listProductDgw.Rows[j].Cells[3].Value = response.Data[j].Price;
                        listProductDgw.Rows[j].Cells[4].Value = response.Data[j].Description;
                        listProductDgw.Rows[j].Cells[5].Value = response.Data[j].SellerId;
                        listProductDgw.Rows[j].Cells[6].Value = response.Data[j].EntryDate.ToString();
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
