using FMSWindows.Services;
using FMSWindows.Services.Abstract;
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

        public static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IProduct, ProductSaleService>();
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
