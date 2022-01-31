using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMSWindows.UserControls.Animals.Sub_Animals
{
    public partial class Uc_Calves : UserControl
    {
        public static Uc_Calves Instance;
        public Uc_Calves()
        {
            InitializeComponent();
        }

        private void Uc_Calves_Load(object sender, EventArgs e)
        {
            if(Instance == null)
            {
                Instance = this;
            }
        }
    }
}
