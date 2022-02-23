using FMSWindows.Models;
using FMSWindows.Services;
using FMSWindows.Services.Abstract;
using FMSWindows.UserControls.Dashboard;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMSWindows
{
    internal static class Program
    {
        public static string Jwt;
        public static string SecurityKey;
        public static int Id;
        public static string Role;

        public static IServiceProvider ServiceProvider { get; set; }
 

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IProduct, ProductSaleService>();
            services.AddTransient<IOrder, OrderService>();
            services.AddTransient<IUser, UserService>();
            services.AddTransient<ICustomer, CustomerService>();
            services.AddTransient<IAuth,AuthService>();
            ServiceProvider = services.BuildServiceProvider();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new Form1());
        }
    }
}
