using FMSWindows.UserControls.Animals.Sub_Animals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMSWindows.UserControls.Animals
{
    public partial class Uc_Animals : UserControl
    {
        public Uc_Animals()
        {
            InitializeComponent();
        }

        private void cowPanel_Click(object sender, EventArgs e)
        {
            Uc_Cows.Instance.BringToFront();
        }

        private void sheepPanel_Click(object sender, EventArgs e)
        {
            Uc_Sheeps.Instance.BringToFront();
        }

        private void calvesPanel_Click(object sender, EventArgs e)
        {
            Uc_Calves.Instance.BringToFront();
        }

        private void bullPanel_Click(object sender, EventArgs e)
        {
            Uc_Bulls.Instance.BringToFront();
        }

        private void consumablesPanel_Click(object sender, EventArgs e)
        {

        }

        private void cowsChildPanel_Click(object sender, EventArgs e)
        {
            Uc_Cows.Instance.BringToFront();
        }

        private void sheepsChildPanel_Click(object sender, EventArgs e)
        {
            Uc_Sheeps.Instance.BringToFront();

        }

        private void calvesChildPanel_Click(object sender, EventArgs e)
        {
            Uc_Calves.Instance.BringToFront();

        }

        private void bullsChildPanel_Click(object sender, EventArgs e)
        {
            Uc_Bulls.Instance.BringToFront();

        }


    }
}

