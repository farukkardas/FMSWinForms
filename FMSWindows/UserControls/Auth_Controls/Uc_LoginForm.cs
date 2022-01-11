using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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

        private async void siticoneButton1_Click(object sender, EventArgs e)
        {
            siticoneButton1.Enabled = false;
            AuthService authService = new AuthService();

            if (ValidateFields())
            {
                try
                {
                    var response = await authService.Login(siticoneTextBox1.Text, siticoneTextBox2.Text);

                    if (response.Success)
                    {
                        foreach (var operationClaim in response.Data.OperationClaims)
                        {
                            if (operationClaim.Name.Contains("admin") || operationClaim.Name.Contains("user"))
                            {
                                MessageBox.Show(response.Message, @"Success");
                                Program.Jwt = response.Data.Token;
                                Program.Id = response.Data.Id;
                                Program.SecurityKey = response.Data.SecurityKey;

                                Form1.Instance.Hide();
                                DashboardForm dashboardForm = new DashboardForm();
                                dashboardForm.Show();
                            }
                            else
                            {
                                MessageBox.Show(@"You don't have permissions to login admin panel!", $"Error");
                                siticoneButton1.Enabled = true;
                                return;
                            }

                        }
                    }

                    else if (!response.Success)
                    {
                        MessageBox.Show(response.Message, @"Error");
                       siticoneButton1.Enabled = true;
                    }

                    else
                    {
                        MessageBox.Show(@"Network error! Error Status: 500", @"Error");
                        siticoneButton1.Enabled = true;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(@"Error when trying to connect server!",@"Error");
                    siticoneButton1.Enabled = true;
                    return;
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
                siticoneButton1.Enabled = true;
                return false;
            }
            else if (String.IsNullOrWhiteSpace(siticoneTextBox1.Text))
            {
                emailEmptyLabel.Show();
                WaitForSeconds(2500);
                emailEmptyLabel.Hide();
                siticoneButton1.Enabled = true;
                return false;

            }
            else if (String.IsNullOrWhiteSpace(siticoneTextBox2.Text))
            {
                passwordEmptyLabel.Show();
                WaitForSeconds(2500);
                passwordEmptyLabel.Hide();
                siticoneButton1.Enabled = true;
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
