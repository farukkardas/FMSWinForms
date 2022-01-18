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
        public Uc_ListProduct()
        {
            InitializeComponent();
            //uc_AddListProduct1.Visible = false;
            listProductDgw.Columns.Add("3131","3131");
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            //uc_AddListProduct1.Visible = !uc_AddListProduct1.Visible;
            listProductDgw.Visible = !listProductDgw.Visible;
        }

        private void Uc_ListProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
