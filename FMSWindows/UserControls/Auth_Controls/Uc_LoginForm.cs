using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FMSWindows.Models;
using FMSWindows.Services;
using Newtonsoft.Json;
using Siticone.Desktop.UI.WinForms;
using Siticone.Desktop.UI.WinForms.Suite;

namespace FMSWindows.UserControls
{
    public partial class Uc_LoginForm : UserControl
    {
        public Uc_LoginForm()
        {
            InitializeComponent();
            emailEmptyLabel.Hide();
            passwordEmptyLabel.Hide();
            GetCredentials();
            siticoneTextBox2.PasswordChar = '*';
            this.BringToFront();
        }

        private async void siticoneButton1_Click(object sender, EventArgs e)
        {
            siticoneButton1.Enabled = false;
            AuthService authService = new AuthService();

            if (ValidateFields())
            {
                SiticoneMessageDialog siticoneMessageDialog = new SiticoneMessageDialog();
                try
                {
                    var response = await authService.Login(siticoneTextBox1.Text, siticoneTextBox2.Text);
                   
                  
                    if (response.Success)
                    {
                        foreach (var operationClaim in response.Data.OperationClaims)
                        {
                            
                            if (operationClaim.Name.Contains("admin") || operationClaim.Name.Contains("user"))
                            {
                                siticoneMessageDialog.Style = MessageDialogStyle.Light;
                                SaveCredentials();
                                siticoneMessageDialog.Show(response.Message,@"Success");
                                Program.Jwt = response.Data.Token;
                                Program.Id = response.Data.Id;
                                Program.SecurityKey = response.Data.SecurityKey;
                                siticoneButton1.Enabled = true;
                                Form1.Instance.Hide();
                                DashboardForm dashboardForm = new DashboardForm();
                                DashboardForm.Instance.Show();
                            }
                            else
                            {
                                siticoneMessageDialog.Show(@"You don't have permissions to login admin panel!", $"Error");
                                siticoneButton1.Enabled = true;
                                return;
                            }

                        }
                    }
                    else if (!response.Success)
                    {
                        siticoneMessageDialog.Style = MessageDialogStyle.Default;
                        this.SendToBack();
                        siticoneMessageDialog.Icon = MessageDialogIcon.Error;

                        siticoneMessageDialog.Show(response.Message, @"Error");
                        siticoneButton1.Enabled = true;
              
                    }

                    else
                    {
                        siticoneMessageDialog.Style = MessageDialogStyle.Default;
                        siticoneMessageDialog.Icon = MessageDialogIcon.Error;
                        this.SendToBack();
                        siticoneMessageDialog.Show(@"Network error! Error Status: 500", @"Error");
                        siticoneButton1.Enabled = true;
                    }
                }
                catch (Exception exception)
                {
                    siticoneMessageDialog.Style = MessageDialogStyle.Default;
                    siticoneMessageDialog.Icon = MessageDialogIcon.Error;
                    siticoneMessageDialog.Show(@"Error when trying to connect server!", @"Error");
                    siticoneButton1.Enabled = true;
                    return;
                }



            }


        }

        private void SaveCredentials()
        {
            if (rememberMeChck.Checked)
            {
                var path = Directory.GetCurrentDirectory() + "/credentials.txt";
                LoginModel loginModel = new LoginModel();
                loginModel.Email = siticoneTextBox1.Text;
                loginModel.Password = siticoneTextBox2.Text;
                var json = JsonConvert.SerializeObject(loginModel);

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(json);

                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(json);

                    }
                }

            }
        }

        private void GetCredentials()
        {
            var path = "D:\\Development\\VisualStudio\\C#\\FMSWindows\\FMSWindows\\bin\\Debug" + "\\credentials.txt";
            string s = "";
            using (StreamReader sr = File.OpenText(path))
            {
                while ((s = sr.ReadLine()) != null)
                {
                    var model = JsonConvert.DeserializeObject<LoginModel>(s);
                    if (model != null)
                    {
                        siticoneTextBox1.Text = model.Email;
                        siticoneTextBox2.Text = model.Password;
                    }
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

        private void Uc_LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
