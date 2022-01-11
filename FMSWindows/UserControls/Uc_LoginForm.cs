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
using FMSWindows.Services;
using Newtonsoft.Json;

namespace FMSWindows.UserControls
{
    public partial class Uc_LoginForm : UserControl
    {
        public Uc_LoginForm()
        {
            InitializeComponent();
            emailEmptyLabel.Hide();
            passwordEmptyLabel.Hide();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            AuthService authService = new AuthService();

            if (ValidateFields())
            {
                var response = authService.Login(siticoneTextBox1.Text, siticoneTextBox2.Text);
                var deserializeJson = JsonConvert.DeserializeObject(response);

                if (deserializeJson != null && deserializeJson.ToString().Contains("true"))
                {
                    var successObject = JsonConvert.DeserializeObject<SingleResponseModel<TokenModel>>(response);
                    foreach (var operationClaim in successObject.Data.OperationClaims)
                    {
                        if (operationClaim.Name.Contains("admin") || operationClaim.Name.Contains("user"))
                        {
                            MessageBox.Show(successObject.Message, @"Success");
                            Form1.Instance.Hide();
                            DashboardForm dashboardForm = new DashboardForm();
                            dashboardForm.Show();
                        }
                        else
                        {
                            MessageBox.Show(@"You don't have permissions to login admin panel!", $"Error");
                            return;
                        }

                    }
                }

                else if (deserializeJson != null && deserializeJson.ToString().Contains("false"))
                {
                    var successObject = JsonConvert.DeserializeObject<SingleResponseModel<TokenModel>>(response);
                    if (successObject != null) MessageBox.Show(successObject.Message, @"Error");
                }

                else
                {
                    MessageBox.Show("Network error! Error Status: 500", @"Error");
                }
            }


        }

        private bool ValidateFields()
        {
            if (String.IsNullOrWhiteSpace(siticoneTextBox1.Text) && String.IsNullOrWhiteSpace(siticoneTextBox2.Text))
            {
                emailEmptyLabel.Show();
                passwordEmptyLabel.Show();
                WaitForSeconds(2500);
                emailEmptyLabel.Hide();
                passwordEmptyLabel.Hide();
                return false;
            }
            else if (String.IsNullOrWhiteSpace(siticoneTextBox1.Text))
            {
                emailEmptyLabel.Show();
                WaitForSeconds(2500);
                emailEmptyLabel.Hide();
                return false;

            }
            else if (String.IsNullOrWhiteSpace(siticoneTextBox2.Text))
            {
                passwordEmptyLabel.Show();
                WaitForSeconds(2500);
                passwordEmptyLabel.Hide();
                return false;

            }

            return true;
        }

        public void WaitForSeconds(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
