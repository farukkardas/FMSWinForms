using FMSWindows.Models;
using FMSWindows.Models.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSWindows.Services.Abstract
{
    public interface IProduct
    {
        Task<IResult> AddListProduct(ProductsOnSale productsOnSale, byte[] imageData, string fileName);
        Task<ListResponseModel<Product>> GetUserProducts();
    }
}
