using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSWindows.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int SellerId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public double Price { get; set; }
        public string SellerName { get; set; }
        public string CustomerName { get; set; }
        public int ProductType { get; set; }
        public string ImagePath { get; set; }
        public string ProductName { get; set; }
        public int DeliveryCity { get; set; }
        public string DeliveryDistrict { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime BoughtDate { get; set; }
        public int Status { get; set; }
        public int? DeliveryNo { get; set; }
    }
}
