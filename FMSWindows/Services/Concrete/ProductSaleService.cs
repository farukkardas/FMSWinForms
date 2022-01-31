using FMSWindows.Models;
using FMSWindows.Models.Entities;
using FMSWindows.Models.ResponseModels.Concrete;
using FMSWindows.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMSWindows.Services
{
    public class ProductSaleService : IProduct
    {
        public async Task<IResult> AddListProduct(ProductsOnSale productsOnSale, byte[] imageData, string fileName)
        {

            var httpClient = new HttpClient();
            var requestContent = new MultipartFormDataContent();

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Program.Jwt);
            httpClient.DefaultRequestHeaders.Add("securityKey", Program.SecurityKey);
            httpClient.DefaultRequestHeaders.Add("id", Program.Id.ToString());

            requestContent.Add(new StringContent(productsOnSale.Name),"name");
            requestContent.Add(new StringContent(productsOnSale.Price.ToString()), "price");
            requestContent.Add(new StringContent(productsOnSale.CategoryId.ToString()), "categoryId");
            requestContent.Add(new StringContent(productsOnSale.Description), "description");
            requestContent.Add(new StringContent(Program.Id.ToString()), "sellerId");
            requestContent.Add(new ByteArrayContent(imageData, 0, imageData.Length), "file", fileName);

            var request = await httpClient.PostAsync("http://localhost:5000/api/productsonsale/addproduct", requestContent);
            SuccessResult result = new SuccessResult();
            

            var responseContent = await request.Content.ReadAsStringAsync();
            var deserializeContent =
                JsonConvert.DeserializeObject<ResponseModel>(responseContent);
            if (deserializeContent != null)
            {
                result.Message = deserializeContent.Message;
            }

            return result;
        }

        public async Task<ListResponseModel<Product>> GetUserProducts()
        {
            var httpClient = new HttpClient();
            ListResponseModel<Product> products = new ListResponseModel<Product>();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Program.Jwt);
            httpClient.DefaultRequestHeaders.Add("securityKey", Program.SecurityKey);
            httpClient.DefaultRequestHeaders.Add("id", Program.Id.ToString());


            var request = await httpClient.GetAsync("http://localhost:5000/api/productsonsale/getuserproducts");

            if (request.Content != null)
            {
                var responseContent = await request.Content.ReadAsStringAsync();

                var deserializeContent =
                    JsonConvert.DeserializeObject<ListResponseModel<Product>>(responseContent);

                if (deserializeContent != null)
                {
                    products = deserializeContent;
                }
            }

            return products;
        }
    }
}
