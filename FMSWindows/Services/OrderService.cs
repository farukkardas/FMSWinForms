using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FMSWindows.Models;
using FMSWindows.Services.Abstract;
using Newtonsoft.Json;

namespace FMSWindows.Services
{
    public class OrderService : IOrder
    {
        public async Task<ListResponseModel<OrderDetail>> GetUserOrders()
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Program.Jwt);
            client.DefaultRequestHeaders.Add("securityKey", Program.SecurityKey);
            client.DefaultRequestHeaders.Add("id", Program.Id.ToString());

            var post = await client.GetAsync("http://localhost:5000/api/orders/getuserorders");

            var response = post.Content.ReadAsStringAsync();

            Task<string> result = response;


            var decodeJson = JsonConvert.DeserializeObject<ListResponseModel<OrderDetail>>(result.Result);


            return decodeJson;
        }

        public async Task<ResponseModel> ApproveOrder(string orderId)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Program.Jwt);
            client.DefaultRequestHeaders.Add("securityKey", Program.SecurityKey);
            client.DefaultRequestHeaders.Add("id", Program.Id.ToString());


            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("order", orderId),
            });

            var post = await client.PutAsync($"http://localhost:5000/api/orders/approveorder", formContent);

            ResponseModel responseModel = new ResponseModel();

            if (post.Content != null)
            {
                var responseContent = await post.Content.ReadAsStringAsync();

                var deserializeContent =
                    JsonConvert.DeserializeObject<ResponseModel>(responseContent);

                if (deserializeContent != null)
                {
                    responseModel.Message = deserializeContent.Message;
                    responseModel.Success = deserializeContent.Success;
                }
            }

            return responseModel;

        }

        public async Task<ResponseModel> AddDeliveryNo(string order, string deliveryNo)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Program.Jwt);
            client.DefaultRequestHeaders.Add("securityKey", Program.SecurityKey);
            client.DefaultRequestHeaders.Add("id", Program.Id.ToString());

            var formContent = new FormUrlEncodedContent(new[]
            {
                 new KeyValuePair<string, string>("order", order),
                 new KeyValuePair<string, string>("deliveryNo", deliveryNo),
            });

            var post = await client.PutAsync($"http://localhost:5000/api/orders/addcargono", formContent);


            ResponseModel responseModel = new ResponseModel();

            if (post.Content != null)
            {
                var responseContent = await post.Content.ReadAsStringAsync();

                var deserializeContent =
                    JsonConvert.DeserializeObject<ResponseModel>(responseContent);

                if (deserializeContent != null)
                {
                    responseModel.Message = deserializeContent.Message;
                    responseModel.Success = deserializeContent.Success;
                }
            }

            return responseModel;

        }

        public async Task<ResponseModel> CancelOrder(string orderId)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Program.Jwt);
            client.DefaultRequestHeaders.Add("securityKey", Program.SecurityKey);
            client.DefaultRequestHeaders.Add("id", Program.Id.ToString());

            var formContent = new FormUrlEncodedContent(new[]
     {
                 new KeyValuePair<string, string>("orderId", orderId)
            });

            var post = await client.PutAsync($"http://localhost:5000/api/orders/cancelorder", formContent);

            ResponseModel responseModel = new ResponseModel();

            if (post.Content != null)
            {
                var responseContent = await post.Content.ReadAsStringAsync();

                var deserializeContent =
                    JsonConvert.DeserializeObject<ResponseModel>(responseContent);

                if (deserializeContent != null)
                {
                    responseModel.Message = deserializeContent.Message;
                    responseModel.Success = deserializeContent.Success;
                }
            }

            return responseModel;

        }
    }
}
