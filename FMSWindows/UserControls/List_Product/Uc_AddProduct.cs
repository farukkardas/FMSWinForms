using FMSWindows.Models;
using FMSWindows.Services.Abstract;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMSWindows.UserControls.List_Product
{
    public partial class Uc_AddProduct : UserControl
    {
        
        string _file;
        byte[] _buffer;
        ProductsOnSale _productsOnSale;

        public Uc_AddProduct()
        {
            InitializeComponent();
            
        }

        private bool ValidateFields()
        {
            SiticoneMessageDialog messageDialog = new SiticoneMessageDialog();
            if (String.IsNullOrWhiteSpace(nameTxtBox.Text) || String.IsNullOrWhiteSpace(priceTxtBox.Text) || String.IsNullOrWhiteSpace(descriptionTxtBox.Text) || String.IsNullOrWhiteSpace(_file))
            {
                messageDialog.Text = "Please fill all fields!";
                messageDialog.Style = MessageDialogStyle.Default;
                messageDialog.Show();
                return false;
            }

            else if(categoryCmbBox.SelectedIndex == 0)
            {
                messageDialog.Text = "Please select category!";
                messageDialog.Style = MessageDialogStyle.Default;
                messageDialog.Show();
                return false;
            }

            return true;
        }


        private void ClearAllFields()
        {
            foreach (var c in this.Controls)
            {
                if (c is SiticoneTextBox)
                {
                    if (!((SiticoneTextBox)c).Name.Contains(priceTxtBox.Name))
                    {
                        ((SiticoneTextBox)c).Text = String.Empty;
                    }
                    else
                    {
                        ((SiticoneTextBox)c).Text = "0";
                    }

                }
            }
        }




        private async void siticoneButton2_Click_1(object sender, EventArgs e)
        {
            IProduct _product;
            _product = (IProduct)Program.ServiceProvider.GetService(typeof(IProduct));
            SiticoneMessageDialog messageDialog = new SiticoneMessageDialog();
            try
            {
                if (ValidateFields())
                {
                    var response = await _product.AddListProduct(_productsOnSale, _buffer, _file);
                    messageDialog.Text = response.Message;
                    messageDialog.Style = MessageDialogStyle.Light;
                    messageDialog.Show();
                    ClearAllFields();
                }
            }
            catch (Exception)
            {
                messageDialog.Text = "Error when trying to add product!";
                messageDialog.Show();
                return;
            }
        }

        private void siticoneButton1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                _file = openFileDialog.FileName;
                _buffer = File.ReadAllBytes(openFileDialog.FileName);
            }
        }

        private void descriptionTxtBox_TextChanged_1(object sender, EventArgs e)
        {
            _productsOnSale.Description = descriptionTxtBox.Text;

        }

        private void categoryCmbBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _productsOnSale.CategoryId = categoryCmbBox.SelectedIndex;

        }

        private void nameTxtBox_TextChanged_1(object sender, EventArgs e)
        {
            _productsOnSale.Name = nameTxtBox.Text;

        }

        private void priceTxtBox_TextChanged_1(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            var res = regex.IsMatch(priceTxtBox.Text);
            if (res)
            {
                _productsOnSale.Price = priceTxtBox.Text;
            }
            else
            {
                SiticoneMessageDialog messageDialog = new SiticoneMessageDialog();
                messageDialog.Text = "Price accepts only number!";
                messageDialog.Show();
                priceTxtBox.Text = String.Empty;
            }
        }

        private void Uc_AddProduct_Load(object sender, EventArgs e)
        {
            _productsOnSale = new ProductsOnSale();

        }
    }
}
