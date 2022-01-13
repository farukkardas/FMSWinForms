using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FMSWindows.Models;
using Newtonsoft.Json;

namespace FMSWindows.Services
{
    public class CustomerService
    {
        public async Task<ListResponseModel<CustomerDetail>> GetCustomerDetails()
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Program.Jwt);

            client.DefaultRequestHeaders.Add("securityKey",Program.SecurityKey);
            client.DefaultRequestHeaders.Add("id",Program.Id.ToString());

            var post = await client.GetAsync("http://localhost:5000/api/customer/getusercustomers");

            var response = post.Content.ReadAsStringAsync();

            Task<string> result = response;

            
            var decodeJson = JsonConvert.DeserializeObject<ListResponseModel<CustomerDetail>>(result.Result);


            return decodeJson;
        }
    }
}
