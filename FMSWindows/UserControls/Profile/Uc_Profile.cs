using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FMSWindows.Models;
using FMSWindows.Models.Constants;
using FMSWindows.Services.Abstract;

namespace FMSWindows.UserControls.Profile
{
    public partial class Uc_Profile : UserControl
    {
        public static Uc_Profile Instance;
        IUser _userService;
        public Uc_Profile()
        {
            InitializeComponent();
        }

        private void Uc_Profile_Load(object sender, EventArgs e)
        {
         
            if(Instance == null)
            {
                Instance = this;
            }
            addressLabel.AutoSize = true;
            addressLabel.MaximumSize = new Size(400, 0);
        }

        public async void GetDetails()
        {
            _userService = (IUser)Program.ServiceProvider.GetService(typeof(IUser));

            var response = await _userService.GetUserDetails();

            SetProfilePicture(response.Data.ImagePath);

            nameLabel.Text = response.Data.FirstName;
            lastNameLabel.Text = response.Data.LastName;
            if (response.Data.City != null) cityLabel.Text = Cities.cities[(int) response.Data.City].ToString();
            phoneLabel.Text = response.Data.PhoneNumber;
            TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;
            roleLabel.Text = cultInfo.ToTitleCase(response.Data.Role);
            addressLabel.Text = response.Data.Address;
            
        }

        private void SetProfilePicture(string imagePath)
        {
            if (imagePath == null)
            {
                profilePicture.LoadAsync($"http://localhost:5000/uploads/images/default.png");
            }
            else
            {
                profilePicture.LoadAsync($"http://localhost:5000/uploads/{imagePath}");
            }
        }
    }
}
