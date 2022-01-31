using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FMSWindows.Models;
using Newtonsoft.Json;
using FMSWindows.Services.Abstract;
namespace FMSWindows.Services
{
    public class UserService : IUser
    {
        public async Task<SingleResponseModel<UserDetail>> GetUserDetails()
        {
            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",Program.Jwt);
            httpClient.DefaultRequestHeaders.Add("securityKey",Program.SecurityKey);
            httpClient.DefaultRequestHeaders.Add("id",Program.Id.ToString());

            var post = await httpClient.GetAsync("http://localhost:5000/api/users/getuserdetails");

            var response = post.Content.ReadAsStringAsync();

            Task<string> result = response;


            var decodeJson = JsonConvert.DeserializeObject<SingleResponseModel<UserDetail>>(result.Result);

            return decodeJson;
        }
    }
}
