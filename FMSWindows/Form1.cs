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
            
            this.CenterToScreen();
        }

        private void loginPanelButton_Click(object sender, EventArgs e)
        {
            uc_LoginForm2.BringToFront();
        }

        private void registerPanelButton_Click(object sender, EventArgs e)
        {
            uc_RegisterForm1.BringToFront();
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }
    }
}
