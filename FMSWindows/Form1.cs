using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FMSWindows.UserControls;

namespace FMSWindows
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public Form1()
        {
            Instance = this;
            InitializeComponent();
            Instance.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
        }

        private void loginPanelButton_Click(object sender, EventArgs e)
        {
            uc_LoginForm1.BringToFront();
        }

        private void registerPanelButton_Click(object sender, EventArgs e)
        {
            uc_RegisterForm1.BringToFront();
        }

      
    }
}
