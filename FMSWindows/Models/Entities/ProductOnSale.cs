using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSWindows.Models
{
    public class ProductsOnSale
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public int SellerId { get; set; }
    }
}
