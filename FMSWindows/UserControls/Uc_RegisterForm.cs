using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FMSWindows.Models;
using FMSWindows.Models.ResponseModels;
using FMSWindows.Services;
using Newtonsoft.Json;

namespace FMSWindows
{
    public partial class Uc_RegisterForm : UserControl
    {
        public Uc_RegisterForm()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            AuthService authService = new AuthService();
            var response = authService.Register(firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, passwordTextBox.Text);
            var deserializeJson = JsonConvert.DeserializeObject<SingleResponseModel<TokenModel>>(response);

            if (deserializeJson != null && deserializeJson.Success)
            {
                MessageBox.Show(deserializeJson.Message, @"Success");
                Form1.Instance.Hide();
                DashboardForm dashboardForm = new DashboardForm();
                dashboardForm.Show();
            }

            else if (deserializeJson != null && deserializeJson.Success == false)
            {
                var errorJson = JsonConvert.DeserializeObject<ListErrorModel<ErrorModel>>(response);

                
                if (errorJson != null)
                {
                    errorJson.Message = "";
                    for (int i = 0; i < errorJson.Errors.Length; i++)
                    {
                        errorJson.Message += $"Error {i+1}: - {errorJson.Errors[i].ErrorMessage} \n\n";
                    }

                    MessageBox.Show(errorJson.Message,$"Error");
                }
            }

           
        }
    }
}
