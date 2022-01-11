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

        private async void siticoneButton1_Click(object sender, EventArgs e)
        {
            siticoneButton1.Enabled = false;
            try
            {
                AuthService authService = new AuthService();
                var response = await authService.Register(firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, passwordTextBox.Text);
                
                if (response.Contains("true"))
                {
                    var deserializeResponse = JsonConvert.DeserializeObject<SingleResponseModel<TokenModel>>(response);
                    if (deserializeResponse != null) MessageBox.Show(deserializeResponse.Message, @"Success");
                    Form1.Instance.Hide();
                    DashboardForm dashboardForm = new DashboardForm();
                    dashboardForm.Show();
                }

                else if (response.Contains("Validation failed"))
                {
                    var errorJson = JsonConvert.DeserializeObject<ListErrorModel<ErrorModel>>(response);

                    if (errorJson != null)
                    {
                        errorJson.Message = "";
                        for (int i = 0; i < errorJson.Errors.Length; i++)
                        {
                            errorJson.Message += $"Error {i + 1}: - {errorJson.Errors[i].ErrorMessage} \n\n";
                        }

                        MessageBox.Show(errorJson.Message, $"Error");
                        siticoneButton1.Enabled = true;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Error when trying to connect server!", @"Error");
                siticoneButton1.Enabled = true;
                return;
            }
           


        }
    }
}
